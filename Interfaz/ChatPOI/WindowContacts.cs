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
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientConection.Exit();
            Application.Restart();
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            if ((textBoxAddContact.Text != "" || textBoxAddContact.Text != "Nombre de usuario"))
            {
                dataGridViewContacts.Rows.Add(new object[] { "Disponible", textBoxAddContact.Text, "Esperando confirmación" });
                textBoxAddContact.Font = new Font(textBoxAddContact.Font, FontStyle.Italic);
                textBoxAddContact.ForeColor = Color.Gray;
                textBoxAddContact.Text = "Nombre de usuario";
                dataGridViewContacts.Focus();
            }
        }

        private void textBoxAddContact_Enter(object sender, EventArgs e)
        {
            if (textBoxAddContact.Text == "Nombre de usuario")
            {
                textBoxAddContact.Text = "";
                textBoxAddContact.Font = new Font(textBoxAddContact.Font, FontStyle.Regular);
                textBoxAddContact.ForeColor = Color.Black;
            }
        }

        private void textBoxAddContact_Leave(object sender, EventArgs e)
        {
            if (textBoxAddContact.Text == "")
            {
                textBoxAddContact.Font = new Font(textBoxAddContact.Font, FontStyle.Italic);
                textBoxAddContact.ForeColor = Color.Gray;
                textBoxAddContact.Text = "Nombre de usuario";
            }
        }

        private void textBoxAddContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && (textBoxAddContact.Text != "" || textBoxAddContact.Text != "Nombre de usuario"))
            {
                dataGridViewContacts.Rows.Add(new object[] { "Disponible", textBoxAddContact.Text, "Esperando confirmación" });
                textBoxAddContact.Font = new Font(textBoxAddContact.Font, FontStyle.Italic);
                textBoxAddContact.ForeColor = Color.Gray;
                textBoxAddContact.Text = "Nombre de usuario";
                dataGridViewContacts.Focus();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridViewContacts.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridViewContacts.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.Font = new Font(textBoxAddContact.Font, FontStyle.Regular);
            textBoxSearch.ForeColor = Color.Black;
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Font = new Font(textBoxAddContact.Font, FontStyle.Italic);
                textBoxSearch.ForeColor = Color.Gray;
                textBoxSearch.Text = "Buscar contacto...";
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
            FormChat f = new FormChat(dataGridViewContacts.Rows[e.RowIndex].Cells[1].Value.ToString());
            f.Show();
        }

        private void WindowContacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClientConection.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClientConection.SendString(globals.sendedText);
            globals.sendedText = null;
            globals.sendedText = "$$$$";
            ClientConection.ReceiveResponse();
            if (globals.receivedText.Contains(">>>>"))
            {
                return;
            }
            else if (globals.receivedText.Substring(0, 4) == "$cl$")
            {
                dataGridViewContacts.Rows.Clear();
                string[] clientsConnected = globals.receivedText.Substring(4, globals.receivedText.Length - 5).Split(',');

                foreach (string s in clientsConnected)
                {
                    if (s != globals.username)
                    {
                        dataGridViewContacts.Rows.Add(new object[] { "Disponible", s, "Mensaje" });
                        dataGridViewContacts.Focus();
                    }
                }
            }
            else if (globals.receivedText.Substring(0, 4) == "$mr$")
            {
                string userFrom = globals.receivedText.Substring(4);
                userFrom = userFrom.Substring(0, userFrom.IndexOf("$mr$"));
                string message = globals.receivedText.Substring(4);
                message = message.Substring(message.IndexOf("$mr$") + 4);
                this.Text = message;
            }
            else
                return;
        }
    }
}
