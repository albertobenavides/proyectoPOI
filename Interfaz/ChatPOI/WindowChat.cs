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

namespace ChatPOI
{
    public partial class FormChat: Form
    {
        Dictionary<string, Bitmap>  emotions;

        public FormChat(string s)
        {
            InitializeComponent();
            labelContactName.Text = s;
            labelUserName.Text = globals.username;
            this.Text = s;
            globals.receivedText = "$$$$";
            globals.sendedText = "$$$$";
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
            s += this.Text + ",";
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
            globals.sendedText = s;
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
            zumbido(this);

            string s;
            s = "$sm$";
            s += this.Text + ",";
            s += "$sm$";
            s += "Te ha enviado un zumbido.";

            globals.sendedText = s;
            s = s.Substring(4);
            s = s.Substring(s.IndexOf("$sm$") + 4);
            richTextBoxChat.AppendText("\nTú has enviado un zumbido.");

            richTextBoxChat.ScrollToCaret();
            richTextBoxMessage.Focus();
        }

        public void zumbido(Form form)
        {
            var inicial = form.Location;
            var rnd = new Random(1500);
            const int t = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(inicial.X + rnd.Next(-t, t), inicial.Y + rnd.Next(-t, t));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = inicial;
        }
    }
}
