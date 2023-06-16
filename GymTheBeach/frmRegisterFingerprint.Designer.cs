namespace GymTheBeach
{
    partial class frmRegisterFingerprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterFingerprint));
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.pbStatusHuella3 = new System.Windows.Forms.PictureBox();
            this.pbStatusHuella2 = new System.Windows.Forms.PictureBox();
            this.pbStatusHuella1 = new System.Windows.Forms.PictureBox();
            this.pbHuella3 = new System.Windows.Forms.PictureBox();
            this.pbHuella2 = new System.Windows.Forms.PictureBox();
            this.pbHuella1 = new System.Windows.Forms.PictureBox();
            this.pbHuella = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusHuella3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusHuella2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusHuella1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIndicaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
            this.lblIndicaciones.Location = new System.Drawing.Point(12, 7);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(260, 33);
            this.lblIndicaciones.TabIndex = 0;
            this.lblIndicaciones.Text = "Por favor, apoye su dedo 3 veces";
            this.lblIndicaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbStatusHuella3
            // 
            this.pbStatusHuella3.Image = global::GymTheBeach.Properties.Resources.pending;
            this.pbStatusHuella3.Location = new System.Drawing.Point(256, 234);
            this.pbStatusHuella3.Name = "pbStatusHuella3";
            this.pbStatusHuella3.Size = new System.Drawing.Size(16, 16);
            this.pbStatusHuella3.TabIndex = 16;
            this.pbStatusHuella3.TabStop = false;
            // 
            // pbStatusHuella2
            // 
            this.pbStatusHuella2.Image = global::GymTheBeach.Properties.Resources.pending;
            this.pbStatusHuella2.Location = new System.Drawing.Point(154, 234);
            this.pbStatusHuella2.Name = "pbStatusHuella2";
            this.pbStatusHuella2.Size = new System.Drawing.Size(16, 16);
            this.pbStatusHuella2.TabIndex = 15;
            this.pbStatusHuella2.TabStop = false;
            // 
            // pbStatusHuella1
            // 
            this.pbStatusHuella1.Image = global::GymTheBeach.Properties.Resources.pending;
            this.pbStatusHuella1.InitialImage = null;
            this.pbStatusHuella1.Location = new System.Drawing.Point(51, 234);
            this.pbStatusHuella1.Name = "pbStatusHuella1";
            this.pbStatusHuella1.Size = new System.Drawing.Size(16, 16);
            this.pbStatusHuella1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStatusHuella1.TabIndex = 14;
            this.pbStatusHuella1.TabStop = false;
            // 
            // pbHuella3
            // 
            this.pbHuella3.Image = ((System.Drawing.Image)(resources.GetObject("pbHuella3.Image")));
            this.pbHuella3.InitialImage = null;
            this.pbHuella3.Location = new System.Drawing.Point(217, 234);
            this.pbHuella3.Name = "pbHuella3";
            this.pbHuella3.Size = new System.Drawing.Size(55, 74);
            this.pbHuella3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHuella3.TabIndex = 11;
            this.pbHuella3.TabStop = false;
            // 
            // pbHuella2
            // 
            this.pbHuella2.Image = ((System.Drawing.Image)(resources.GetObject("pbHuella2.Image")));
            this.pbHuella2.InitialImage = null;
            this.pbHuella2.Location = new System.Drawing.Point(115, 234);
            this.pbHuella2.Name = "pbHuella2";
            this.pbHuella2.Size = new System.Drawing.Size(55, 74);
            this.pbHuella2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHuella2.TabIndex = 10;
            this.pbHuella2.TabStop = false;
            // 
            // pbHuella1
            // 
            this.pbHuella1.Image = ((System.Drawing.Image)(resources.GetObject("pbHuella1.Image")));
            this.pbHuella1.InitialImage = null;
            this.pbHuella1.Location = new System.Drawing.Point(12, 234);
            this.pbHuella1.Name = "pbHuella1";
            this.pbHuella1.Size = new System.Drawing.Size(55, 74);
            this.pbHuella1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHuella1.TabIndex = 9;
            this.pbHuella1.TabStop = false;
            // 
            // pbHuella
            // 
            this.pbHuella.BackColor = System.Drawing.Color.Gray;
            this.pbHuella.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHuella.Location = new System.Drawing.Point(72, 45);
            this.pbHuella.Name = "pbHuella";
            this.pbHuella.Size = new System.Drawing.Size(141, 169);
            this.pbHuella.TabIndex = 2;
            this.pbHuella.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(12, 323);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 58);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "GUARDAR HUELLA";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(166, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 58);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmRegisterFingerprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 393);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pbStatusHuella3);
            this.Controls.Add(this.pbStatusHuella2);
            this.Controls.Add(this.pbStatusHuella1);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.pbHuella3);
            this.Controls.Add(this.pbHuella2);
            this.Controls.Add(this.pbHuella1);
            this.Controls.Add(this.pbHuella);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegisterFingerprint";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar nueva huella";
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusHuella3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusHuella2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusHuella1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHuella;
        private System.Windows.Forms.PictureBox pbHuella1;
        private System.Windows.Forms.PictureBox pbHuella2;
        private System.Windows.Forms.PictureBox pbHuella3;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.PictureBox pbStatusHuella1;
        private System.Windows.Forms.PictureBox pbStatusHuella2;
        private System.Windows.Forms.PictureBox pbStatusHuella3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}