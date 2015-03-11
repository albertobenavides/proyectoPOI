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
    public partial class WindowContacts : Form
    {
        public WindowContacts()
        {
            InitializeComponent();
            ClientConection.ConnectToServer(globals.username);
            textBoxUserName.Text = globals.username;
            comboBoxUserStatus.SelectedIndex = 0;
            globals.sendedText = "$$$$";
            globals.receivedText = "$$$$";
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientConection.Exit();
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
                dataGridViewContacts.ClearSelection(); //this will clear any currently selected cells
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
            ClientConection.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClientConection.SendString(globals.sendedText);
            
            if (globals.sendedText.Substring(0, 4) != "$sm$"
                && globals.sendedText.Substring(0, 4) != "$cs$")
                ClientConection.ReceiveResponse();

            globals.sendedText = "$$$$";

            globals.receivedText = globals.receivedText.Replace("$$$$$", "$");

            if (globals.receivedText != "$$$$")
                            labelServerMessage.Text = globals.receivedText;
            if (globals.receivedText == "")
                return;
            else
            {
                if (globals.receivedText.Substring(0, 4) == "$cl$")
                {
                    dataGridViewContacts.Rows.Clear();
                    string[] clientsConnected = globals.receivedText.Substring(4).Split(',');

                    foreach (string s in clientsConnected)
                    {
                        if (s != globals.username && !s.Contains("$$$$") && s != "")
                        {
                            dataGridViewContacts.Rows.Add(new object[] { "Disponible", s, "Mensaje" });
                        }
                    }
                }

                else if (globals.receivedText.Substring(0, 4) == "$mr$")
                {
                    string userFrom = globals.receivedText.Substring(4);
                    userFrom = userFrom.Substring(0, userFrom.IndexOf("$mr$"));
                    string message = globals.receivedText.Substring(4);
                    message = message.Substring(message.IndexOf("$mr$") + 4);

                    foreach(DataGridViewRow dg in dataGridViewContacts.Rows)
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

                else if (globals.receivedText.Substring(0, 4) == "$cs$")
                {
                    string userFrom = globals.receivedText.Substring(4);
                    userFrom = userFrom.Substring(0, userFrom.IndexOf("$cs$"));
                    string status = globals.receivedText.Substring(4);
                    status = status.Substring(status.IndexOf("$cs$") + 4);

                    foreach (DataGridViewRow dg in dataGridViewContacts.Rows)
                    {
                        if (dg.Cells[1].Value.ToString() == userFrom)
                            dg.Cells[0].Value = status;
                    }
                }
                else
                    return;
            }
            globals.receivedText = "$$$$";
        }

        private void comboBoxUserStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            globals.sendedText = "$cs$" + globals.username + "$cs$" + comboBoxUserStatus.Text;
        }
    }
}
