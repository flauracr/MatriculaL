namespace CapaIU
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMEstudiante = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMProfesor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRealizarMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalirA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuMatricula,
            this.mnuAyuda,
            this.mnuSalirA});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMEstudiante,
            this.mnuMProfesor,
            this.mnuMMaterias,
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(73, 24);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mnuMEstudiante
            // 
            this.mnuMEstudiante.Name = "mnuMEstudiante";
            this.mnuMEstudiante.Size = new System.Drawing.Size(266, 26);
            this.mnuMEstudiante.Text = "Mantenimiento Estudiante";
            this.mnuMEstudiante.Click += new System.EventHandler(this.mnuMEstudiante_Click);
            // 
            // mnuMProfesor
            // 
            this.mnuMProfesor.Name = "mnuMProfesor";
            this.mnuMProfesor.Size = new System.Drawing.Size(266, 26);
            this.mnuMProfesor.Text = "Mantenimiento Profesor";
            this.mnuMProfesor.Click += new System.EventHandler(this.mnuMProfesor_Click);
            // 
            // mnuMMaterias
            // 
            this.mnuMMaterias.Name = "mnuMMaterias";
            this.mnuMMaterias.Size = new System.Drawing.Size(266, 26);
            this.mnuMMaterias.Text = "Mantenimiento Materias";
            this.mnuMMaterias.Click += new System.EventHandler(this.mnuMMaterias_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(266, 26);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuMatricula
            // 
            this.mnuMatricula.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRealizarMatricula});
            this.mnuMatricula.Name = "mnuMatricula";
            this.mnuMatricula.Size = new System.Drawing.Size(85, 24);
            this.mnuMatricula.Text = "Matrícula";
            // 
            // mnuRealizarMatricula
            // 
            this.mnuRealizarMatricula.Name = "mnuRealizarMatricula";
            this.mnuRealizarMatricula.Size = new System.Drawing.Size(211, 26);
            this.mnuRealizarMatricula.Text = "Realizar Matrícula";
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcercade});
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(65, 24);
            this.mnuAyuda.Text = "Ayuda";
            // 
            // mnuAcercade
            // 
            this.mnuAcercade.Name = "mnuAcercade";
            this.mnuAcercade.Size = new System.Drawing.Size(158, 26);
            this.mnuAcercade.Text = "Acerca de";
            this.mnuAcercade.Click += new System.EventHandler(this.mnuAcercade_Click);
            // 
            // mnuSalirA
            // 
            this.mnuSalirA.Name = "mnuSalirA";
            this.mnuSalirA.Size = new System.Drawing.Size(52, 24);
            this.mnuSalirA.Text = "Salir";
            this.mnuSalirA.Click += new System.EventHandler(this.mnuSalirA_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 903);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrícula - Universidad J&M";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuMEstudiante;
        private System.Windows.Forms.ToolStripMenuItem mnuMProfesor;
        private System.Windows.Forms.ToolStripMenuItem mnuMMaterias;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercade;
        private System.Windows.Forms.ToolStripMenuItem mnuSalirA;
        private System.Windows.Forms.ToolStripMenuItem mnuMatricula;
        private System.Windows.Forms.ToolStripMenuItem mnuRealizarMatricula;
    }
}