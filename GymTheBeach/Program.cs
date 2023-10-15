using libzkfpcsharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTheBeach
{
    public static class Program
    {
        public static bool AccessGranted { get; set; }
        public static ScanControls ScanControl { get; set; }

        public enum ScanControls
        {
            AccessRequested,
            ScanUsers,
            RegisterFingerprint
        }

        public enum Permisos
        {
            Encargado = 1,
            Admin
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // validaciones DB

            // si no puede contactar con la db, que lo notifique y no inicie la app

            // si conecta y no hay usuarios, crear usuario admin admin

            var init = zkfp2.Init();
            if (init == zkfperrdef.ZKFP_ERR_OK)
            {
                int deviceCount = zkfp2.GetDeviceCount();
                if (deviceCount == 0)
                {
                    zkfp2.Terminate();
                    MessageBox.Show("Conecte al menos un lector de huellas digitales de la marca ZKTeco para un correcto funcionamiento de la aplicación.", "Lector de huellas desconectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"El lector de huellas digitales falló al inicialzarse. Código de error: {init}\n(Anotar el código)", "Inicialización del lector de huellas fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*
            int ret = zkfp.ZKFP_ERR_OK;
            if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(cmbIdx.SelectedIndex)))
            {
                MessageBox.Show("OpenDevice fail");
                return;
            }
            if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
            {
                MessageBox.Show("Init DB fail");
                zkfp2.CloseDevice(mDevHandle);
                mDevHandle = IntPtr.Zero;
                return;
            }
            */

            //var frmLogin = new frmLogin();
            //Application.Run(frmLogin);

            //if (AccessGranted)
            Application.Run(new frmMain());
        }
    }
}