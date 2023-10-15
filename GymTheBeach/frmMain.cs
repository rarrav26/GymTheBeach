using Models.Data;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GymTheBeach
{
    public partial class frmMain : Form
    {
        public enum Section
        {
            Usuarios,
            Asistencia,
            Pagos,
            Actividades
        }

        public Section CurrentSection { get; set; }
        public int CurrentPage { get; set; }

        public frmMain()
        {
            InitializeComponent();
            timer.Start();
            showSection(Section.Usuarios, gbListaUsuarios);

            // inicialización cmbGenero
            cmbGenero.DisplayMember = "Text";
            cmbGenero.ValueMember = "Value";
            cmbGenero.Items.Add(new { Text = "Masculino", Value = "1" });
            cmbGenero.Items.Add(new { Text = "Femenino", Value = "2" });
            cmbGenero.Items.Add(new { Text = "Sin especificar", Value = "3" });

            // inicialización cmbGenero
            cmbPermiso.DisplayMember = "Text";
            cmbPermiso.ValueMember = "Value";
            cmbPermiso.Items.Add(new { Text = "Encargado", Value = "1" });
            cmbPermiso.Items.Add(new { Text = "Admin", Value = "2" });

            CurrentPage = 0;

            Program.ScanControl = Program.ScanControls.ScanUsers;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaYHora.Text = DateTime.Now.ToString("HH:mm:ss" + Environment.NewLine + "dd/MM/yyyy");
        }

        private void showSection(Section section, GroupBox groupBox)
        {
            // si cambia la sección seleccionada
            if (section != CurrentSection)
            {
                CurrentPage = 0;

                // se ocultan todos los botones del header
                foreach (var control in pnlHeader.Controls)
                {
                    if (control != lblSeparadorHeader)
                        ((Control)control).Visible = false;
                }

                CurrentSection = section;

                // se muestran los botones del header correspondiente
                switch (section)
                {
                    case Section.Usuarios:
                        btnListaUsuarios.Visible = true;
                        btnRegistrarNuevoUsuario.Visible = true;
                        break;

                    case Section.Asistencia:
                        break;

                    case Section.Pagos:
                        break;

                    case Section.Actividades:
                        break;
                }
            }

            if (groupBox != null)
            {
                // se limpian los valores del formulario
                foreach (var control in groupBox.Controls)
                {
                    var type = control.GetType();
                    if (type == typeof(TextBox))
                        ((TextBox)control).Text = "";
                    else if (type == typeof(DateTimePicker))
                        ((DateTimePicker)control).Value = DateTime.Now;
                    else if (type == typeof(ComboBox))
                        ((ComboBox)control).SelectedItem = null;
                }

                // si la sección seleccionada ya era visible nos ahorramos ocultar todos los grupos y volver a renderizar el que ya era visible
                if (groupBox.Visible)
                    return;
            }

            // se ocultan los grupos de controles del main
            gbListaUsuarios.Visible = false;
            gbRegistrarUsuario.Visible = false;

            if (groupBox == gbListaUsuarios)
            {
                dgvUsuarios.DataSource = SQL.Context.Usuarios
                    //.Select(u => u.ToDataTransferObject())
                    .OrderBy(u => u.Apellido)
                    .ThenBy(u => u.Nombre)
                    .Skip(CurrentPage * 50)
                    .Take(50)
                    .ToList();
            }
            else if (groupBox == gbRegistrarUsuario)
            {
                lblPermiso.Visible = chkPermisos.Checked;
                cmbPermiso.Visible = chkPermisos.Checked;
            }

            if (groupBox != null)
                groupBox.Visible = true;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            showSection(Section.Usuarios, gbListaUsuarios);
        }

        private void btnListaUsuarios_Click(object sender, EventArgs e)
        {
            showSection(Section.Usuarios, gbListaUsuarios);
        }

        private void btnRegistrarNuevoUsuario_Click(object sender, EventArgs e)
        {
            showSection(Section.Usuarios, gbRegistrarUsuario);
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            showSection(Section.Asistencia, null);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            showSection(Section.Pagos, null);
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            showSection(Section.Actividades, null);
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            // validaciones
            if (Common.ShowHint(txtNombre, "El nombre no puede estar vacío", "Por favor ingresa un nombre", ToolTipIcon.Error))
                return;

            if (Common.ShowHint(txtApellido, "El apellido no puede estar vacío", "Por favor ingresa un apellido", ToolTipIcon.Error))
                return;

            if (Common.ShowHint(txtDNI, "El DNI/ID no puede estar vacío", "Por favor ingresa un identificador", ToolTipIcon.Error))
                return;

            Program.Permisos permisoRequerido;

            // solo un admin puede crear un usuario con permisos especiales
            if (chkPermisos.Checked)
                permisoRequerido = Program.Permisos.Admin;
            else
                permisoRequerido = Program.Permisos.Encargado;

            var dialogResult = new frmLogin(permisoRequerido).ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                // registramos el usuario (hay que validar que un encargado no pueda reducir los permisos de un admin)
            }
            else if (dialogResult != DialogResult.Cancel) // si canceló no mostramos nada
            {
                // notificamos que no tiene permiso u ocurrió un error
            }
        }

        private bool RegistrarNuevaHuella(object sender)
        {
            var btn = (Button)sender;
            var frmRegisterFingerprint = new frmRegisterFingerprint(btn.Text);

            if (frmRegisterFingerprint.ShowDialog(this) == DialogResult.OK)
            {
                btn.BackColor = Color.Green;
                return true;
            }

            return false;
        }

        private void btnHuella1_Click(object sender, EventArgs e)
        {
            RegistrarNuevaHuella(sender);
        }

        private void btnHuella2_Click(object sender, EventArgs e)
        {
            RegistrarNuevaHuella(sender);
        }

        private void btnHuella3_Click(object sender, EventArgs e)
        {
            RegistrarNuevaHuella(sender);
        }

        private void btnHuella4_Click(object sender, EventArgs e)
        {
            RegistrarNuevaHuella(sender);
        }

        private void btnHuella5_Click(object sender, EventArgs e)
        {
            RegistrarNuevaHuella(sender);
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
        }

        private void btnPagosUsuario_Click(object sender, EventArgs e)
        {
        }

        private void btnAsistUsuario_Click(object sender, EventArgs e)
        {
        }

        private void btnActivUsuario_Click(object sender, EventArgs e)
        {
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
        }

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            // TODO: obtener el userID de la fila seleccionada y pasarlo como
            // parámetro opcional para que ya cargue la vista "registro" del usuario con sus datos
            showSection(Section.Usuarios, gbRegistrarUsuario);
        }

        private void chkPermisos_CheckedChanged(object sender, EventArgs e)
        {
            lblPermiso.Visible = chkPermisos.Checked;
            cmbPermiso.Visible = chkPermisos.Checked;
        }
    }
}