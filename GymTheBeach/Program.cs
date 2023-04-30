using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTheBeach
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var frmLogin = new frmLogin();
            //Application.Run(frmLogin);

            //if (frmLogin.IsLoggedIn)
                Application.Run(new frmMain());
        }
    }
}
