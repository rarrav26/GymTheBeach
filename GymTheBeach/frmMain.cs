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

            CurrentPage = 0;

            // ejecutar un proceso que lea huellas
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
                btnListaUsuarios.Visible = false;
                btnRegistrarNuevoUsuario.Visible = false;

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
                dgvUsuarios.DataSource = Models.Data.SQL.Context.Usuarios
                    //.Select(u => new UsuarioDto(u))
                    .OrderBy(u => u.Apellido)
                    .ThenBy(u => u.Nombre)
                    .Skip(CurrentPage * 50)
                    .Take(50)
                    .ToList();

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
            if (Common.ShowHint(txtNombre, "El nombre no puede estar vacío", "Por favor ingresa un nombre", ToolTipIcon.Error))
                return;

            if (Common.ShowHint(txtApellido, "El apellido no puede estar vacío", "Por favor ingresa un apellido", ToolTipIcon.Error))
                return;

            if (Common.ShowHint(txtDNI, "El DNI/ID no puede estar vacío", "Por favor ingresa un identificador", ToolTipIcon.Error))
                return;
        }

        private bool RegistrarNuevaHuella(Button btn)
        {
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
            RegistrarNuevaHuella((Button)sender);
        }

        private void btnHuella2_Click(object sender, EventArgs e)
        {
            RegistrarNuevaHuella((Button)sender);
        }

        private void btnHuella3_Click(object sender, EventArgs e)
        {
            RegistrarNuevaHuella((Button)sender);
        }

        private void btnHuella4_Click(object sender, EventArgs e)
        {
            RegistrarNuevaHuella((Button)sender);
        }

        private void btnHuella5_Click(object sender, EventArgs e)
        {
            RegistrarNuevaHuella((Button)sender);
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
        }
    }
}