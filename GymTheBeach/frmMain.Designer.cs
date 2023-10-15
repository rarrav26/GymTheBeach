namespace GymTheBeach
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbListaUsuarios = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbRegistrarUsuario = new System.Windows.Forms.GroupBox();
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnActivUsuario = new System.Windows.Forms.Button();
            this.btnAsistUsuario = new System.Windows.Forms.Button();
            this.btnPagosUsuario = new System.Windows.Forms.Button();
            this.cmbPermiso = new System.Windows.Forms.ComboBox();
            this.lblPermiso = new System.Windows.Forms.Label();
            this.chkPermisos = new System.Windows.Forms.CheckBox();
            this.btnHuella5 = new System.Windows.Forms.Button();
            this.btnHuella4 = new System.Windows.Forms.Button();
            this.btnHuella3 = new System.Windows.Forms.Button();
            this.btnHuella2 = new System.Windows.Forms.Button();
            this.btnHuella1 = new System.Windows.Forms.Button();
            this.btnCamara = new System.Windows.Forms.Button();
            this.pbMano = new System.Windows.Forms.PictureBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtComoNosConocio = new System.Windows.Forms.TextBox();
            this.lblComoNosConocio = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.lblProfesion = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSeparadorMenu = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnRegistrarNuevoUsuario = new System.Windows.Forms.Button();
            this.btnListaUsuarios = new System.Windows.Forms.Button();
            this.lblSeparadorHeader = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblSeparadorHora = new System.Windows.Forms.Label();
            this.lblFechaYHora = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblSeparadorTitle = new System.Windows.Forms.Label();
            this.btnActividades = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.gbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbRegistrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.gbListaUsuarios);
            this.pnlMain.Controls.Add(this.gbRegistrarUsuario);
            this.pnlMain.Controls.Add(this.lblSeparadorMenu);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1243, 748);
            this.pnlMain.TabIndex = 0;
            // 
            // gbListaUsuarios
            // 
            this.gbListaUsuarios.Controls.Add(this.dgvUsuarios);
            this.gbListaUsuarios.Location = new System.Drawing.Point(1261, 106);
            this.gbListaUsuarios.Name = "gbListaUsuarios";
            this.gbListaUsuarios.Size = new System.Drawing.Size(970, 633);
            this.gbListaUsuarios.TabIndex = 33;
            this.gbListaUsuarios.TabStop = false;
            this.gbListaUsuarios.Visible = false;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(6, 14);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(958, 611);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.DoubleClick += new System.EventHandler(this.dgvUsuarios_DoubleClick);
            // 
            // gbRegistrarUsuario
            // 
            this.gbRegistrarUsuario.Controls.Add(this.btnDarDeBaja);
            this.gbRegistrarUsuario.Controls.Add(this.btnModificar);
            this.gbRegistrarUsuario.Controls.Add(this.btnActivUsuario);
            this.gbRegistrarUsuario.Controls.Add(this.btnAsistUsuario);
            this.gbRegistrarUsuario.Controls.Add(this.btnPagosUsuario);
            this.gbRegistrarUsuario.Controls.Add(this.cmbPermiso);
            this.gbRegistrarUsuario.Controls.Add(this.lblPermiso);
            this.gbRegistrarUsuario.Controls.Add(this.chkPermisos);
            this.gbRegistrarUsuario.Controls.Add(this.btnHuella5);
            this.gbRegistrarUsuario.Controls.Add(this.btnHuella4);
            this.gbRegistrarUsuario.Controls.Add(this.btnHuella3);
            this.gbRegistrarUsuario.Controls.Add(this.btnHuella2);
            this.gbRegistrarUsuario.Controls.Add(this.btnHuella1);
            this.gbRegistrarUsuario.Controls.Add(this.btnCamara);
            this.gbRegistrarUsuario.Controls.Add(this.pbMano);
            this.gbRegistrarUsuario.Controls.Add(this.pbFoto);
            this.gbRegistrarUsuario.Controls.Add(this.btnRegistrarUsuario);
            this.gbRegistrarUsuario.Controls.Add(this.txtObservaciones);
            this.gbRegistrarUsuario.Controls.Add(this.lblObservaciones);
            this.gbRegistrarUsuario.Controls.Add(this.txtComoNosConocio);
            this.gbRegistrarUsuario.Controls.Add(this.lblComoNosConocio);
            this.gbRegistrarUsuario.Controls.Add(this.txtEmail);
            this.gbRegistrarUsuario.Controls.Add(this.lblEmail);
            this.gbRegistrarUsuario.Controls.Add(this.txtProfesion);
            this.gbRegistrarUsuario.Controls.Add(this.lblProfesion);
            this.gbRegistrarUsuario.Controls.Add(this.txtDomicilio);
            this.gbRegistrarUsuario.Controls.Add(this.lblDomicilio);
            this.gbRegistrarUsuario.Controls.Add(this.txtTelefono);
            this.gbRegistrarUsuario.Controls.Add(this.lblTelefono);
            this.gbRegistrarUsuario.Controls.Add(this.dtpFechaNacimiento);
            this.gbRegistrarUsuario.Controls.Add(this.cmbGenero);
            this.gbRegistrarUsuario.Controls.Add(this.lblFechaNacimiento);
            this.gbRegistrarUsuario.Controls.Add(this.lblGenero);
            this.gbRegistrarUsuario.Controls.Add(this.txtDNI);
            this.gbRegistrarUsuario.Controls.Add(this.lblDNI);
            this.gbRegistrarUsuario.Controls.Add(this.txtApellido);
            this.gbRegistrarUsuario.Controls.Add(this.lblApellido);
            this.gbRegistrarUsuario.Controls.Add(this.txtNombre);
            this.gbRegistrarUsuario.Controls.Add(this.lblNombre);
            this.gbRegistrarUsuario.Location = new System.Drawing.Point(261, 106);
            this.gbRegistrarUsuario.Name = "gbRegistrarUsuario";
            this.gbRegistrarUsuario.Size = new System.Drawing.Size(970, 633);
            this.gbRegistrarUsuario.TabIndex = 32;
            this.gbRegistrarUsuario.TabStop = false;
            this.gbRegistrarUsuario.Visible = false;
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.BackColor = System.Drawing.Color.Gray;
            this.btnDarDeBaja.BackgroundImage = global::GymTheBeach.Properties.Resources.cancelar;
            this.btnDarDeBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDarDeBaja.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarDeBaja.ForeColor = System.Drawing.Color.White;
            this.btnDarDeBaja.Location = new System.Drawing.Point(70, 575);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(40, 40);
            this.btnDarDeBaja.TabIndex = 57;
            this.btnDarDeBaja.UseVisualStyleBackColor = false;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gray;
            this.btnModificar.BackgroundImage = global::GymTheBeach.Properties.Resources.editar2;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(24, 575);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(40, 40);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnActivUsuario
            // 
            this.btnActivUsuario.BackColor = System.Drawing.Color.Gray;
            this.btnActivUsuario.BackgroundImage = global::GymTheBeach.Properties.Resources.boxeo;
            this.btnActivUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActivUsuario.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivUsuario.ForeColor = System.Drawing.Color.White;
            this.btnActivUsuario.Location = new System.Drawing.Point(116, 523);
            this.btnActivUsuario.Name = "btnActivUsuario";
            this.btnActivUsuario.Size = new System.Drawing.Size(40, 40);
            this.btnActivUsuario.TabIndex = 34;
            this.btnActivUsuario.UseVisualStyleBackColor = false;
            this.btnActivUsuario.Click += new System.EventHandler(this.btnActivUsuario_Click);
            // 
            // btnAsistUsuario
            // 
            this.btnAsistUsuario.BackColor = System.Drawing.Color.Gray;
            this.btnAsistUsuario.BackgroundImage = global::GymTheBeach.Properties.Resources.asistencia;
            this.btnAsistUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAsistUsuario.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAsistUsuario.Location = new System.Drawing.Point(70, 523);
            this.btnAsistUsuario.Name = "btnAsistUsuario";
            this.btnAsistUsuario.Size = new System.Drawing.Size(40, 40);
            this.btnAsistUsuario.TabIndex = 33;
            this.btnAsistUsuario.UseVisualStyleBackColor = false;
            this.btnAsistUsuario.Click += new System.EventHandler(this.btnAsistUsuario_Click);
            // 
            // btnPagosUsuario
            // 
            this.btnPagosUsuario.BackColor = System.Drawing.Color.Gray;
            this.btnPagosUsuario.BackgroundImage = global::GymTheBeach.Properties.Resources.pagos;
            this.btnPagosUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPagosUsuario.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagosUsuario.ForeColor = System.Drawing.Color.White;
            this.btnPagosUsuario.Location = new System.Drawing.Point(24, 523);
            this.btnPagosUsuario.Name = "btnPagosUsuario";
            this.btnPagosUsuario.Size = new System.Drawing.Size(40, 40);
            this.btnPagosUsuario.TabIndex = 32;
            this.btnPagosUsuario.UseVisualStyleBackColor = false;
            this.btnPagosUsuario.Click += new System.EventHandler(this.btnPagosUsuario_Click);
            // 
            // cmbPermiso
            // 
            this.cmbPermiso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPermiso.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.cmbPermiso.ForeColor = System.Drawing.Color.Black;
            this.cmbPermiso.FormattingEnabled = true;
            this.cmbPermiso.Location = new System.Drawing.Point(617, 516);
            this.cmbPermiso.Name = "cmbPermiso";
            this.cmbPermiso.Size = new System.Drawing.Size(244, 25);
            this.cmbPermiso.TabIndex = 24;
            this.cmbPermiso.Visible = false;
            // 
            // lblPermiso
            // 
            this.lblPermiso.AutoSize = true;
            this.lblPermiso.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblPermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblPermiso.Location = new System.Drawing.Point(615, 494);
            this.lblPermiso.Name = "lblPermiso";
            this.lblPermiso.Size = new System.Drawing.Size(58, 19);
            this.lblPermiso.TabIndex = 23;
            this.lblPermiso.Text = "Permiso";
            this.lblPermiso.Visible = false;
            // 
            // chkPermisos
            // 
            this.chkPermisos.AutoSize = true;
            this.chkPermisos.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.chkPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.chkPermisos.Location = new System.Drawing.Point(294, 492);
            this.chkPermisos.Name = "chkPermisos";
            this.chkPermisos.Size = new System.Drawing.Size(147, 23);
            this.chkPermisos.TabIndex = 22;
            this.chkPermisos.Text = "Permisos especiales";
            this.chkPermisos.UseVisualStyleBackColor = true;
            this.chkPermisos.CheckedChanged += new System.EventHandler(this.chkPermisos_CheckedChanged);
            // 
            // btnHuella5
            // 
            this.btnHuella5.BackColor = System.Drawing.Color.DimGray;
            this.btnHuella5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuella5.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuella5.ForeColor = System.Drawing.Color.White;
            this.btnHuella5.Location = new System.Drawing.Point(35, 363);
            this.btnHuella5.Name = "btnHuella5";
            this.btnHuella5.Size = new System.Drawing.Size(20, 20);
            this.btnHuella5.TabIndex = 30;
            this.btnHuella5.Text = "5";
            this.btnHuella5.UseVisualStyleBackColor = false;
            this.btnHuella5.Click += new System.EventHandler(this.btnHuella5_Click);
            // 
            // btnHuella4
            // 
            this.btnHuella4.BackColor = System.Drawing.Color.DimGray;
            this.btnHuella4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuella4.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuella4.ForeColor = System.Drawing.Color.White;
            this.btnHuella4.Location = new System.Drawing.Point(69, 323);
            this.btnHuella4.Name = "btnHuella4";
            this.btnHuella4.Size = new System.Drawing.Size(20, 20);
            this.btnHuella4.TabIndex = 29;
            this.btnHuella4.Text = "4";
            this.btnHuella4.UseVisualStyleBackColor = false;
            this.btnHuella4.Click += new System.EventHandler(this.btnHuella4_Click);
            // 
            // btnHuella3
            // 
            this.btnHuella3.BackColor = System.Drawing.Color.DimGray;
            this.btnHuella3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuella3.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuella3.ForeColor = System.Drawing.Color.White;
            this.btnHuella3.Location = new System.Drawing.Point(118, 305);
            this.btnHuella3.Name = "btnHuella3";
            this.btnHuella3.Size = new System.Drawing.Size(20, 20);
            this.btnHuella3.TabIndex = 28;
            this.btnHuella3.Text = "3";
            this.btnHuella3.UseVisualStyleBackColor = false;
            this.btnHuella3.Click += new System.EventHandler(this.btnHuella3_Click);
            // 
            // btnHuella2
            // 
            this.btnHuella2.BackColor = System.Drawing.Color.DimGray;
            this.btnHuella2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuella2.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuella2.ForeColor = System.Drawing.Color.White;
            this.btnHuella2.Location = new System.Drawing.Point(172, 317);
            this.btnHuella2.Name = "btnHuella2";
            this.btnHuella2.Size = new System.Drawing.Size(20, 20);
            this.btnHuella2.TabIndex = 27;
            this.btnHuella2.Text = "2";
            this.btnHuella2.UseVisualStyleBackColor = false;
            this.btnHuella2.Click += new System.EventHandler(this.btnHuella2_Click);
            // 
            // btnHuella1
            // 
            this.btnHuella1.BackColor = System.Drawing.Color.DimGray;
            this.btnHuella1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuella1.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuella1.ForeColor = System.Drawing.Color.White;
            this.btnHuella1.Location = new System.Drawing.Point(217, 409);
            this.btnHuella1.Name = "btnHuella1";
            this.btnHuella1.Size = new System.Drawing.Size(20, 20);
            this.btnHuella1.TabIndex = 26;
            this.btnHuella1.Text = "1";
            this.btnHuella1.UseVisualStyleBackColor = false;
            this.btnHuella1.Click += new System.EventHandler(this.btnHuella1_Click);
            // 
            // btnCamara
            // 
            this.btnCamara.BackColor = System.Drawing.Color.DimGray;
            this.btnCamara.BackgroundImage = global::GymTheBeach.Properties.Resources.camara_reflex_digital;
            this.btnCamara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCamara.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamara.ForeColor = System.Drawing.Color.White;
            this.btnCamara.Location = new System.Drawing.Point(24, 46);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(32, 32);
            this.btnCamara.TabIndex = 25;
            this.btnCamara.UseVisualStyleBackColor = false;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // pbMano
            // 
            this.pbMano.BackColor = System.Drawing.Color.Gray;
            this.pbMano.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMano.Image = global::GymTheBeach.Properties.Resources.mano;
            this.pbMano.Location = new System.Drawing.Point(24, 295);
            this.pbMano.Name = "pbMano";
            this.pbMano.Size = new System.Drawing.Size(226, 218);
            this.pbMano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMano.TabIndex = 56;
            this.pbMano.TabStop = false;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Gray;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoto.Image = global::GymTheBeach.Properties.Resources.usuario;
            this.pbFoto.Location = new System.Drawing.Point(24, 46);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(226, 218);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 55;
            this.pbFoto.TabStop = false;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.Green;
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(294, 571);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(567, 44);
            this.btnRegistrarUsuario.TabIndex = 31;
            this.btnRegistrarUsuario.Text = "REGISTRAR NUEVO USUARIO";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.txtObservaciones.ForeColor = System.Drawing.Color.Black;
            this.txtObservaciones.Location = new System.Drawing.Point(295, 411);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(566, 59);
            this.txtObservaciones.TabIndex = 21;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblObservaciones.Location = new System.Drawing.Point(292, 389);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(98, 19);
            this.lblObservaciones.TabIndex = 20;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtComoNosConocio
            // 
            this.txtComoNosConocio.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.txtComoNosConocio.ForeColor = System.Drawing.Color.Black;
            this.txtComoNosConocio.Location = new System.Drawing.Point(617, 342);
            this.txtComoNosConocio.Name = "txtComoNosConocio";
            this.txtComoNosConocio.Size = new System.Drawing.Size(244, 25);
            this.txtComoNosConocio.TabIndex = 19;
            // 
            // lblComoNosConocio
            // 
            this.lblComoNosConocio.AutoSize = true;
            this.lblComoNosConocio.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblComoNosConocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblComoNosConocio.Location = new System.Drawing.Point(615, 320);
            this.lblComoNosConocio.Name = "lblComoNosConocio";
            this.lblComoNosConocio.Size = new System.Drawing.Size(135, 19);
            this.lblComoNosConocio.TabIndex = 18;
            this.lblComoNosConocio.Text = "¿Cómo nos conoció?";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(295, 342);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 25);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblEmail.Location = new System.Drawing.Point(292, 320);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.txtProfesion.ForeColor = System.Drawing.Color.Black;
            this.txtProfesion.Location = new System.Drawing.Point(617, 274);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(244, 25);
            this.txtProfesion.TabIndex = 15;
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblProfesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblProfesion.Location = new System.Drawing.Point(615, 252);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(66, 19);
            this.lblProfesion.TabIndex = 14;
            this.lblProfesion.Text = "Profesión";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.txtDomicilio.ForeColor = System.Drawing.Color.Black;
            this.txtDomicilio.Location = new System.Drawing.Point(295, 274);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(244, 25);
            this.txtDomicilio.TabIndex = 13;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblDomicilio.Location = new System.Drawing.Point(292, 252);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(65, 19);
            this.lblDomicilio.TabIndex = 12;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(617, 205);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(244, 25);
            this.txtTelefono.TabIndex = 11;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblTelefono.Location = new System.Drawing.Point(615, 183);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 19);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(295, 205);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1923, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(244, 25);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // cmbGenero
            // 
            this.cmbGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGenero.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.cmbGenero.ForeColor = System.Drawing.Color.Black;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(617, 136);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(244, 25);
            this.cmbGenero.TabIndex = 7;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(292, 183);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(134, 19);
            this.lblFechaNacimiento.TabIndex = 8;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblGenero.Location = new System.Drawing.Point(615, 114);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 19);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Genero *";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.txtDNI.ForeColor = System.Drawing.Color.Black;
            this.txtDNI.Location = new System.Drawing.Point(295, 136);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(244, 25);
            this.txtDNI.TabIndex = 5;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblDNI.Location = new System.Drawing.Point(292, 114);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(62, 19);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI/ID *";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(618, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(244, 25);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblApellido.Location = new System.Drawing.Point(615, 46);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 19);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido *";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(295, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblNombre.Location = new System.Drawing.Point(292, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre *";
            // 
            // lblSeparadorMenu
            // 
            this.lblSeparadorMenu.BackColor = System.Drawing.Color.DarkGray;
            this.lblSeparadorMenu.Location = new System.Drawing.Point(243, 9);
            this.lblSeparadorMenu.Name = "lblSeparadorMenu";
            this.lblSeparadorMenu.Size = new System.Drawing.Size(2, 730);
            this.lblSeparadorMenu.TabIndex = 8;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.btnRegistrarNuevoUsuario);
            this.pnlHeader.Controls.Add(this.btnListaUsuarios);
            this.pnlHeader.Controls.Add(this.lblSeparadorHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(250, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(993, 100);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnRegistrarNuevoUsuario
            // 
            this.btnRegistrarNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarNuevoUsuario.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.btnRegistrarNuevoUsuario.Location = new System.Drawing.Point(586, 28);
            this.btnRegistrarNuevoUsuario.Name = "btnRegistrarNuevoUsuario";
            this.btnRegistrarNuevoUsuario.Size = new System.Drawing.Size(195, 44);
            this.btnRegistrarNuevoUsuario.TabIndex = 11;
            this.btnRegistrarNuevoUsuario.Text = "NUEVO USUARIO";
            this.btnRegistrarNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarNuevoUsuario.Click += new System.EventHandler(this.btnRegistrarNuevoUsuario_Click);
            // 
            // btnListaUsuarios
            // 
            this.btnListaUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaUsuarios.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.btnListaUsuarios.Location = new System.Drawing.Point(214, 28);
            this.btnListaUsuarios.Name = "btnListaUsuarios";
            this.btnListaUsuarios.Size = new System.Drawing.Size(195, 44);
            this.btnListaUsuarios.TabIndex = 8;
            this.btnListaUsuarios.Text = "LISTA USUARIOS";
            this.btnListaUsuarios.UseVisualStyleBackColor = false;
            this.btnListaUsuarios.Click += new System.EventHandler(this.btnListaUsuarios_Click);
            // 
            // lblSeparadorHeader
            // 
            this.lblSeparadorHeader.BackColor = System.Drawing.Color.DarkGray;
            this.lblSeparadorHeader.Location = new System.Drawing.Point(11, 97);
            this.lblSeparadorHeader.Name = "lblSeparadorHeader";
            this.lblSeparadorHeader.Size = new System.Drawing.Size(969, 2);
            this.lblSeparadorHeader.TabIndex = 10;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.lblSeparadorHora);
            this.pnlMenu.Controls.Add(this.lblFechaYHora);
            this.pnlMenu.Controls.Add(this.lblTitle);
            this.pnlMenu.Controls.Add(this.pbLogo);
            this.pnlMenu.Controls.Add(this.lblSeparadorTitle);
            this.pnlMenu.Controls.Add(this.btnActividades);
            this.pnlMenu.Controls.Add(this.btnPagos);
            this.pnlMenu.Controls.Add(this.btnAsistencia);
            this.pnlMenu.Controls.Add(this.btnUsuario);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 748);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblSeparadorHora
            // 
            this.lblSeparadorHora.BackColor = System.Drawing.Color.DarkGray;
            this.lblSeparadorHora.Location = new System.Drawing.Point(12, 645);
            this.lblSeparadorHora.Name = "lblSeparadorHora";
            this.lblSeparadorHora.Size = new System.Drawing.Size(214, 2);
            this.lblSeparadorHora.TabIndex = 6;
            // 
            // lblFechaYHora
            // 
            this.lblFechaYHora.AutoSize = true;
            this.lblFechaYHora.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaYHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblFechaYHora.Location = new System.Drawing.Point(38, 663);
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.Size = new System.Drawing.Size(157, 66);
            this.lblFechaYHora.TabIndex = 7;
            this.lblFechaYHora.Text = "HH:mm:ss\r\ndd/MM/yyyy";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 157);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THE BEACH GYM";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(54, 19);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(128, 128);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // lblSeparadorTitle
            // 
            this.lblSeparadorTitle.BackColor = System.Drawing.Color.DarkGray;
            this.lblSeparadorTitle.Location = new System.Drawing.Point(12, 207);
            this.lblSeparadorTitle.Name = "lblSeparadorTitle";
            this.lblSeparadorTitle.Size = new System.Drawing.Size(214, 2);
            this.lblSeparadorTitle.TabIndex = 1;
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActividades.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.btnActividades.Image = global::GymTheBeach.Properties.Resources.boxeo;
            this.btnActividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.Location = new System.Drawing.Point(12, 536);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(214, 83);
            this.btnActividades.TabIndex = 5;
            this.btnActividades.Text = "ACTIVIDADES";
            this.btnActividades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActividades.UseVisualStyleBackColor = false;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.btnPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnPagos.Image")));
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(12, 432);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(214, 83);
            this.btnPagos.TabIndex = 4;
            this.btnPagos.Text = "PAGOS";
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsistencia.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.btnAsistencia.Image = global::GymTheBeach.Properties.Resources.asistencia;
            this.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.Location = new System.Drawing.Point(12, 328);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(214, 83);
            this.btnAsistencia.TabIndex = 3;
            this.btnAsistencia.Text = "ASISTENCIA";
            this.btnAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuario.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.btnUsuario.Image = global::GymTheBeach.Properties.Resources.usuarios;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(12, 226);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(214, 83);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "USUARIOS";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1243, 748);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Beach Gym";
            this.pnlMain.ResumeLayout(false);
            this.gbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbRegistrarUsuario.ResumeLayout(false);
            this.gbRegistrarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Label lblSeparadorTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblSeparadorMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFechaYHora;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblSeparadorHeader;
        private System.Windows.Forms.Label lblSeparadorHora;
        private System.Windows.Forms.Button btnListaUsuarios;
        private System.Windows.Forms.Button btnRegistrarNuevoUsuario;
        private System.Windows.Forms.GroupBox gbRegistrarUsuario;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtComoNosConocio;
        private System.Windows.Forms.Label lblComoNosConocio;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Label lblProfesion;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbListaUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnHuella1;
        private System.Windows.Forms.Button btnCamara;
        private System.Windows.Forms.PictureBox pbMano;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnHuella5;
        private System.Windows.Forms.Button btnHuella4;
        private System.Windows.Forms.Button btnHuella3;
        private System.Windows.Forms.Button btnHuella2;
        private System.Windows.Forms.CheckBox chkPermisos;
        private System.Windows.Forms.ComboBox cmbPermiso;
        private System.Windows.Forms.Label lblPermiso;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnActivUsuario;
        private System.Windows.Forms.Button btnAsistUsuario;
        private System.Windows.Forms.Button btnPagosUsuario;
        private System.Windows.Forms.Button btnDarDeBaja;
    }
}

