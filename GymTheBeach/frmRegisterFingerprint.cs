using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libzkfpcsharp;

namespace GymTheBeach
{
    public partial class frmRegisterFingerprint : Form
    {
        private string idHuella;

        public frmRegisterFingerprint(string idHuella)
        {
            InitializeComponent();
            this.idHuella = idHuella;
            this.Text += $" {idHuella}";

            // consultar db si existe la huella
            Program.ScanControl = Program.ScanControls.RegisterFingerprint;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // validaciones 3 huellas

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}