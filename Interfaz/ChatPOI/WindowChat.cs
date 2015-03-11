using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatPOI
{
    public partial class FormChat: Form
    {
        public FormChat(string s)
        {
            InitializeComponent();
            labelContactName.Text = s;
            labelUserName.Text = globals.username;
            this.Text = s;
            globals.receivedText = "$$$$";
            globals.sendedText = "$$$$";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string s;
            s = "$sm$";
            s += this.Text + ",";
            s += "$sm$";
            s += richTextBoxMessage.Text;
            globals.sendedText = s;
            richTextBoxChat.Text += "\nTú: " + richTextBoxMessage.Text;
            richTextBoxMessage.Text = "";
        }

        public void setMessage(string s)
        {
            richTextBoxChat.Text += s;
        }
    }
}
