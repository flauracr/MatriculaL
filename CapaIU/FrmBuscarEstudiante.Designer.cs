using System;

namespace CapaIU
{
    partial class FrmBuscarEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarEstudiante));
            this.lblNombreEB = new System.Windows.Forms.Label();
            this.txtNombreEB = new System.Windows.Forms.TextBox();
            this.btnBuscarEstu = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grdLista2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltitulo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreEB
            // 
            this.lblNombreEB.AutoSize = true;
            this.lblNombreEB.Location = new System.Drawing.Point(6, 62);
            this.lblNombreEB.Name = "lblNombreEB";
            this.lblNombreEB.Size = new System.Drawing.Size(137, 20);
            this.lblNombreEB.TabIndex = 0;
            this.lblNombreEB.Text = "Nombre Estudiante";
            // 
            // txtNombreEB
            // 
            this.txtNombreEB.Location = new System.Drawing.Point(149, 55);
            this.txtNombreEB.Name = "txtNombreEB";
            this.txtNombreEB.Size = new System.Drawing.Size(237, 27);
            this.txtNombreEB.TabIndex = 1;
            // 
            // btnBuscarEstu
            // 
            this.btnBuscarEstu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEstu.BackgroundImage")));
            this.btnBuscarEstu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarEstu.Location = new System.Drawing.Point(405, 22);
            this.btnBuscarEstu.Name = "btnBuscarEstu";
            this.btnBuscarEstu.Size = new System.Drawing.Size(100, 60);
            this.btnBuscarEstu.TabIndex = 3;
            this.btnBuscarEstu.UseVisualStyleBackColor = true;
            this.btnBuscarEstu.Click += new System.EventHandler(this.btnBuscarEstu_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(571, 458);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 60);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(696, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 60);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grdLista2
            // 
            this.grdLista2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLista2.Location = new System.Drawing.Point(21, 217);
            this.grdLista2.Name = "grdLista2";
            this.grdLista2.RowHeadersWidth = 51;
            this.grdLista2.Size = new System.Drawing.Size(775, 217);
            this.grdLista2.TabIndex = 4;
            this.grdLista2.Text = "dataGridView1";
            this.grdLista2.DoubleClick += new System.EventHandler(this.grdLista_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreEB);
            this.groupBox1.Controls.Add(this.txtNombreEB);
            this.groupBox1.Controls.Add(this.btnBuscarEstu);
            this.groupBox1.Location = new System.Drawing.Point(21, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del estudiante";
            // 
            // lbltitulo2
            // 
            this.lbltitulo2.AutoSize = true;
            this.lbltitulo2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitulo2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbltitulo2.Location = new System.Drawing.Point(251, 18);
            this.lbltitulo2.Name = "lbltitulo2";
            this.lbltitulo2.Size = new System.Drawing.Size(345, 25);
            this.lbltitulo2.TabIndex = 8;
            this.lbltitulo2.Text = "Sistema de Matrícula - Universidad J-M";
            this.lbltitulo2.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmBuscarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(820, 545);
            this.Controls.Add(this.lbltitulo2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grdLista2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Estudiante";
            this.Load += new System.EventHandler(this.FrmBuscarEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLista2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblNombreEB;
        private System.Windows.Forms.TextBox txtNombreEB;
        private System.Windows.Forms.Button btnBuscarEstu;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grdLista2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltitulo2;
    }
}