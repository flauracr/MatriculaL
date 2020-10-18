namespace CapaIU
{
    partial class FrmBuscarMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarMateria));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarM = new System.Windows.Forms.Button();
            this.txtNombreMateriaBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdLista2BM = new System.Windows.Forms.DataGridView();
            this.btnAceptarBM = new System.Windows.Forms.Button();
            this.btnCancelarBM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista2BM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(228, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Matrícula - Universidad JYM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarM);
            this.groupBox1.Controls.Add(this.txtNombreMateriaBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la materia a buscar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBuscarM
            // 
            this.btnBuscarM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarM.BackgroundImage")));
            this.btnBuscarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarM.Location = new System.Drawing.Point(535, 41);
            this.btnBuscarM.Name = "btnBuscarM";
            this.btnBuscarM.Size = new System.Drawing.Size(100, 60);
            this.btnBuscarM.TabIndex = 2;
            this.btnBuscarM.UseVisualStyleBackColor = true;
            this.btnBuscarM.Click += new System.EventHandler(this.btnBuscarM_Click);
            // 
            // txtNombreMateriaBuscar
            // 
            this.txtNombreMateriaBuscar.Location = new System.Drawing.Point(202, 73);
            this.txtNombreMateriaBuscar.Name = "txtNombreMateriaBuscar";
            this.txtNombreMateriaBuscar.Size = new System.Drawing.Size(294, 27);
            this.txtNombreMateriaBuscar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de la materia:";
            // 
            // grdLista2BM
            // 
            this.grdLista2BM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLista2BM.Location = new System.Drawing.Point(12, 229);
            this.grdLista2BM.Name = "grdLista2BM";
            this.grdLista2BM.RowHeadersWidth = 51;
            this.grdLista2BM.Size = new System.Drawing.Size(796, 188);
            this.grdLista2BM.TabIndex = 2;
            this.grdLista2BM.Text = "dataGridView1";
            this.grdLista2BM.DoubleClick += new System.EventHandler(this.grdLista2BM_DoubleClick);
            // 
            // btnAceptarBM
            // 
            this.btnAceptarBM.Location = new System.Drawing.Point(581, 445);
            this.btnAceptarBM.Name = "btnAceptarBM";
            this.btnAceptarBM.Size = new System.Drawing.Size(100, 48);
            this.btnAceptarBM.TabIndex = 3;
            this.btnAceptarBM.Text = "Aceptar";
            this.btnAceptarBM.UseVisualStyleBackColor = true;
            this.btnAceptarBM.Click += new System.EventHandler(this.btnAceptarBM_Click);
            // 
            // btnCancelarBM
            // 
            this.btnCancelarBM.Location = new System.Drawing.Point(708, 445);
            this.btnCancelarBM.Name = "btnCancelarBM";
            this.btnCancelarBM.Size = new System.Drawing.Size(100, 48);
            this.btnCancelarBM.TabIndex = 3;
            this.btnCancelarBM.Text = "Cancelar";
            this.btnCancelarBM.UseVisualStyleBackColor = true;
            this.btnCancelarBM.Click += new System.EventHandler(this.btnCancelarBM_Click);
            // 
            // FrmBuscarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(820, 505);
            this.Controls.Add(this.btnCancelarBM);
            this.Controls.Add(this.btnAceptarBM);
            this.Controls.Add(this.grdLista2BM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Materia";
            this.Load += new System.EventHandler(this.FrmBuscarMateria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista2BM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreMateriaBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarM;
        private System.Windows.Forms.DataGridView grdLista2BM;
        private System.Windows.Forms.Button btnAceptarBM;
        private System.Windows.Forms.Button btnCancelarBM;
    }
}