namespace CapaIU
{
    partial class FrmBuscarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarProfesor));
            this.lbltituloP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.grdLista2P = new System.Windows.Forms.DataGridView();
            this.btnAceptarP = new System.Windows.Forms.Button();
            this.btnCancelarP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista2P)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltituloP
            // 
            this.lbltituloP.AutoSize = true;
            this.lbltituloP.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltituloP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbltituloP.Location = new System.Drawing.Point(213, 26);
            this.lbltituloP.Name = "lbltituloP";
            this.lbltituloP.Size = new System.Drawing.Size(345, 25);
            this.lbltituloP.TabIndex = 8;
            this.lbltituloP.Text = "Sistema de Matrícula - Universidad J-M";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarP);
            this.groupBox1.Controls.Add(this.txtNombreProfesor);
            this.groupBox1.Controls.Add(this.lblNombreP);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 116);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del profesor";
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarP.BackgroundImage")));
            this.btnBuscarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarP.Location = new System.Drawing.Point(413, 26);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(100, 60);
            this.btnBuscarP.TabIndex = 3;
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.Location = new System.Drawing.Point(152, 59);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.Size = new System.Drawing.Size(234, 27);
            this.txtNombreProfesor.TabIndex = 1;
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(6, 66);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(127, 20);
            this.lblNombreP.TabIndex = 0;
            this.lblNombreP.Text = "Nombre profesor:";
            // 
            // grdLista2P
            // 
            this.grdLista2P.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLista2P.Location = new System.Drawing.Point(12, 203);
            this.grdLista2P.Name = "grdLista2P";
            this.grdLista2P.RowHeadersWidth = 51;
            this.grdLista2P.Size = new System.Drawing.Size(776, 188);
            this.grdLista2P.TabIndex = 10;
            this.grdLista2P.Text = "dataGridView1";
            this.grdLista2P.DoubleClick += new System.EventHandler(this.grdLista2P_DoubleClick);
            // 
            // btnAceptarP
            // 
            this.btnAceptarP.Location = new System.Drawing.Point(560, 417);
            this.btnAceptarP.Name = "btnAceptarP";
            this.btnAceptarP.Size = new System.Drawing.Size(100, 60);
            this.btnAceptarP.TabIndex = 3;
            this.btnAceptarP.Text = "Aceptar";
            this.btnAceptarP.UseVisualStyleBackColor = true;
            this.btnAceptarP.Click += new System.EventHandler(this.btnAceptarP_Click);
            // 
            // btnCancelarP
            // 
            this.btnCancelarP.Location = new System.Drawing.Point(685, 417);
            this.btnCancelarP.Name = "btnCancelarP";
            this.btnCancelarP.Size = new System.Drawing.Size(100, 60);
            this.btnCancelarP.TabIndex = 3;
            this.btnCancelarP.Text = "Cancelar";
            this.btnCancelarP.UseVisualStyleBackColor = true;
            this.btnCancelarP.Click += new System.EventHandler(this.btnCancelarP_Click);
            // 
            // FrmBuscarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(820, 505);
            this.Controls.Add(this.btnCancelarP);
            this.Controls.Add(this.btnAceptarP);
            this.Controls.Add(this.grdLista2P);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltituloP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Profesor";
            this.Load += new System.EventHandler(this.FrmBuscarProfesor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista2P)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltituloP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.DataGridView grdLista2P;
        private System.Windows.Forms.Button btnAceptarP;
        private System.Windows.Forms.Button btnCancelarP;
    }
}