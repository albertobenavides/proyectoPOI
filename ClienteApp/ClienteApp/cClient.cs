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
    public partial class cClient : Form
    {
        public cClient()
        {
            InitializeComponent();
            this.Text = Global.nombreUsuario;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (Global.cliente.Connected)
            {
                try
                {
                    NetworkStream serverStream = Global.cliente.GetStream();
                    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBoxToSend.Text + "$");
                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();

                    byte[] inStream = new byte[10025];
                    serverStream.Read(inStream, 0, (int)Global.cliente.ReceiveBufferSize);
                    string returndata = System.Text.Encoding.ASCII.GetString(inStream);

                    textBoxChat.Text = textBoxChat.Text + Environment.NewLine + "Me:" + returndata;
                    textBoxToSend.Clear();
                    textBoxToSend.Focus();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message.ToString());
                }
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
                if (Global.cliente.Connected)
                {
                    try
                    {
                        NetworkStream serverStream = Global.cliente.GetStream();
                        byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBoxToSend.Text + "$");
                        serverStream.Write(outStream, 0, outStream.Length);
                        serverStream.Flush();

                        byte[] inStream = new byte[10025];
                        serverStream.Read(inStream, 0, (int)Global.cliente.ReceiveBufferSize);
                        string returndata = System.Text.Encoding.ASCII.GetString(inStream);

                        textBoxChat.Text = textBoxChat.Text + Environment.NewLine + "Me:" + returndata;
                        textBoxToSend.Clear();
                        textBoxToSend.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }
    }
}
