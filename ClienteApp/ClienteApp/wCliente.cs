using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ClienteApp
{   
    public partial class wCliente : Form
    {
        public cClient wChat;
        //public static TcpClient cliente;
        public static StreamReader str;
        public static StreamWriter stw;
        public static int puerto;
        public static string ipstring;

        public wCliente()
        {
            InitializeComponent();
            textBoxMessage.Text = "...";
            puerto = 1208;
            
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipstring = address.ToString();
                }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Global.cliente = new TcpClient();
            IPEndPoint ip_end = new IPEndPoint(IPAddress.Parse("192.168.0.16"), puerto);
            
            try
            {
                Global.cliente.Connect(ip_end);
                if (Global.cliente.Connected)
                {
                    textBoxMessage.Text= "Connected to Server \n";
                    
                    NetworkStream serverStream = Global.cliente.GetStream();
                    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBoxNickname.Text + "$");
                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();

                    Global.nombreUsuario = textBoxNickname.Text;

                    wChat = new cClient();
                    wChat.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }

    public static class Global
    {
        public static TcpClient cliente;
        public static string nombreUsuario;
    }
}
