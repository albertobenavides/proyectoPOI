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
using System.IO;
using System.Net.Mail;

namespace ChatPOI
{
    public partial class WindowLogin : Form
    {
        char temp;

        MailAddress vmail;

        Dictionary<string, string> users = new Dictionary<string, string>();

        public WindowLogin()
        {
            InitializeComponent();

            users.Add("", "");

            using (StreamWriter writer = new StreamWriter("users.txt", true))
            {
                writer.Write("");
            }

            using (StreamReader reader = new StreamReader("users.txt"))
            {
                string temp;
                while ((temp = reader.ReadLine()) != null)
                {
                    string[] s = temp.Split(',');
                    users.Add(s[0], s[1]);
                }
            }
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "Correo electrónico")
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
                textBoxUser.Text = "Correo electrónico";
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
            if (e.KeyChar == (char)Keys.Return && (textBoxUser.Text != "" || textBoxUser.Text != "Correo electrónico"))
            {
                try
                {
                    vmail = new MailAddress(textBoxUser.Text);

                    if ((textBoxUser.Text != "" || textBoxUser.Text != "Correo electrónico"))
                    {
                        if (users.ContainsKey(textBoxUser.Text))
                        {
                            string s;
                            if (users.TryGetValue(textBoxUser.Text, out s) && s == textBoxPassword.Text)
                            {
                                globals.username = textBoxUser.Text;
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                        else
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Formato de correo no válido.");
                }
            }
        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (!(textBoxUser.Text == "" || textBoxUser.Text == "Correo electrónico"
                || textBoxPassword.Text == "" || textBoxPassword.Text == "Contraseña"))
            {
                if (!users.Keys.Contains(textBoxUser.Text))
                {
                    try
                    {
                        vmail = new MailAddress(textBoxUser.Text);
                        using (StreamWriter writer = new StreamWriter("users.txt", true))
                        {
                            writer.WriteLine(textBoxUser.Text + "," + textBoxPassword.Text);
                        }
                        users.Add(textBoxUser.Text, textBoxPassword.Text);
                        MessageBox.Show("Usuario " + textBoxUser.Text + " creado con éxito.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Formato de correo no válido.");
                    }
                }
                else
                    MessageBox.Show("El usuario proporcionado ya tiene una cuenta.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Favor de proporcionar un correo y una contraseña válidos para registrarse.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vmail = new MailAddress(textBoxUser.Text);

                if ((textBoxUser.Text != "" || textBoxUser.Text != "Correo electrónico"))
                {
                    if (users.ContainsKey(textBoxUser.Text))
                    {
                        string s;
                        if (users.TryGetValue(textBoxUser.Text, out s) && s == textBoxPassword.Text)
                        {
                            globals.username = textBoxUser.Text;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Formato de correo no válido.");
            }
        }
    }
}
