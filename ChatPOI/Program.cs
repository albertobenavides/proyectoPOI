using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatPOI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WindowLogin f = new WindowLogin();
            if (f.ShowDialog() == DialogResult.OK)
                Application.Run(new WindowContacts());
            else
                Application.Exit();
        }
    }
}
