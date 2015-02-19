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
        public List<string> users;
        public List<byte> passwords;
        char temp;

        

        public WindowLogin()
        {
            InitializeComponent();
            temp = textBoxPassword.PasswordChar;
            users = new List<string>();
            passwords = new List<byte>();
            try
            {
                using (StreamReader reader = new StreamReader("users.txt"))
                {
                    users.Add(reader.ReadLine());
                    for (int i = 0; i < 16; i++)
                        passwords.Add(Convert.ToByte(reader.ReadLine()));
                }
            }
            catch { }
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
                using (AesManaged myAes = new AesManaged())
                {
                    byte[] comparison = new byte[16];
                    for (int i = 0; i < 16; i++)
                    {
                        comparison[i] = passwords[i];
                    }
                    string roundtrip = DecryptStringFromBytes_Aes(comparison, myAes.Key, myAes.IV);
                    if (roundtrip == textBoxPassword.Text)
                        this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((textBoxUser.Text != "" || textBoxUser.Text != "Nombre de usuario") &&
                (textBoxPassword.Text != "" || textBoxPassword.Text != "Contraseña"))
            {
                using (StreamWriter writer = new StreamWriter("users.txt", true))
                    writer.WriteLine(textBoxUser.Text + "," + textBoxPassword.Text);

                
            }

        }
    }
}
