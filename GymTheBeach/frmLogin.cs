using System;
using System.Linq;
using System.Windows.Forms;

namespace GymTheBeach
{
    public partial class frmLogin : Form
    {
        private Program.Permisos permisoSolicitado;

        public frmLogin(Program.Permisos permisoSolicitado = Program.Permisos.Encargado)
        {
            InitializeComponent();

            // Se establece el control del scanner para el frmLogin
            Program.ScanControl = Program.ScanControls.AccessRequested;

            this.permisoSolicitado = permisoSolicitado;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var success = false;

            if (Common.ShowHint(txtUsuario, "El usuario no puede estar vacío", "Por favor ingresa un usuario", ToolTipIcon.Error))
                return;

            if (Common.ShowHint(txtPassword, "La contraseña no puede estar vacía", "Por favor ingresa una contraseña", ToolTipIcon.Error))
                return;

            var user = Models.Data.SQL.Context.Usuarios.FirstOrDefault(u => u.Username == txtUsuario.Text);

            if (user != null)
            {
                var splittedSalt = new string[] { user.Salt.Substring(0, user.Salt.Length / 2), user.Salt.Substring(user.Salt.Length / 2) };
                var hash = Models.Helpers.Hash.GetHashSHA256(splittedSalt[0] + txtPassword.Text + splittedSalt[1]);
                if (hash == user.Hash && (user.EsAdmin ?? false) /* >= permisoSolicitado */)
                    success = true;
            }
            // TODO: o huella digital

            Program.AccessGranted = success;

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                txtPassword.Text = string.Empty;
                Common.ShowHint(txtPassword, "Usuario o contraseña incorrectos", "Por favor vuelve a intentarlo", ToolTipIcon.Error, 5000);
            }
        }
    }
}