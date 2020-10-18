namespace CapaIU
{
    partial class FrmProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesor));
            this.lblTituloP = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEstadoP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCorreoP = new System.Windows.Forms.TextBox();
            this.txtApellido2P = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtTelefonoP = new System.Windows.Forms.TextBox();
            this.txtApellido1P = new System.Windows.Forms.TextBox();
            this.txtCedulaP = new System.Windows.Forms.TextBox();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblApellido2P = new System.Windows.Forms.Label();
            this.lblEmailP = new System.Windows.Forms.Label();
            this.lblTelefonoP = new System.Windows.Forms.Label();
            this.lblApellido1P = new System.Windows.Forms.Label();
            this.lblCedulaP = new System.Windows.Forms.Label();
            this.grdListaP = new System.Windows.Forms.DataGridView();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnActualizarP = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.btnSalirP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloP
            // 
            this.lblTituloP.AutoSize = true;
            this.lblTituloP.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTituloP.Location = new System.Drawing.Point(211, 18);
            this.lblTituloP.Name = "lblTituloP";
            this.lblTituloP.Size = new System.Drawing.Size(345, 25);
            this.lblTituloP.TabIndex = 8;
            this.lblTituloP.Text = "Sistema de Matrícula - Universidad J-M";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(589, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(79, 27);
            this.txtId.TabIndex = 9;
            this.txtId.Visible = false;
            // 
            // txtEstadoP
            // 
            this.txtEstadoP.Location = new System.Drawing.Point(690, 19);
            this.txtEstadoP.Name = "txtEstadoP";
            this.txtEstadoP.Size = new System.Drawing.Size(77, 27);
            this.txtEstadoP.TabIndex = 9;
            this.txtEstadoP.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCorreoP);
            this.groupBox1.Controls.Add(this.txtApellido2P);
            this.groupBox1.Controls.Add(this.txtNombreP);
            this.groupBox1.Controls.Add(this.txtTelefonoP);
            this.groupBox1.Controls.Add(this.txtApellido1P);
            this.groupBox1.Controls.Add(this.txtCedulaP);
            this.groupBox1.Controls.Add(this.lblNombreP);
            this.groupBox1.Controls.Add(this.lblApellido2P);
            this.groupBox1.Controls.Add(this.lblEmailP);
            this.groupBox1.Controls.Add(this.lblTelefonoP);
            this.groupBox1.Controls.Add(this.lblApellido1P);
            this.groupBox1.Controls.Add(this.lblCedulaP);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del profesor";
            // 
            // txtCorreoP
            // 
            this.txtCorreoP.Location = new System.Drawing.Point(552, 123);
            this.txtCorreoP.Name = "txtCorreoP";
            this.txtCorreoP.Size = new System.Drawing.Size(171, 27);
            this.txtCorreoP.TabIndex = 5;
            // 
            // txtApellido2P
            // 
            this.txtApellido2P.Location = new System.Drawing.Point(552, 81);
            this.txtApellido2P.Name = "txtApellido2P";
            this.txtApellido2P.Size = new System.Drawing.Size(171, 27);
            this.txtApellido2P.TabIndex = 5;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(552, 36);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(171, 27);
            this.txtNombreP.TabIndex = 5;
            // 
            // txtTelefonoP
            // 
            this.txtTelefonoP.Location = new System.Drawing.Point(157, 123);
            this.txtTelefonoP.Name = "txtTelefonoP";
            this.txtTelefonoP.Size = new System.Drawing.Size(171, 27);
            this.txtTelefonoP.TabIndex = 5;
            // 
            // txtApellido1P
            // 
            this.txtApellido1P.Location = new System.Drawing.Point(157, 81);
            this.txtApellido1P.Name = "txtApellido1P";
            this.txtApellido1P.Size = new System.Drawing.Size(171, 27);
            this.txtApellido1P.TabIndex = 5;
            // 
            // txtCedulaP
            // 
            this.txtCedulaP.Location = new System.Drawing.Point(157, 32);
            this.txtCedulaP.Name = "txtCedulaP";
            this.txtCedulaP.Size = new System.Drawing.Size(171, 27);
            this.txtCedulaP.TabIndex = 5;
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(398, 39);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(132, 20);
            this.lblNombreP.TabIndex = 0;
            this.lblNombreP.Text = "Nombres Profesor:";
            // 
            // lblApellido2P
            // 
            this.lblApellido2P.AutoSize = true;
            this.lblApellido2P.Location = new System.Drawing.Point(398, 77);
            this.lblApellido2P.Name = "lblApellido2P";
            this.lblApellido2P.Size = new System.Drawing.Size(129, 20);
            this.lblApellido2P.TabIndex = 0;
            this.lblApellido2P.Text = "Segundo Apellido";
            // 
            // lblEmailP
            // 
            this.lblEmailP.AutoSize = true;
            this.lblEmailP.Location = new System.Drawing.Point(398, 119);
            this.lblEmailP.Name = "lblEmailP";
            this.lblEmailP.Size = new System.Drawing.Size(108, 20);
            this.lblEmailP.TabIndex = 0;
            this.lblEmailP.Text = "Email Profesor:";
            // 
            // lblTelefonoP
            // 
            this.lblTelefonoP.AutoSize = true;
            this.lblTelefonoP.Location = new System.Drawing.Point(17, 123);
            this.lblTelefonoP.Name = "lblTelefonoP";
            this.lblTelefonoP.Size = new System.Drawing.Size(129, 20);
            this.lblTelefonoP.TabIndex = 0;
            this.lblTelefonoP.Text = "Teléfono Profesor:";
            // 
            // lblApellido1P
            // 
            this.lblApellido1P.AutoSize = true;
            this.lblApellido1P.Location = new System.Drawing.Point(17, 81);
            this.lblApellido1P.Name = "lblApellido1P";
            this.lblApellido1P.Size = new System.Drawing.Size(116, 20);
            this.lblApellido1P.TabIndex = 0;
            this.lblApellido1P.Text = "Primer Apellido:";
            // 
            // lblCedulaP
            // 
            this.lblCedulaP.AutoSize = true;
            this.lblCedulaP.Location = new System.Drawing.Point(17, 39);
            this.lblCedulaP.Name = "lblCedulaP";
            this.lblCedulaP.Size = new System.Drawing.Size(117, 20);
            this.lblCedulaP.TabIndex = 4;
            this.lblCedulaP.Text = "Cedula Profesor:";
            // 
            // grdListaP
            // 
            this.grdListaP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaP.Location = new System.Drawing.Point(12, 357);
            this.grdListaP.Name = "grdListaP";
            this.grdListaP.RowHeadersWidth = 51;
            this.grdListaP.Size = new System.Drawing.Size(755, 252);
            this.grdListaP.TabIndex = 11;
            this.grdListaP.Text = "dataGridView1";
            this.grdListaP.DoubleClick += new System.EventHandler(this.grdListaP_DoubleClick);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarP.BackgroundImage")));
            this.btnEliminarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarP.Location = new System.Drawing.Point(536, 281);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(100, 60);
            this.btnEliminarP.TabIndex = 3;
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnActualizarP
            // 
            this.btnActualizarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarP.BackgroundImage")));
            this.btnActualizarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizarP.Location = new System.Drawing.Point(399, 281);
            this.btnActualizarP.Name = "btnActualizarP";
            this.btnActualizarP.Size = new System.Drawing.Size(100, 60);
            this.btnActualizarP.TabIndex = 3;
            this.btnActualizarP.UseVisualStyleBackColor = true;
            this.btnActualizarP.Click += new System.EventHandler(this.btnActualizarP_Click);
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarP.BackgroundImage")));
            this.btnAgregarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarP.Location = new System.Drawing.Point(274, 281);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(100, 60);
            this.btnAgregarP.TabIndex = 3;
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarP.BackgroundImage")));
            this.btnBuscarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarP.Location = new System.Drawing.Point(140, 281);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(100, 60);
            this.btnBuscarP.TabIndex = 3;
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // btnSalirP
            // 
            this.btnSalirP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalirP.BackgroundImage")));
            this.btnSalirP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalirP.Location = new System.Drawing.Point(661, 615);
            this.btnSalirP.Name = "btnSalirP";
            this.btnSalirP.Size = new System.Drawing.Size(106, 60);
            this.btnSalirP.TabIndex = 3;
            this.btnSalirP.UseVisualStyleBackColor = true;
            this.btnSalirP.Click += new System.EventHandler(this.btnSalirP_Click);
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(797, 684);
            this.Controls.Add(this.btnSalirP);
            this.Controls.Add(this.btnBuscarP);
            this.Controls.Add(this.btnAgregarP);
            this.Controls.Add(this.btnActualizarP);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.grdListaP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEstadoP);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTituloP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Profesor";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloP;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEstadoP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTelefonoP;
        private System.Windows.Forms.Label lblApellido1P;
        private System.Windows.Forms.Label lblCedulaP;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblApellido2P;
        private System.Windows.Forms.Label lblEmailP;
        private System.Windows.Forms.TextBox txtCedulaP;
        private System.Windows.Forms.TextBox txtCorreoP;
        private System.Windows.Forms.TextBox txtApellido2P;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtTelefonoP;
        private System.Windows.Forms.TextBox txtApellido1P;
        private System.Windows.Forms.DataGridView grdListaP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnActualizarP;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Button btnSalirP;
    }
}