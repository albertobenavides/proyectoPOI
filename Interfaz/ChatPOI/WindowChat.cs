using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

using System.Net;
using System.Threading;

using System.Net.Sockets;

using LumiSoft.Net.UDP;
using LumiSoft.Net.Codec;
using LumiSoft.Media.Wave;
using System.IO;
using AForge.Video.DirectShow;

namespace ChatPOI
{
    public partial class FormChat: Form
    {
        Dictionary<string, Bitmap>  emotions;

        SoundPlayer sp;

        WindowContacts wc;

        // Audio
        
        WaveOut m_pWaveOut;

        WaveIn m_pWaveIn;

        IPEndPoint audioTargetEP;


        // Video

        bool isVideoStreaming = false;

        VideoCaptureDevice videoCaptureDevice;

        Bitmap imageToSend;

        IPEndPoint videoTargetEP;

        public FormChat(string userReceptor)
        {
            InitializeComponent();

            sp = new SoundPlayer(Properties.Resources.zumbido);

            foreach (WindowContacts f in Application.OpenForms.OfType<WindowContacts>())
            {
                wc = f;
            }

            wc.SendString("$ip$" + userReceptor + "$ip$" + wc.myUdpIp + "$$$$");

            labelClientReceiver.Text = userReceptor;
            labelUserName.Text = globals.username;

            this.Text = userReceptor;
            globals.receivedText = null;
            wc.SendString("$gm$" + userReceptor + "$$$$");
            
            BuscarDispositivos();


            emotions = new Dictionary<string, Bitmap>(16);
            emotions.Add(":)", Properties.Resources.emoticons01);
            emotions.Add(":D", Properties.Resources.emoticons02);
            emotions.Add(";)", Properties.Resources.emoticons03);
            emotions.Add(":o", Properties.Resources.emoticons04);
            emotions.Add(":p", Properties.Resources.emoticons05);
            emotions.Add("8)", Properties.Resources.emoticons06);
            emotions.Add(">:(", Properties.Resources.emoticons07);
            emotions.Add(":s", Properties.Resources.emoticons08);
            emotions.Add(":$", Properties.Resources.emoticons09);
            emotions.Add(":(", Properties.Resources.emoticons10);
            emotions.Add(":'(", Properties.Resources.emoticons11);
            emotions.Add(":|", Properties.Resources.emoticons12);
            emotions.Add("<3", Properties.Resources.emoticons13);
            emotions.Add("</3", Properties.Resources.emoticons14);
            emotions.Add(":3", Properties.Resources.emoticons15);
            emotions.Add(":*", Properties.Resources.emoticons16);
            groupBoxEmoticons.Visible = false;
        }

        private void BuscarDispositivos()
        {
            try
            {
                FilterInfoCollection DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoCaptureDevice = new VideoCaptureDevice(DispositivoDeVideo[0].MonikerString);
            }
            catch (Exception)
            {
                MessageBox.Show("No tienes cámara");
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (richTextBoxMessage.Text != "")
            sendMessage();
        }

        public void setMessage(string s)
        {
            richTextBoxChat.AppendText(s);
            foreach (string emote in emotions.Keys)
            {
                while (richTextBoxChat.Text.Contains(emote))
                {
                    int ind = richTextBoxChat.Text.IndexOf(emote);
                    richTextBoxChat.Select(ind, emote.Length);
                    Clipboard.SetImage((Image)emotions[emote]);
                    richTextBoxChat.Paste();
                }
            }
            richTextBoxChat.ScrollToCaret();
        }

        private void richTextBoxMessage_TextChanged(object sender, EventArgs e)
        {
            foreach (string emote in emotions.Keys)
            {
                while (richTextBoxMessage.Text.Contains(emote))
                {
                    int ind = richTextBoxMessage.Text.IndexOf(emote);
                    richTextBoxMessage.Select(ind, emote.Length);
                    Clipboard.SetImage((Image)emotions[emote]);
                    richTextBoxMessage.Paste();
                }
            }
        }

        private void richTextBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && richTextBoxMessage.Text != "")
                sendMessage();
        }

        private void sendMessage()
        {
            string s;
            s = "$sm$";
            s += this.Text;
            s += "$sm$";

            for (int i = 0; i < richTextBoxMessage.Text.Length; i++)
            {
                if (richTextBoxMessage.Text[i] == ' ')
                {
                    richTextBoxMessage.Select(i, 1);
                    if ((richTextBoxMessage.SelectionType & RichTextBoxSelectionTypes.Object) == RichTextBoxSelectionTypes.Object)
                    {
                        Clipboard.Clear();
                        richTextBoxMessage.Copy();
                        Bitmap temp = (Bitmap)Clipboard.GetData("Bitmap");
                        foreach (Bitmap b in emotions.Values)
                        {
                            if (temp.GetPixel(17, 19) == b.GetPixel(17, 19)
                                && temp.GetPixel(6, 12) == b.GetPixel(6, 12))
                            {
                                s += emotions.FirstOrDefault(x => x.Value == b).Key;
                            }
                        }
                    }
                    else
                        s += richTextBoxMessage.Text[i];
                }
                else
                    s += richTextBoxMessage.Text[i];
            }

            wc.SendString(s + "$$$$");
            s = s.Substring(4);
            s = s.Substring(s.IndexOf("$sm$") + 4);
            richTextBoxChat.AppendText("\nTú: " + s);
            foreach (string emote in emotions.Keys)
            {
                while (richTextBoxChat.Text.Contains(emote))
                {
                    int ind = richTextBoxChat.Text.IndexOf(emote);
                    richTextBoxChat.Select(ind, emote.Length);
                    Clipboard.SetImage((Image)emotions[emote]);
                    richTextBoxChat.Paste();
                }
            }
            richTextBoxChat.ScrollToCaret();
            richTextBoxMessage.Text = "";
            richTextBoxMessage.Focus();
        }

        private void buttonEmoticon_Click(object sender, EventArgs e)
        {
            groupBoxEmoticons.Visible = true;
            groupBoxEmoticons.Focus();
        }

        private void buttonEmoti1_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(":)");
            groupBoxEmoticons.Visible = false;      
        }

        private void groupBoxEmoticons_Leave(object sender, EventArgs e)
        {
            groupBoxEmoticons.Visible = false;
        }

        private void buttonEmoti2_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(":D");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti3_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(";)");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti4_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(":o");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti5_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(":p");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti6_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText("8)");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti7_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(">:(");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti8_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(":s");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti9_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(":$");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti11_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(":(");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti12_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(":'(");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti13_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText("<3");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti14_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText("</3");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti15_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(":3");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonEmoti16_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(":*");
            groupBoxEmoticons.Visible = false;   
        }

        private void buttonBuzz_Click(object sender, EventArgs e)
        {
            zumbido();

            string s;
            s = "$sm$";
            s += this.Text + ",";
            s += "$sm$";
            s += "te ha enviado un zumbido.";

            wc.SendString(s + "$$$$");
            s = s.Substring(4);
            s = s.Substring(s.IndexOf("$sm$") + 4);
            richTextBoxChat.AppendText("\nTú has enviado un zumbido.");

            richTextBoxChat.ScrollToCaret();
            richTextBoxMessage.Focus();
        }

        public void zumbido()
        {
            var inicial = this.Location;
            var rnd = new Random(1500);
            const int t = 10;
            for (int i = 0; i < 10; i++)
            {
                this.Location = new Point(inicial.X + rnd.Next(-t, t), inicial.Y + rnd.Next(-t, t));
                System.Threading.Thread.Sleep(20);
            }

            sp.Play();

            this.Location = inicial;
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            if (buttonCall.Text.Equals("Llamar"))
            {
                buttonCall.Text = "Colgar";

                string targetIp = "0.0.0.0";

                if (globals.udpClients.ContainsKey(labelClientReceiver.Text))
                {
                    targetIp = globals.udpClients[labelClientReceiver.Text];

                    try
                    {
                        m_pWaveOut = new WaveOut(WaveOut.Devices[0], 8000, 16, 1);
                        wc.audioUdpServer.PacketReceived += new PacketReceivedHandler(m_pUdpServer_PacketReceived);
                        wc.audioUdpServer.Start();

                        audioTargetEP = new IPEndPoint(IPAddress.Parse(targetIp), 11000);
                        m_pWaveIn = new WaveIn(WaveIn.Devices[0], 8000, 16, 1, 400);
                        m_pWaveIn.BufferFull += new BufferFullHandler(m_pWaveIn_BufferFull);
                        m_pWaveIn.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Usuario no disponible.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        buttonCall.Text = "Llamar";
                    }
                }

                else
                {
                    MessageBox.Show("Usuario no disponible.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    buttonCall.Text = "Llamar";
                }
            }

            else
            {
                buttonCall.Text = "Llamar";
                wc.audioUdpServer.Dispose();

                m_pWaveOut.Dispose();
                m_pWaveOut = null;

                m_pWaveIn.Dispose();
                m_pWaveIn = null;

            }
        }


        private void m_pUdpServer_PacketReceived(UdpPacket_eArgs e)
        {
            // Decompress data.
            byte[] decodedData = null;
            
            // Elegir el codec
            decodedData = G711.Decode_aLaw(e.Data, 0, e.Data.Length);

            // We just play received packet.
            m_pWaveOut.Play(decodedData, 0, decodedData.Length);
        }

        private void m_pWaveIn_BufferFull(byte[] buffer)
        {
            // Compress data. 
            byte[] encodedData = null;
            
            encodedData = G711.Encode_aLaw(buffer, 0, buffer.Length);

            // We just sent buffer to target end point.
            wc.audioUdpServer.SendPacket(encodedData, 0, encodedData.Length, audioTargetEP);
        }

        private void buttonCamera_Click(object sender, EventArgs e)
        {
        Thread videoReceiverThread = new Thread(videoPacketReceived);
        if (buttonCamera.Text.Equals("Video"))
            {
                buttonCamera.Text = "Finalizar";

                string targetIp = "0.0.0.0";

                if (globals.udpClients.ContainsKey(labelClientReceiver.Text))
                {
                    targetIp = globals.udpClients[labelClientReceiver.Text];

                    try
                    {
                        videoTargetEP = new IPEndPoint(IPAddress.Parse(targetIp), 44444);
                        videoCaptureDevice.NewFrame += new AForge.Video.NewFrameEventHandler(videoCaptureDevice_NewFrame);
                        videoCaptureDevice.Start();

                        timer1.Enabled = true;
                        
                        videoReceiverThread.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Usuario no disponible.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        buttonCamera.Text = "Video";
                    }
                }

                else
                {
                    MessageBox.Show("Usuario no disponible.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonCamera.Text = "Video";
                }
            }

            else
            {
                buttonCamera.Text = "Video";
                videoReceiverThread.Abort();
                videoCaptureDevice.Stop();
                timer1.Enabled = false;
            }
        }

        private void videoPacketReceived()
        {
            while (true)
            {
                byte[] received_data;
                received_data = wc.videoUdpServer.Receive(ref videoTargetEP);

                MemoryStream ms = new MemoryStream(received_data);
                Image returnImage = Image.FromStream(ms);

                pictureBoxContact.Image = returnImage;
            }
        }

        private void videoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Size resizer = new Size(480, 240);
            Bitmap tempImage = (Bitmap)eventArgs.Frame.Clone();
            imageToSend = ResizeImage(tempImage, resizer);       
        }

        private Bitmap ResizeImage(Bitmap imageToResize, Size size)
        {
 	        Bitmap b = new Bitmap(size.Width, size.Height);
                using (Graphics g = Graphics.FromImage((Image)b))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(imageToResize, 0, 0, size.Width, size.Height);
                }
                return b;
        }

        public Byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageToSend != null)
            {
                Byte[] sendBytes = imageToByteArray(imageToSend);

                UdpClient tempUdpClient = new UdpClient();

                tempUdpClient.Send(sendBytes, sendBytes.Length, videoTargetEP);
            }     
        }
    }
}
