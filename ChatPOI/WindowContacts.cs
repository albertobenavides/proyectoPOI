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
            dataGridViewContacts.Rows.Add(new object[] { "Disponible", "Contacto", "Escribiendo..." });
            comboBoxUserStatus.SelectedIndex = 0;
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            dataGridViewContacts.Rows.Add(new object[] { "Disponible", textBoxAddContact.Text, "Esperando confirmación" });
            textBoxAddContact.Font = new Font(textBoxAddContact.Font, FontStyle.Italic);
            textBoxAddContact.ForeColor = Color.Gray;
            textBoxAddContact.Text = "Nombre de usuario";
            dataGridViewContacts.Focus();
        }

        private void textBoxAddContact_Enter(object sender, EventArgs e)
        {
            textBoxAddContact.Text = "";
            textBoxAddContact.Font = new Font(textBoxAddContact.Font, FontStyle.Regular);
            textBoxAddContact.ForeColor = Color.Black;
        }

        private void textBoxAddContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dataGridViewContacts.Rows.Add(new object[] { "Disponible", textBoxAddContact.Text, "Esperando confirmación" });
                textBoxAddContact.Font = new Font(textBoxAddContact.Font, FontStyle.Italic);
                textBoxAddContact.ForeColor = Color.Gray;
                textBoxAddContact.Text = "Nombre de usuario";
                dataGridViewContacts.Focus();
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridViewContacts.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridViewContacts.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
    }
}
