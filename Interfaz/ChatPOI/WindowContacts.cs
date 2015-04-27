using LumiSoft.Net.UDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatPOI
{
    public partial class WindowContacts : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream networkStream = default(NetworkStream);
        int _PORT = 55555;
        private volatile bool isConected;

        public UdpServer audioUdpServer;

        public UdpServer videoUdpServer;

        public string myUdpIp;

        public WindowContacts()
        {
            InitializeComponent();

            isConected = true;

            while (!clientSocket.Connected)
            {
                IPAddress myIP = IPAddress.Parse("0.0.0.0");

                IPAddress[] localIP = Dns.GetHostAddresses("Alberto-PC");
                foreach (IPAddress address in localIP)
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        myIP = address;
                    }
                }
                try
                {
                    clientSocket.Connect(myIP, _PORT);
                    networkStream = clientSocket.GetStream();
                    SendString(globals.username + "$$$$");

                    Thread thread = new Thread(getMessage);
                    thread.Start();
                }
                catch (SocketException)
                {
                    return;
                }
            }

            // UPD
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    myUdpIp = Convert.ToString(address);
                }
            }

            audioUdpServer = new UdpServer();
            audioUdpServer.Bindings = new IPEndPoint[] { new IPEndPoint(IPAddress.Parse(myUdpIp), 11000) };

            videoUdpServer = new UdpServer();
            videoUdpServer.Bindings = new IPEndPoint[] { new IPEndPoint(IPAddress.Parse(myUdpIp), 44444) };

            textBoxUserName.Text = globals.username;
            comboBoxUserStatus.SelectedIndex = 0;
            globals.receivedText = null;
        }

        public void SendString(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            networkStream.Write(buffer, 0, buffer.Length);
            networkStream.Flush();
        }

        private void Exit()
        {
            networkStream.Flush();
            SendString("$exit$");
            isConected = false;
            clientSocket.Client.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            networkStream.Close();
            Environment.Exit(0);
        }

        private void getMessage()
        {
            while (isConected)
            {
                networkStream = clientSocket.GetStream();
                byte [] buffer = new byte[10025];
                networkStream.Read(buffer, 0, clientSocket.ReceiveBufferSize);

                globals.receivedText = Encoding.UTF8.GetString(buffer);
                msg();
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
            {
                Actions();
            }
        }

        public void Actions()
        {
            if (globals.receivedText != null)
            {
                if (globals.receivedText.Contains("$$$$"))
                    globals.receivedText = globals.receivedText.Substring(0, globals.receivedText.IndexOf("$$$$"));

                if (globals.receivedText.Substring(0, 4) == "$cl$")
                {
                    dataGridViewContacts.Rows.Clear();
                    string[] clientsConnected = globals.receivedText.Substring(4).Split(',');

                    foreach (string client in clientsConnected)
                    {
                        if (client != globals.username && client != "")
                        {
                            dataGridViewContacts.Rows.Add(new object[] { "Disponible", client, "Mensaje" });
                        }
                    }
                    SendString("$cs$" + globals.username + "$cs$" + comboBoxUserStatus.Text + "$$$$");
                }

                else if (globals.receivedText.Substring(0, 4) == "$cs$")
                {
                    string[] variousMessages = globals.receivedText.Split(',');

                    foreach (string s in variousMessages)
                    {
                        if (s.Length > 4)
                        {
                            string userFrom = s.Substring(4);
                            userFrom = userFrom.Substring(0, userFrom.IndexOf("$cs$"));
                            string status = s.Substring(4);
                            status = status.Substring(status.IndexOf("$cs$") + 4);

                            foreach (DataGridViewRow dg in dataGridViewContacts.Rows)
                            {
                                if (dg.Cells[1].Value.ToString() == userFrom)
                                    dg.Cells[0].Value = status;
                            }
                        }
                    }
                }

                else if (globals.receivedText.Substring(0, 4) == "$mr$")
                {
                    string userFrom = globals.receivedText.Substring(4);
                    userFrom = userFrom.Substring(0, userFrom.IndexOf("$mr$"));
                    string message = globals.receivedText.Substring(4);
                    message = message.Substring(message.IndexOf("$mr$") + 4);

                    if (message.Contains("te ha enviado un zumbido."))
                    {
                        foreach (FormChat f in Application.OpenForms.OfType<FormChat>())
                        {
                            if (f.Text == userFrom)
                            {
                                f.zumbido();
                                f.setMessage("\n" + userFrom + " " + message);
                            }
                        }
                    }
                    else
                    {

                        foreach (DataGridViewRow dg in dataGridViewContacts.Rows)
                        {
                            if (dg.Cells[1].Value.ToString() == userFrom)
                                dg.Cells[2].Value = message;
                        }

                        foreach (FormChat f in Application.OpenForms.OfType<FormChat>())
                        {
                            if (f.Text == userFrom)
                                f.setMessage("\n" + userFrom + ": " + message);
                        }
                    }
                }

                else if (globals.receivedText.Substring(0, 4) == "$gm$")
                {
                    string userFrom = globals.receivedText.Substring(4);
                    userFrom = userFrom.Substring(0, userFrom.IndexOf("$gm$"));
                    string message = globals.receivedText.Substring(4);
                    message = message.Substring(message.IndexOf("$gm$") + 4);

                    foreach (FormChat f in Application.OpenForms.OfType<FormChat>())
                    {
                        if (f.Text == userFrom)
                            f.setMessage(message);
                    }
                }

                else if (globals.receivedText.Substring(0, 4) == "$ip$")
                {
                    string userFrom = globals.receivedText.Substring(4);
                    userFrom = userFrom.Substring(0, userFrom.IndexOf("$ip$"));
                    string message = globals.receivedText.Substring(4);
                    message = message.Substring(message.IndexOf("$ip$") + 4);

                    if (!globals.udpClients.ContainsKey(userFrom))
                        globals.udpClients.Add(userFrom, message);
                    else
                        globals.udpClients[userFrom] = message;
                }

                else
                    return;
            }
            else
            {
                SendString("$cl$");
            }
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Exit();
            Application.Restart();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridViewContacts.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridViewContacts.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "Buscar contacto...")
            {
                dataGridViewContacts.ClearSelection();
                foreach (DataGridViewRow r in dataGridViewContacts.Rows)
                {
                    r.Visible = true;
                    if (!r.Cells[1].Value.ToString().ToLower().Contains(textBoxSearch.Text.ToLower()))
                    {
                        r.Visible = false;
                    }
                }
            }
        }

        private void dataGridViewContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isCreated = false;
            foreach (FormChat temp in Application.OpenForms.OfType<FormChat>())
            {
                if (temp.Text == dataGridViewContacts.Rows[e.RowIndex].Cells[1].Value.ToString())
                {
                    isCreated = true;
                    temp.Focus();
                }
            }
            if (!isCreated)
            {
                FormChat f = new FormChat(dataGridViewContacts.Rows[e.RowIndex].Cells[1].Value.ToString());
                f.Show();
            }

        }

        private void WindowContacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        private void comboBoxUserStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SendString("$cs$" + globals.username + "$cs$" + comboBoxUserStatus.Text + "$$$$");
        }
    }
}
