using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            try
            {
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                WindowLogin f = new WindowLogin();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new WindowVoice());
                }
                else
                    Application.Exit();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    

        #region static method CurrentDomain_UnhandledException

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(null, "Unhandled error: " + ((Exception)e.ExceptionObject).ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region static method Application_ThreadException

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(null, "Unhandled error: " + e.Exception.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}