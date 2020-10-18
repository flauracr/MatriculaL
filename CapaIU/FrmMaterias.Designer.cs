namespace CapaIU
{
    partial class FrmMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterias));
            this.lblTituloM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHorasTotales = new System.Windows.Forms.TextBox();
            this.lblHorasTotales = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.txtCodMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.lblCodMateria = new System.Windows.Forms.Label();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.btnActualizarM = new System.Windows.Forms.Button();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.btnBuscarM = new System.Windows.Forms.Button();
            this.grdListaM = new System.Windows.Forms.DataGridView();
            this.btnSalirM = new System.Windows.Forms.Button();
            this.txtIdMateria = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloM
            // 
            this.lblTituloM.AutoSize = true;
            this.lblTituloM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloM.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTituloM.Location = new System.Drawing.Point(203, 24);
            this.lblTituloM.Name = "lblTituloM";
            this.lblTituloM.Size = new System.Drawing.Size(349, 25);
            this.lblTituloM.TabIndex = 0;
            this.lblTituloM.Text = "Sistema de Matrícula - Universidad JYM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHorasTotales);
            this.groupBox1.Controls.Add(this.lblHorasTotales);
            this.groupBox1.Controls.Add(this.txtNombreMateria);
            this.groupBox1.Controls.Add(this.txtCodMateria);
            this.groupBox1.Controls.Add(this.lblNombreMateria);
            this.groupBox1.Controls.Add(this.lblCodMateria);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de las materias de la Universidad JYM";
            // 
            // txtHorasTotales
            // 
            this.txtHorasTotales.Location = new System.Drawing.Point(530, 48);
            this.txtHorasTotales.Name = "txtHorasTotales";
            this.txtHorasTotales.Size = new System.Drawing.Size(216, 27);
            this.txtHorasTotales.TabIndex = 4;
            // 
            // lblHorasTotales
            // 
            this.lblHorasTotales.AutoSize = true;
            this.lblHorasTotales.Location = new System.Drawing.Point(413, 55);
            this.lblHorasTotales.Name = "lblHorasTotales";
            this.lblHorasTotales.Size = new System.Drawing.Size(102, 20);
            this.lblHorasTotales.TabIndex = 3;
            this.lblHorasTotales.Text = "Horas Totales:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(175, 105);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(571, 27);
            this.txtNombreMateria.TabIndex = 2;
            // 
            // txtCodMateria
            // 
            this.txtCodMateria.BackColor = System.Drawing.SystemColors.Info;
            this.txtCodMateria.Location = new System.Drawing.Point(175, 48);
            this.txtCodMateria.Name = "txtCodMateria";
            this.txtCodMateria.Size = new System.Drawing.Size(207, 27);
            this.txtCodMateria.TabIndex = 1;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Location = new System.Drawing.Point(23, 112);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(143, 20);
            this.lblNombreMateria.TabIndex = 0;
            this.lblNombreMateria.Text = "Nombre de materia:";
            // 
            // lblCodMateria
            // 
            this.lblCodMateria.AutoSize = true;
            this.lblCodMateria.Location = new System.Drawing.Point(23, 51);
            this.lblCodMateria.Name = "lblCodMateria";
            this.lblCodMateria.Size = new System.Drawing.Size(137, 20);
            this.lblCodMateria.TabIndex = 0;
            this.lblCodMateria.Text = "Código de materia:";
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarM.BackgroundImage")));
            this.btnEliminarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarM.Location = new System.Drawing.Point(541, 266);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(100, 60);
            this.btnEliminarM.TabIndex = 3;
            this.btnEliminarM.UseVisualStyleBackColor = true;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // btnActualizarM
            // 
            this.btnActualizarM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarM.BackgroundImage")));
            this.btnActualizarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizarM.Location = new System.Drawing.Point(404, 266);
            this.btnActualizarM.Name = "btnActualizarM";
            this.btnActualizarM.Size = new System.Drawing.Size(100, 60);
            this.btnActualizarM.TabIndex = 3;
            this.btnActualizarM.UseVisualStyleBackColor = true;
            this.btnActualizarM.Click += new System.EventHandler(this.btnActualizarM_Click);
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarM.BackgroundImage")));
            this.btnAgregarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarM.Location = new System.Drawing.Point(279, 266);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(100, 60);
            this.btnAgregarM.TabIndex = 3;
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // btnBuscarM
            // 
            this.btnBuscarM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarM.BackgroundImage")));
            this.btnBuscarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarM.Location = new System.Drawing.Point(145, 266);
            this.btnBuscarM.Name = "btnBuscarM";
            this.btnBuscarM.Size = new System.Drawing.Size(100, 60);
            this.btnBuscarM.TabIndex = 3;
            this.btnBuscarM.UseVisualStyleBackColor = true;
            this.btnBuscarM.Click += new System.EventHandler(this.btnBuscarM_Click);
            // 
            // grdListaM
            // 
            this.grdListaM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaM.Location = new System.Drawing.Point(12, 350);
            this.grdListaM.Name = "grdListaM";
            this.grdListaM.RowHeadersWidth = 51;
            this.grdListaM.Size = new System.Drawing.Size(764, 236);
            this.grdListaM.TabIndex = 4;
            this.grdListaM.Text = "dataGridView1";
            this.grdListaM.DoubleClick += new System.EventHandler(this.grdListaM_DoubleClick);
            // 
            // btnSalirM
            // 
            this.btnSalirM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalirM.BackgroundImage")));
            this.btnSalirM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalirM.Location = new System.Drawing.Point(676, 612);
            this.btnSalirM.Name = "btnSalirM";
            this.btnSalirM.Size = new System.Drawing.Size(100, 60);
            this.btnSalirM.TabIndex = 3;
            this.btnSalirM.UseVisualStyleBackColor = true;
            this.btnSalirM.Click += new System.EventHandler(this.btnSalirM_Click);
            // 
            // txtIdMateria
            // 
            this.txtIdMateria.Location = new System.Drawing.Point(707, 25);
            this.txtIdMateria.Name = "txtIdMateria";
            this.txtIdMateria.Size = new System.Drawing.Size(69, 27);
            this.txtIdMateria.TabIndex = 5;
            this.txtIdMateria.Visible = false;
            // 
            // FrmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(797, 684);
            this.Controls.Add(this.txtIdMateria);
            this.Controls.Add(this.btnSalirM);
            this.Controls.Add(this.grdListaM);
            this.Controls.Add(this.btnBuscarM);
            this.Controls.Add(this.btnAgregarM);
            this.Controls.Add(this.btnActualizarM);
            this.Controls.Add(this.btnEliminarM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTituloM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Matertias";
            this.Load += new System.EventHandler(this.FrmMaterias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtCodMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.TextBox txtHorasTotales;
        private System.Windows.Forms.Label lblHorasTotales;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Button btnActualizarM;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.Button btnBuscarM;
        private System.Windows.Forms.DataGridView grdListaM;
        private System.Windows.Forms.Button btnSalirM;
        private System.Windows.Forms.TextBox txtIdMateria;
    }
}