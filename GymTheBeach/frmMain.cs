using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTheBeach
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaYHora.Text = DateTime.Now.ToString("HH:mm:ss" + Environment.NewLine + "dd/MM/yyyy");
        }
    }
}
