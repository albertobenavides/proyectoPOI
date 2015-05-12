using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace ChatPOI
{
    public partial class MailForm : Form
    {
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

        public MailForm()
        {
            InitializeComponent();
            mail.From = new MailAddress("proyectopapw@gmail.com");
        }

        private void buttonAttachFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                mail.To.Clear();
                mail.Attachments.Clear();
                mail.To.Add(textBox1.Text);
                mail.Subject = "Correo archivo Cheet-A-Chat";
                mail.Body = "El usuario " + globals.username + " ha enviado un archivo adjunto desde Cheet-A-Chat";

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(openFileDialog1.FileName);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("proyectopapw", "m4rquitos");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
