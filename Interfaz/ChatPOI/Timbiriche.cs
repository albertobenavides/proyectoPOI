using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatPOI
{
    public partial class GameBoard : Form
    {
        int globalX, globalY, globalC;
        string totalLineSelecter;
        int playersCount;
        int playerTurn;
        int[,] linea;
        int player1Points, player2Points, player3Points;
        int contadorTurno;
        List<string> playerNames;

        WindowContacts wc;

        IPEndPoint videoGameTargetEP;
        IPEndPoint videoGameTargetEP1;

        string targetIp;

        string messageReceived;

        public GameBoard(List<string> participantNames, string playerName)
        {
            InitializeComponent();

            foreach (WindowContacts f in Application.OpenForms.OfType<WindowContacts>())
            {
                wc = f;
            }

            foreach (string user in participantNames)
            {
                if (!user.Equals(globals.username))
                    targetIp = globals.udpClients[user];
            }

            try
            {
                videoGameTargetEP = new IPEndPoint(IPAddress.Parse(targetIp), 33333);
            }
            catch
            {
                MessageBox.Show("Usuario no disponible.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            playersCount = participantNames.Count;

            player1Name.Text = participantNames[0];
            player2Name.Text = participantNames[1];

            if (playersCount < 3)
            {
                player3Name.Visible = false;
                player3Score.Visible = false;
            }
            else
            {
                player3Name.Text = participantNames[2];
            }

            for (int i = 0; i < participantNames.Count; i++)
            {
                if (participantNames[i].Equals(playerName))
                {
                    playerTurn = i;
                    break;
                }
            }

            playerNames = participantNames;

            player1Points = 0;
            player2Points = 0;
            player3Points = 0;
            contadorTurno = 0;
            linea = new int[11, 11];

            Thread OI = new Thread(videoGameGetMessage);
            OI.Start();
        }

        void tryGenerador()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(tryGenerador));
            else
            {
                System.Windows.Forms.Button newbutton = new System.Windows.Forms.Button();

                newbutton.Height = 31;
                newbutton.Width = 31;
                newbutton.ForeColor = Color.Black;
                newbutton.BackColor = Color.DarkRed;
                newbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                newbutton.Location = new Point(globalX, globalY);
                newbutton.FlatAppearance.BorderSize = 3;
                newbutton.Enabled = false;
                if (globalC == 1)
                {
                    newbutton.BackColor = Color.Red;
                }
                if (globalC == 2)
                {
                    newbutton.BackColor = Color.Green;

                }
                if (globalC == 3)
                {
                    newbutton.BackColor = Color.Blue;

                }
                Controls.Add(newbutton);
            }
        }

        private void generador(int x, int y, int c)
        {
            globalX = x;
            globalY = y;
            globalC = c;
            tryGenerador();
        }

        public void changeTextbox(int r, int g)
        {
            this.player1Score.Text = Convert.ToString(r);
            this.player2Score.Text = Convert.ToString(g);
        }

        public void puntuaje(int turno)
        {
            if (turno == 1)
                player1Points = player1Points + 1;
            else if (turno == 2)
                player3Points = player3Points + 1;
            else if (turno == 3)
                player2Points = player2Points + 1;
        }

        private void tryTurno()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(tryTurno));
            else
            {
                puntuaje(contadorTurno);
                changeTextbox(player1Points, player2Points);
            }
        }

        public void turno(int x1, int x2, int y1, int y2, string lineSelected)
        {
            string message = "$pg$";
            foreach (string user in playerNames)
            {
                message += user + ",";
            }
            message = message.Substring(0, message.Length - 1);
            message += "$pg$";
            message += x1.ToString() + "," + x2.ToString() + "," + y1.ToString() + "," + y2.ToString();
            message += "$pg$";
            message += lineSelected + "$pg$";
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            wc.videoGameUdpServer.Send(buffer, buffer.Length, videoGameTargetEP);

            thisTurn.Text = contadorTurno.ToString();
            int A;
            int B;
            if (y1 == y2)
            { //linea horizontal
                A = ((y1 - 24) / 30) * 2;
                B = (((x1 - 24) / 30) * 2) + 1;
            }
            else
            { //linea vertical
                B = ((x1 - 24) / 30) * 2;
                A = (((y1 - 24) / 30) * 2) + 1;
            }
            if (linea[A, B] != 3 && linea[A, B] != 2 && linea[A, B] != 1)
            {
                linea[A, B] = contadorTurno;

                if (checarCuadrosIzq(A, B, x1, y1))
                {
                    puntuaje(contadorTurno);
                }

                if (checarCuadrosDer(A, B, x1, y1))
                {
                    puntuaje(contadorTurno);

                }

                changeTextbox(player1Points, player2Points);

                if (contadorTurno == 1)
                {
                    contadorTurno = 0;
                }
                else
                    contadorTurno++;
            }
        }

        private void tryColor()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(tryColor));
            else
            {
                paintLine();
            }
        }

        void paintLine()
        {
            Microsoft.VisualBasic.PowerPacks.LineShape ls = this.GetType().GetField(totalLineSelecter).GetValue(this) as Microsoft.VisualBasic.PowerPacks.LineShape;
            ls.BorderColor = System.Drawing.Color.Black;
            if (contadorTurno == 1)
            {
                contadorTurno = 0;
            }
            else
            contadorTurno++;
        }

        public void turnoExterno(int x1, int x2, int y1, int y2, string lineSelected)
        {
            thisTurn.Text = contadorTurno.ToString();

            totalLineSelecter = lineSelected;

            tryColor();
            int A;
            int B;
            if (y1 == y2)
            { //linea horizontal
                A = ((y1 - 24) / 30) * 2;
                B = (((x1 - 24) / 30) * 2) + 1;
            }
            else
            { //linea vertical
                B = ((x1 - 24) / 30) * 2;
                A = (((y1 - 24) / 30) * 2) + 1;
            }
            if (linea[A, B] != 3 && linea[A, B] != 2 && linea[A, B] != 1)
            {
                linea[A, B] = contadorTurno;

                if (checarCuadrosIzq(A, B, x1, y1))
                {
                    tryTurno();
                }

                if (checarCuadrosDer(A, B, x1, y1))
                {
                    tryTurno();

                }
            }
        }

        public bool checarCuadrosIzq(int a, int b, int x, int y)//cuadro a la izq y cuadro superior
        {
            if (a % 2 == 0)
            { //horizontal
                if (a - 2 >= 0 && b + 1 < 11)
                {
                    if (linea[(a - 2), b] != 0)//check linea superior
                    {
                        if (linea[(a - 1), b - 1] != 0)//check linea izquierdaSuperior
                        {
                            if (linea[(a - 1), b + 1] != 0)//check linea derechaSuperior
                            {
                                generador(x, y - 30, contadorTurno);
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else { return false; }
            }
            else
            {//vertical
                if (b - 2 >= 0 && a + 1 < 11)
                {

                    if (linea[a, (b - 2)] != 0)//check linea izquierda
                    {
                        if (linea[a - 1, (b - 1)] != 0)//check linea izquierdaSuperior
                        {
                            if (linea[a + 1, (b - 1)] != 0)//check linea izquierdaInferior
                            {
                                generador(x - 30, y, contadorTurno);
                                return true;

                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else { return false; }
            }

        }

        public bool checarCuadrosDer(int a, int b, int x, int y)
        {
            if (a % 2 == 0)
            { //horizontal
                if (b - 1 >= 0 && a + 2 < 11 && b + 1 < 11)
                {
                    if (linea[(a + 2), b] != 0)//check linea inferior
                    {
                        if (linea[(a + 1), b - 1] != 0)//check linea derechaInferior
                        {
                            if (linea[(a + 1), b + 1] != 0)//check linea IzquierdaInferior
                            {
                                generador(x, y, contadorTurno);

                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else { return false; }
            }
            else
            {//vertical
                if (a - 1 >= 0 && a + 1 < 11 && b + 2 < 11)
                {
                    if (linea[a, (b + 2)] != 0)//check linea derecha
                    {
                        if (linea[a - 1, (b + 1)] != 0)//check linea derechaSuperior
                        {
                            if (linea[a + 1, (b + 1)] != 0)//check linea derechaInferior
                            {
                                generador(x, y, contadorTurno);

                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else { return false; }
            }
        }

        public List<string> getParticipants()
        {
            return playerNames;
        }

        private void videoGameGetMessage()
        {
            while (true)
            {
                byte[] buffer;
                buffer = wc.videoGameUdpServer.Receive(ref videoGameTargetEP);
                messageReceived = Encoding.UTF8.GetString(buffer);

                string[] users;
                string[] moves;
                if (messageReceived.Substring(0, 4).Equals("$pg$"))
                {
                    messageReceived = messageReceived.Substring(4);
                    string temp = messageReceived.Substring(0, messageReceived.IndexOf("$pg$"));
                    users = temp.Split(',');
                    messageReceived = messageReceived.Substring(messageReceived.IndexOf("$pg$") + 4);
                    temp = messageReceived.Substring(0, messageReceived.IndexOf("$pg$"));
                    moves = temp.Split(',');
                    messageReceived = messageReceived.Substring(messageReceived.IndexOf("$pg$") + 4);
                    string lineSelected = messageReceived.Substring(0, messageReceived.IndexOf("$pg$"));
                    List<string> tempList = new List<string>();
                    foreach (string user in users)
                        tempList.Add(user);
                    if (playerNames.SequenceEqual(tempList))
                        turnoExterno(Convert.ToInt16(moves[0]),
                            Convert.ToInt16(moves[1]),
                            Convert.ToInt16(moves[2]),
                            Convert.ToInt16(moves[3]),
                            lineSelected);
                }

            }
        }


        private void lineShape1_MouseEnter(object sender, EventArgs e) { if (lineShape1.BorderColor != System.Drawing.Color.Black) { lineShape1.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape2_MouseEnter(object sender, EventArgs e) { if (lineShape2.BorderColor != System.Drawing.Color.Black) { lineShape2.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape3_MouseEnter(object sender, EventArgs e) { if (lineShape3.BorderColor != System.Drawing.Color.Black) { lineShape3.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape4_MouseEnter(object sender, EventArgs e) { if (lineShape4.BorderColor != System.Drawing.Color.Black) { lineShape4.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape5_MouseEnter(object sender, EventArgs e) { if (lineShape5.BorderColor != System.Drawing.Color.Black) { lineShape5.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape6_MouseEnter(object sender, EventArgs e) { if (lineShape6.BorderColor != System.Drawing.Color.Black) { lineShape6.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape7_MouseEnter(object sender, EventArgs e) { if (lineShape7.BorderColor != System.Drawing.Color.Black) { lineShape7.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape8_MouseEnter(object sender, EventArgs e) { if (lineShape8.BorderColor != System.Drawing.Color.Black) { lineShape8.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape9_MouseEnter(object sender, EventArgs e) { if (lineShape9.BorderColor != System.Drawing.Color.Black) { lineShape9.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape10_MouseEnter(object sender, EventArgs e) { if (lineShape10.BorderColor != System.Drawing.Color.Black) { lineShape10.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape11_MouseEnter(object sender, EventArgs e) { if (lineShape11.BorderColor != System.Drawing.Color.Black) { lineShape11.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape12_MouseEnter(object sender, EventArgs e) { if (lineShape12.BorderColor != System.Drawing.Color.Black) { lineShape12.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape13_MouseEnter(object sender, EventArgs e) { if (lineShape13.BorderColor != System.Drawing.Color.Black) { lineShape13.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape14_MouseEnter(object sender, EventArgs e) { if (lineShape14.BorderColor != System.Drawing.Color.Black) { lineShape14.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape15_MouseEnter(object sender, EventArgs e) { if (lineShape15.BorderColor != System.Drawing.Color.Black) { lineShape15.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape16_MouseEnter(object sender, EventArgs e) { if (lineShape16.BorderColor != System.Drawing.Color.Black) { lineShape16.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape17_MouseEnter(object sender, EventArgs e) { if (lineShape17.BorderColor != System.Drawing.Color.Black) { lineShape17.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape18_MouseEnter(object sender, EventArgs e) { if (lineShape18.BorderColor != System.Drawing.Color.Black) { lineShape18.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape19_MouseEnter(object sender, EventArgs e) { if (lineShape19.BorderColor != System.Drawing.Color.Black) { lineShape19.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape20_MouseEnter(object sender, EventArgs e) { if (lineShape20.BorderColor != System.Drawing.Color.Black) { lineShape20.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape22_MouseEnter(object sender, EventArgs e) { if (lineShape22.BorderColor != System.Drawing.Color.Black) { lineShape22.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape21_MouseEnter(object sender, EventArgs e) { if (lineShape21.BorderColor != System.Drawing.Color.Black) { lineShape21.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape23_MouseEnter(object sender, EventArgs e) { if (lineShape23.BorderColor != System.Drawing.Color.Black) { lineShape23.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape24_MouseEnter(object sender, EventArgs e) { if (lineShape24.BorderColor != System.Drawing.Color.Black) { lineShape24.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape25_MouseEnter(object sender, EventArgs e) { if (lineShape25.BorderColor != System.Drawing.Color.Black) { lineShape25.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape26_MouseEnter(object sender, EventArgs e) { if (lineShape26.BorderColor != System.Drawing.Color.Black) { lineShape26.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape27_MouseEnter(object sender, EventArgs e) { if (lineShape27.BorderColor != System.Drawing.Color.Black) { lineShape27.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape28_MouseEnter(object sender, EventArgs e) { if (lineShape28.BorderColor != System.Drawing.Color.Black) { lineShape28.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape29_MouseEnter(object sender, EventArgs e) { if (lineShape29.BorderColor != System.Drawing.Color.Black) { lineShape29.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape30_MouseEnter(object sender, EventArgs e) { if (lineShape30.BorderColor != System.Drawing.Color.Black) { lineShape30.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape31_MouseEnter(object sender, EventArgs e) { if (lineShape31.BorderColor != System.Drawing.Color.Black) { lineShape31.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape32_MouseEnter(object sender, EventArgs e) { if (lineShape32.BorderColor != System.Drawing.Color.Black) { lineShape32.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape33_MouseEnter(object sender, EventArgs e) { if (lineShape33.BorderColor != System.Drawing.Color.Black) { lineShape33.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape34_MouseEnter(object sender, EventArgs e) { if (lineShape34.BorderColor != System.Drawing.Color.Black) { lineShape34.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape35_MouseEnter(object sender, EventArgs e) { if (lineShape35.BorderColor != System.Drawing.Color.Black) { lineShape35.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape36_MouseEnter(object sender, EventArgs e) { if (lineShape36.BorderColor != System.Drawing.Color.Black) { lineShape36.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape37_MouseEnter(object sender, EventArgs e) { if (lineShape37.BorderColor != System.Drawing.Color.Black) { lineShape37.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape38_MouseEnter(object sender, EventArgs e) { if (lineShape38.BorderColor != System.Drawing.Color.Black) { lineShape38.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape39_MouseEnter(object sender, EventArgs e) { if (lineShape39.BorderColor != System.Drawing.Color.Black) { lineShape39.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape40_MouseEnter(object sender, EventArgs e) { if (lineShape40.BorderColor != System.Drawing.Color.Black) { lineShape40.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape41_MouseEnter(object sender, EventArgs e) { if (lineShape41.BorderColor != System.Drawing.Color.Black) { lineShape41.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape42_MouseEnter(object sender, EventArgs e) { if (lineShape42.BorderColor != System.Drawing.Color.Black) { lineShape42.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape43_MouseEnter(object sender, EventArgs e) { if (lineShape43.BorderColor != System.Drawing.Color.Black) { lineShape43.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape44_MouseEnter(object sender, EventArgs e) { if (lineShape44.BorderColor != System.Drawing.Color.Black) { lineShape44.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape45_MouseEnter(object sender, EventArgs e) { if (lineShape45.BorderColor != System.Drawing.Color.Black) { lineShape45.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape46_MouseEnter(object sender, EventArgs e) { if (lineShape46.BorderColor != System.Drawing.Color.Black) { lineShape46.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape51_MouseEnter(object sender, EventArgs e) { if (lineShape51.BorderColor != System.Drawing.Color.Black) { lineShape51.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape55_MouseEnter(object sender, EventArgs e) { if (lineShape55.BorderColor != System.Drawing.Color.Black) { lineShape55.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape47_MouseEnter(object sender, EventArgs e) { if (lineShape47.BorderColor != System.Drawing.Color.Black) { lineShape47.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape49_MouseEnter(object sender, EventArgs e) { if (lineShape49.BorderColor != System.Drawing.Color.Black) { lineShape49.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape57_MouseEnter(object sender, EventArgs e) { if (lineShape57.BorderColor != System.Drawing.Color.Black) { lineShape57.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape56_MouseEnter(object sender, EventArgs e) { if (lineShape56.BorderColor != System.Drawing.Color.Black) { lineShape56.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape54_MouseEnter(object sender, EventArgs e) { if (lineShape54.BorderColor != System.Drawing.Color.Black) { lineShape54.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape60_MouseEnter(object sender, EventArgs e) { if (lineShape60.BorderColor != System.Drawing.Color.Black) { lineShape60.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape59_MouseEnter(object sender, EventArgs e) { if (lineShape59.BorderColor != System.Drawing.Color.Black) { lineShape59.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape58_MouseEnter(object sender, EventArgs e) { if (lineShape58.BorderColor != System.Drawing.Color.Black) { lineShape58.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape48_MouseEnter(object sender, EventArgs e) { if (lineShape48.BorderColor != System.Drawing.Color.Black) { lineShape48.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape52_MouseEnter(object sender, EventArgs e) { if (lineShape52.BorderColor != System.Drawing.Color.Black) { lineShape52.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape53_MouseEnter(object sender, EventArgs e) { if (lineShape53.BorderColor != System.Drawing.Color.Black) { lineShape53.BorderColor = System.Drawing.SystemColors.Highlight; } }
        private void lineShape50_MouseEnter(object sender, EventArgs e) { if (lineShape50.BorderColor != System.Drawing.Color.Black) { lineShape50.BorderColor = System.Drawing.SystemColors.Highlight; } }


        private void lineShape2_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape2.X1, lineShape2.X2, lineShape2.Y1, lineShape2.Y2, "lineShape2"); lineShape2.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape3_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape3.X1, lineShape3.X2, lineShape3.Y1, lineShape3.Y2, "lineShape3"); lineShape3.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape4_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape4.X1, lineShape4.X2, lineShape4.Y1, lineShape4.Y2, "lineShape4"); lineShape4.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape5_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape5.X1, lineShape5.X2, lineShape5.Y1, lineShape5.Y2, "lineShape5"); lineShape5.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape6_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape6.X1, lineShape6.X2, lineShape6.Y1, lineShape6.Y2, "lineShape6"); lineShape6.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape7_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape7.X1, lineShape7.X2, lineShape7.Y1, lineShape7.Y2, "lineShape7"); lineShape7.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape8_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape8.X1, lineShape8.X2, lineShape8.Y1, lineShape8.Y2, "lineShape8"); lineShape8.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape9_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape9.X1, lineShape9.X2, lineShape9.Y1, lineShape9.Y2, "lineShape9"); lineShape9.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape1_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape1.X1, lineShape1.X2, lineShape1.Y1, lineShape1.Y2, "lineShape1"); lineShape1.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape10_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape10.X1, lineShape10.X2, lineShape10.Y1, lineShape10.Y2, "lineShape10"); lineShape10.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape11_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape11.X1, lineShape11.X2, lineShape11.Y1, lineShape11.Y2, "lineShape11"); lineShape11.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape12_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape12.X1, lineShape12.X2, lineShape12.Y1, lineShape12.Y2, "lineShape12"); lineShape12.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape13_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape13.X1, lineShape13.X2, lineShape13.Y1, lineShape13.Y2, "lineShape13"); lineShape13.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape14_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape14.X1, lineShape14.X2, lineShape14.Y1, lineShape14.Y2, "lineShape14"); lineShape14.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape15_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape15.X1, lineShape15.X2, lineShape15.Y1, lineShape15.Y2, "lineShape15"); lineShape15.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape16_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape16.X1, lineShape16.X2, lineShape16.Y1, lineShape16.Y2, "lineShape16"); lineShape16.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape17_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape17.X1, lineShape17.X2, lineShape17.Y1, lineShape17.Y2, "lineShape17"); lineShape17.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape18_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape18.X1, lineShape18.X2, lineShape18.Y1, lineShape18.Y2, "lineShape18"); lineShape18.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape19_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape19.X1, lineShape19.X2, lineShape19.Y1, lineShape19.Y2, "lineShape19"); lineShape19.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape20_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape20.X1, lineShape20.X2, lineShape20.Y1, lineShape20.Y2, "lineShape20"); lineShape20.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape22_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape22.X1, lineShape22.X2, lineShape22.Y1, lineShape22.Y2, "lineShape21"); lineShape22.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape21_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape21.X1, lineShape21.X2, lineShape21.Y1, lineShape21.Y2, "lineShape22"); lineShape21.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape23_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape23.X1, lineShape23.X2, lineShape23.Y1, lineShape23.Y2, "lineShape23"); lineShape23.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape24_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape24.X1, lineShape24.X2, lineShape24.Y1, lineShape24.Y2, "lineShape24"); lineShape24.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape25_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape25.X1, lineShape25.X2, lineShape25.Y1, lineShape25.Y2, "lineShape25"); lineShape25.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape26_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape26.X1, lineShape26.X2, lineShape26.Y1, lineShape26.Y2, "lineShape26"); lineShape26.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape27_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape27.X1, lineShape27.X2, lineShape27.Y1, lineShape27.Y2, "lineShape27"); lineShape27.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape28_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape28.X1, lineShape28.X2, lineShape28.Y1, lineShape28.Y2, "lineShape28"); lineShape28.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape29_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape29.X1, lineShape29.X2, lineShape29.Y1, lineShape29.Y2, "lineShape29"); lineShape29.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape30_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape30.X1, lineShape30.X2, lineShape30.Y1, lineShape30.Y2, "lineShape30"); lineShape30.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape31_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape31.X1, lineShape31.X2, lineShape31.Y1, lineShape31.Y2, "lineShape31"); lineShape31.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape32_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape32.X1, lineShape32.X2, lineShape32.Y1, lineShape32.Y2, "lineShape32"); lineShape32.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape33_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape33.X1, lineShape33.X2, lineShape33.Y1, lineShape33.Y2, "lineShape33"); lineShape33.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape34_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape34.X1, lineShape34.X2, lineShape34.Y1, lineShape34.Y2, "lineShape34"); lineShape34.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape35_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape35.X1, lineShape35.X2, lineShape35.Y1, lineShape35.Y2, "lineShape35"); lineShape35.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape36_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape36.X1, lineShape36.X2, lineShape36.Y1, lineShape36.Y2, "lineShape36"); lineShape36.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape37_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape37.X1, lineShape37.X2, lineShape37.Y1, lineShape37.Y2, "lineShape37"); lineShape37.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape38_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape38.X1, lineShape38.X2, lineShape38.Y1, lineShape38.Y2, "lineShape38"); lineShape38.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape39_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape39.X1, lineShape39.X2, lineShape39.Y1, lineShape39.Y2, "lineShape39"); lineShape39.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape40_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape40.X1, lineShape40.X2, lineShape40.Y1, lineShape40.Y2, "lineShape40"); lineShape40.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape41_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape41.X1, lineShape41.X2, lineShape41.Y1, lineShape41.Y2, "lineShape41"); lineShape41.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape42_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape42.X1, lineShape42.X2, lineShape42.Y1, lineShape42.Y2, "lineShape42"); lineShape42.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape43_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape43.X1, lineShape43.X2, lineShape43.Y1, lineShape43.Y2, "lineShape43"); lineShape43.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape44_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape44.X1, lineShape44.X2, lineShape44.Y1, lineShape44.Y2, "lineShape44"); lineShape44.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape45_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape45.X1, lineShape45.X2, lineShape45.Y1, lineShape45.Y2, "lineShape45"); lineShape45.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape46_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape46.X1, lineShape46.X2, lineShape46.Y1, lineShape46.Y2, "lineShape46"); lineShape46.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape51_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape51.X1, lineShape51.X2, lineShape51.Y1, lineShape51.Y2, "lineShape51"); lineShape51.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape55_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape55.X1, lineShape55.X2, lineShape55.Y1, lineShape55.Y2, "lineShape55"); lineShape55.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape47_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape47.X1, lineShape47.X2, lineShape47.Y1, lineShape47.Y2, "lineShape47"); lineShape47.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape49_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape49.X1, lineShape49.X2, lineShape49.Y1, lineShape49.Y2, "lineShape49"); lineShape49.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape57_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape57.X1, lineShape57.X2, lineShape57.Y1, lineShape57.Y2, "lineShape57"); lineShape57.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape56_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape56.X1, lineShape56.X2, lineShape56.Y1, lineShape56.Y2, "lineShape56"); lineShape56.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape54_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape54.X1, lineShape54.X2, lineShape54.Y1, lineShape54.Y2, "lineShape54"); lineShape54.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape60_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape60.X1, lineShape60.X2, lineShape60.Y1, lineShape60.Y2, "lineShape60"); lineShape60.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape59_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape59.X1, lineShape59.X2, lineShape59.Y1, lineShape59.Y2, "lineShape59"); lineShape59.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape58_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape58.X1, lineShape58.X2, lineShape58.Y1, lineShape58.Y2, "lineShape58"); lineShape58.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape48_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape48.X1, lineShape48.X2, lineShape48.Y1, lineShape48.Y2, "lineShape48"); lineShape48.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape52_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape52.X1, lineShape52.X2, lineShape52.Y1, lineShape52.Y2, "lineShape52"); lineShape52.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape53_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape53.X1, lineShape53.X2, lineShape53.Y1, lineShape53.Y2, "lineShape53"); lineShape53.BorderColor = System.Drawing.Color.Black; } }
        private void lineShape50_Click(object sender, EventArgs e) { if (playerTurn == contadorTurno) { this.turno(lineShape50.X1, lineShape50.X2, lineShape50.Y1, lineShape50.Y2, "lineShape50"); lineShape50.BorderColor = System.Drawing.Color.Black; } }

        private void lineShape1_MouseLeave(object sender, EventArgs e) { if (lineShape1.BorderColor != System.Drawing.Color.Black) { lineShape1.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape2_MouseLeave(object sender, EventArgs e) { if (lineShape2.BorderColor != System.Drawing.Color.Black) { lineShape2.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape3_MouseLeave(object sender, EventArgs e) { if (lineShape3.BorderColor != System.Drawing.Color.Black) { lineShape3.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape4_MouseLeave(object sender, EventArgs e) { if (lineShape4.BorderColor != System.Drawing.Color.Black) { lineShape4.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape5_MouseLeave(object sender, EventArgs e) { if (lineShape5.BorderColor != System.Drawing.Color.Black) { lineShape5.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape6_MouseLeave(object sender, EventArgs e) { if (lineShape6.BorderColor != System.Drawing.Color.Black) { lineShape6.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape7_MouseLeave(object sender, EventArgs e) { if (lineShape7.BorderColor != System.Drawing.Color.Black) { lineShape7.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape9_MouseLeave(object sender, EventArgs e) { if (lineShape9.BorderColor != System.Drawing.Color.Black) { lineShape9.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape10_MouseLeave(object sender, EventArgs e) { if (lineShape10.BorderColor != System.Drawing.Color.Black) { lineShape10.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape11_MouseLeave(object sender, EventArgs e) { if (lineShape11.BorderColor != System.Drawing.Color.Black) { lineShape11.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape12_MouseLeave(object sender, EventArgs e) { if (lineShape12.BorderColor != System.Drawing.Color.Black) { lineShape12.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape18_MouseLeave(object sender, EventArgs e) { if (lineShape18.BorderColor != System.Drawing.Color.Black) { lineShape18.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape22_MouseLeave(object sender, EventArgs e) { if (lineShape22.BorderColor != System.Drawing.Color.Black) { lineShape22.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape13_MouseLeave(object sender, EventArgs e) { if (lineShape13.BorderColor != System.Drawing.Color.Black) { lineShape13.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape8_MouseLeave(object sender, EventArgs e) { if (lineShape8.BorderColor != System.Drawing.Color.Black) { lineShape8.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape14_MouseLeave(object sender, EventArgs e) { if (lineShape14.BorderColor != System.Drawing.Color.Black) { lineShape14.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape19_MouseLeave(object sender, EventArgs e) { if (lineShape19.BorderColor != System.Drawing.Color.Black) { lineShape19.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape20_MouseLeave(object sender, EventArgs e) { if (lineShape20.BorderColor != System.Drawing.Color.Black) { lineShape20.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape21_MouseLeave(object sender, EventArgs e) { if (lineShape21.BorderColor != System.Drawing.Color.Black) { lineShape21.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape15_MouseLeave(object sender, EventArgs e) { if (lineShape15.BorderColor != System.Drawing.Color.Black) { lineShape15.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape16_MouseLeave(object sender, EventArgs e) { if (lineShape16.BorderColor != System.Drawing.Color.Black) { lineShape16.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape17_MouseLeave(object sender, EventArgs e) { if (lineShape17.BorderColor != System.Drawing.Color.Black) { lineShape17.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape29_MouseLeave(object sender, EventArgs e) { if (lineShape29.BorderColor != System.Drawing.Color.Black) { lineShape29.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape33_MouseLeave(object sender, EventArgs e) { if (lineShape33.BorderColor != System.Drawing.Color.Black) { lineShape33.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape24_MouseLeave(object sender, EventArgs e) { if (lineShape24.BorderColor != System.Drawing.Color.Black) { lineShape24.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape23_MouseLeave(object sender, EventArgs e) { if (lineShape23.BorderColor != System.Drawing.Color.Black) { lineShape23.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape25_MouseLeave(object sender, EventArgs e) { if (lineShape25.BorderColor != System.Drawing.Color.Black) { lineShape25.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape30_MouseLeave(object sender, EventArgs e) { if (lineShape30.BorderColor != System.Drawing.Color.Black) { lineShape30.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape31_MouseLeave(object sender, EventArgs e) { if (lineShape31.BorderColor != System.Drawing.Color.Black) { lineShape31.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape32_MouseLeave(object sender, EventArgs e) { if (lineShape32.BorderColor != System.Drawing.Color.Black) { lineShape32.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape26_MouseLeave(object sender, EventArgs e) { if (lineShape26.BorderColor != System.Drawing.Color.Black) { lineShape26.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape27_MouseLeave(object sender, EventArgs e) { if (lineShape27.BorderColor != System.Drawing.Color.Black) { lineShape27.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape28_MouseLeave(object sender, EventArgs e) { if (lineShape28.BorderColor != System.Drawing.Color.Black) { lineShape28.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape41_MouseLeave(object sender, EventArgs e) { if (lineShape41.BorderColor != System.Drawing.Color.Black) { lineShape41.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape42_MouseLeave(object sender, EventArgs e) { if (lineShape42.BorderColor != System.Drawing.Color.Black) { lineShape42.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape43_MouseLeave(object sender, EventArgs e) { if (lineShape43.BorderColor != System.Drawing.Color.Black) { lineShape43.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape37_MouseLeave(object sender, EventArgs e) { if (lineShape37.BorderColor != System.Drawing.Color.Black) { lineShape37.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape38_MouseLeave(object sender, EventArgs e) { if (lineShape38.BorderColor != System.Drawing.Color.Black) { lineShape38.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape39_MouseLeave(object sender, EventArgs e) { if (lineShape39.BorderColor != System.Drawing.Color.Black) { lineShape39.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape51_MouseLeave(object sender, EventArgs e) { if (lineShape51.BorderColor != System.Drawing.Color.Black) { lineShape51.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape55_MouseLeave(object sender, EventArgs e) { if (lineShape55.BorderColor != System.Drawing.Color.Black) { lineShape55.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape46_MouseLeave(object sender, EventArgs e) { if (lineShape46.BorderColor != System.Drawing.Color.Black) { lineShape46.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape45_MouseLeave(object sender, EventArgs e) { if (lineShape45.BorderColor != System.Drawing.Color.Black) { lineShape45.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape47_MouseLeave(object sender, EventArgs e) { if (lineShape47.BorderColor != System.Drawing.Color.Black) { lineShape47.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape40_MouseLeave(object sender, EventArgs e) { if (lineShape40.BorderColor != System.Drawing.Color.Black) { lineShape40.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape44_MouseLeave(object sender, EventArgs e) { if (lineShape44.BorderColor != System.Drawing.Color.Black) { lineShape44.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape35_MouseLeave(object sender, EventArgs e) { if (lineShape35.BorderColor != System.Drawing.Color.Black) { lineShape35.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape34_MouseLeave(object sender, EventArgs e) { if (lineShape34.BorderColor != System.Drawing.Color.Black) { lineShape34.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape36_MouseLeave(object sender, EventArgs e) { if (lineShape36.BorderColor != System.Drawing.Color.Black) { lineShape36.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape49_MouseLeave(object sender, EventArgs e) { if (lineShape49.BorderColor != System.Drawing.Color.Black) { lineShape49.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape57_MouseLeave(object sender, EventArgs e) { if (lineShape57.BorderColor != System.Drawing.Color.Black) { lineShape57.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape56_MouseLeave(object sender, EventArgs e) { if (lineShape56.BorderColor != System.Drawing.Color.Black) { lineShape56.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape54_MouseLeave(object sender, EventArgs e) { if (lineShape54.BorderColor != System.Drawing.Color.Black) { lineShape54.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape60_MouseLeave(object sender, EventArgs e) { if (lineShape60.BorderColor != System.Drawing.Color.Black) { lineShape60.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape59_MouseLeave(object sender, EventArgs e) { if (lineShape59.BorderColor != System.Drawing.Color.Black) { lineShape59.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape58_MouseLeave(object sender, EventArgs e) { if (lineShape58.BorderColor != System.Drawing.Color.Black) { lineShape58.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape48_MouseLeave(object sender, EventArgs e) { if (lineShape48.BorderColor != System.Drawing.Color.Black) { lineShape48.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape52_MouseLeave(object sender, EventArgs e) { if (lineShape52.BorderColor != System.Drawing.Color.Black) { lineShape52.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape53_MouseLeave(object sender, EventArgs e) { if (lineShape53.BorderColor != System.Drawing.Color.Black) { lineShape53.BorderColor = System.Drawing.SystemColors.Control; } }

        private void lineShape50_MouseLeave(object sender, EventArgs e) { if (lineShape50.BorderColor != System.Drawing.Color.Black) { lineShape50.BorderColor = System.Drawing.SystemColors.Control; } }

    }

}
