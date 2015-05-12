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
    public partial class SelectPlayers : Form
    {
        List<string> participants;

        public SelectPlayers()
        {

            participants = new List<string>();
            participants.Add(globals.username);

            InitializeComponent();

            contactList.Items.Clear();

            List<string> users = new List<string>();

            foreach (WindowContacts temp in Application.OpenForms.OfType<WindowContacts>())
            {
                users = temp.getContactList();
            }

            foreach (string user in users)
            {
                contactList.Items.Add(user);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            foreach (object user in contactList.CheckedItems)
            {
                participants.Add(user.ToString());
            }

            if (participants.Count == 0)
            {
                MessageBox.Show("Elige al menos otro participante.");
            }
            else if (participants.Count > 2)
            {
                MessageBox.Show("No puedes elegir a más de dos contrincantes.");
            }
            else
            {
                Timbiriche.Timbiriche f = new Timbiriche.Timbiriche(1);
                f.Show();

                this.Close();
            }
        }
    }
}
