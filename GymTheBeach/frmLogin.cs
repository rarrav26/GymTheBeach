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

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var success = false;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                var hint = new ToolTip
                {
                    IsBalloon = true,
                    ToolTipTitle = "El usuario no puede estar vacío",
                    ToolTipIcon = ToolTipIcon.Error
                };
                hint.Show("Por favor ingresa un usuario", txtUsuario, 150, -75, 2000);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                var hint = new ToolTip
                {
                    IsBalloon = true,
                    ToolTipTitle = "La contraseña no puede estar vacía",
                    ToolTipIcon = ToolTipIcon.Error
                };
                hint.Show("Por favor ingresa una contraseña", txtPassword, 150, -75, 2000);
                txtPassword.Focus();
                return;
            }

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
                var hint = new ToolTip
                {
                    IsBalloon = true,
                    ToolTipTitle = "Usuario o contraseña incorrectos",
                    ToolTipIcon = ToolTipIcon.Error
                };
                hint.Show("Por favor vuelve a intentarlo", txtPassword, 150, -75, 5000);
                txtPassword.Text = string.Empty;
                txtPassword.Focus();
            }
        }
    }
}