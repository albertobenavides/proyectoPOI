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
using System.Threading;

namespace ClienteApp
{
    public partial class cClient : Form
    {
        NetworkStream serverStream = Global.cliente.GetStream();
        string readData = null;

        public cClient()
        {
            InitializeComponent();
            this.Text = Global.nombreUsuario;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {            
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBoxToSend.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                
                Thread ctThread = new Thread(getMessage);
                ctThread.Start();

                //textBoxChat.Text = textBoxChat.Text + Environment.NewLine + returndata;
                textBoxToSend.Clear();
                textBoxToSend.Focus();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Global.cliente.Close();
        }

        private void textBoxToSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {    
            }
        }
        private void getMessage()
        {
            while (true)
            {
                serverStream = Global.cliente.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[10025];
                buffSize = Global.cliente.ReceiveBufferSize;
                serverStream.Read(inStream, 0, buffSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                readData = "" + returndata;
                msg();
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                textBoxChat.Text = textBoxChat.Text + Environment.NewLine + " >> " + readData;
        } 
    }
}
