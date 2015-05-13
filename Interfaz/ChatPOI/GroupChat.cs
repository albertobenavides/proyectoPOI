using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatPOI
{
    public partial class GroupChat : Form
    {
        Dictionary<string, Bitmap> emotions;

        List<string> participants;

        WindowContacts wc;

        public GroupChat(List<string> users)
        {
            InitializeComponent();

            foreach (WindowContacts f in Application.OpenForms.OfType<WindowContacts>())
            {
                wc = f;
            }

            labelContactName.Text = "";

            labelUserName.Text = globals.username;

            if (users == null)
            {
                participants = new List<string>();
                participants.Add(globals.username);
            }
            else
                participants = users;

            participants.Sort();

            this.Text = "Integrantes: ";

            bool isFrist = true;

            foreach (string user in participants)
            {
                if (isFrist)
                {
                    isFrist = false;
                    this.Text += user;
                }
                else
                    this.Text += ", " + user;

                if (!user.Equals(globals.username))
                    wc.SendString("$ip$" + user +"$ip$" + wc.myUdpIp + "$$$$");
            }

            globals.receivedText = null;
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

        public List<string> getParticipants()
        {
            participants.Sort();
            return participants;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (richTextBoxMessage.Text != "" && participants.Count > 1)
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
            s = "$sg$";

            foreach (string user in participants)
            {
                if (!user.Equals(globals.username))
                s += user + ",";
            }
            
            s += "$sg$";

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
            s = s.Substring(s.IndexOf("$sg$") + 4);
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
            buttonPlay.Visible = true;
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

        private void buttonEmoti10_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.AppendText(":(");
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

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            if (buttonAddContact.Text == "Añadir")
            {
                contactList.Items.Clear();
                contactList.Visible = true;

                buttonAddContact.Text = "Confirmar";

                List<string> users = new List<string>();

                foreach (WindowContacts temp in Application.OpenForms.OfType<WindowContacts>())
                {
                    users = temp.getContactList();
                }
                string header = this.Text;
                header = header.Substring(13);
                string[] usersChating = header.Split(',');

                for (int i = 0; i < usersChating.Length; i++)
                {
                    usersChating[i] = usersChating[i].Trim();
                }

                foreach (string user in users)
                {
                    contactList.Items.Add(user);

                    if (usersChating.Contains(user))
                    {
                        contactList.SetItemChecked(contactList.Items.IndexOf(user), true);
                    }
                }
            }
            else
            {
                this.Text = "Integrantes: ";

                bool isFirst = true;

                participants.Clear();

                participants.Add(globals.username);

                foreach (object user in contactList.CheckedItems)
                {
                    participants.Add(user.ToString());
                    wc.SendString("$ip$" + user.ToString() +"$ip$" + wc.myUdpIp + "$$$$");
                }

                participants.Sort();

                foreach (string user in participants)
                {
                    if (isFirst)
                    {
                        isFirst = false;
                        this.Text += user.ToString();
                    }
                    else
                        this.Text += ", " + user.ToString();
                }

                contactList.Visible = false;

                buttonAddContact.Text = "Añadir";

                buttonPlay.Visible = false;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            string header = this.Text;
            header = header.Substring(13);
            string[] usersChating = header.Split(',');

            List<string> temp = new List<string>();

            temp.Add(globals.username);

            for (int i = 0; i < usersChating.Length; i++)
            {
                usersChating[i] = usersChating[i].Trim();
                if (!usersChating[i].Equals(globals.username))
                    temp.Add(usersChating[i]);
            }

            if (temp.Count > 3)
            {
                MessageBox.Show("No puedes jugar con más de dos contrincantes.");
            }
            else
            {
                GameBoard t =
                    new GameBoard(participants, globals.username);
                t.Show();

                string s = "$pg$"; // play game

                foreach (string user in temp)
                {
                    if (!user.Equals(globals.username))
                        s += user + ",";
                }

                s += "$pg$ $$$$";

                wc.SendString(s);
            }
            participants.Sort();
        }
    }
}
