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
    public partial class frmLogin : Form
    {
        public bool IsLoggedIn { get; set; }
        public bool LeerHuellas { get; set; }

        public frmLogin()
        {
            InitializeComponent();
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
                if (hash == user.Hash)
                    success = true;
            }

            if (success)
            {
                this.Close();
                IsLoggedIn = true;
            }
            else
            {
                txtPassword.Text = string.Empty;
                Common.ShowHint(txtPassword, "Usuario o contraseña incorrectos", "Por favor vuelve a intentarlo", ToolTipIcon.Error, 5000);
            }
        }
    }
}