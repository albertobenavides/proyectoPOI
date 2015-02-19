using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace ChatPOI
{
    public partial class WindowLogin : Form
    {
        char temp;

        

        public WindowLogin()
        {
            InitializeComponent();

                //using (StreamReader reader = new StreamReader("users.txt"))
                //{
                //    users.Add(reader.ReadLine());
                //}
        }


        private void linkLabelEnter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "Nombre de usuario")
            {
                textBoxUser.Text = "";
                textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Regular);
                textBoxUser.ForeColor = Color.Black;
            }
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
            {
                textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                textBoxUser.ForeColor = Color.Gray;
                textBoxUser.Text = "Nombre de usuario";
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Contraseña")
            {
                textBoxPassword.Text = "";
                textBoxPassword.Font = new Font(textBoxUser.Font, FontStyle.Regular);
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                textBoxPassword.ForeColor = Color.Gray;
                textBoxPassword.Text = "Contraseña";
                textBoxPassword.PasswordChar = temp;
            }
        }

        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && (textBoxUser.Text != "" || textBoxUser.Text != "Nombre de usuario"))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((textBoxUser.Text != "" || textBoxUser.Text != "Nombre de usuario") &&
                (textBoxPassword.Text != "" || textBoxPassword.Text != "Contraseña"))
            {
                using (StreamWriter writer = new StreamWriter("users.txt", true))
                {
                    writer.WriteLine(textBoxUser.Text + "," + textBoxPassword.Text);
                }

                
            }

        }
    }
}
