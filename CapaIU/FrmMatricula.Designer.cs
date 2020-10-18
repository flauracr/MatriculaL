namespace CapaIU
{
    partial class FrmMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatricula));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombreMateriaA = new System.Windows.Forms.Label();
            this.cbxMateriaA = new System.Windows.Forms.ComboBox();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNombreEstudianteM = new System.Windows.Forms.Label();
            this.cbxNombreEstudianteM = new System.Windows.Forms.ComboBox();
            this.lblMateriaM = new System.Windows.Forms.Label();
            this.cbxMateriaM = new System.Windows.Forms.ComboBox();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Matrícula - Universidad JYM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblNombreProfesor);
            this.groupBox1.Controls.Add(this.cbxMateriaA);
            this.groupBox1.Controls.Add(this.lblNombreMateriaA);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Materias Abiertas";
            // 
            // lblNombreMateriaA
            // 
            this.lblNombreMateriaA.AutoSize = true;
            this.lblNombreMateriaA.Location = new System.Drawing.Point(6, 36);
            this.lblNombreMateriaA.Name = "lblNombreMateriaA";
            this.lblNombreMateriaA.Size = new System.Drawing.Size(143, 20);
            this.lblNombreMateriaA.TabIndex = 0;
            this.lblNombreMateriaA.Text = "Nombre de materia:";
            // 
            // cbxMateriaA
            // 
            this.cbxMateriaA.FormattingEnabled = true;
            this.cbxMateriaA.Location = new System.Drawing.Point(155, 28);
            this.cbxMateriaA.Name = "cbxMateriaA";
            this.cbxMateriaA.Size = new System.Drawing.Size(204, 28);
            this.cbxMateriaA.TabIndex = 1;
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Location = new System.Drawing.Point(375, 36);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(148, 20);
            this.lblNombreProfesor.TabIndex = 2;
            this.lblNombreProfesor.Text = "Nombre de profesor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(529, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grupo:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(155, 74);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(171, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Diurno (7am a 11am)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(357, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(164, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tarde (12pm a 4pm)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(556, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(163, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Noche (5pm a 9pm)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(773, 140);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMatricular);
            this.groupBox2.Controls.Add(this.cbxMateriaM);
            this.groupBox2.Controls.Add(this.lblMateriaM);
            this.groupBox2.Controls.Add(this.cbxNombreEstudianteM);
            this.groupBox2.Controls.Add(this.lblNombreEstudianteM);
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matricular estudiante";
            // 
            // lblNombreEstudianteM
            // 
            this.lblNombreEstudianteM.AutoSize = true;
            this.lblNombreEstudianteM.Location = new System.Drawing.Point(9, 34);
            this.lblNombreEstudianteM.Name = "lblNombreEstudianteM";
            this.lblNombreEstudianteM.Size = new System.Drawing.Size(161, 20);
            this.lblNombreEstudianteM.TabIndex = 0;
            this.lblNombreEstudianteM.Text = "Nombre de estudiante:";
            // 
            // cbxNombreEstudianteM
            // 
            this.cbxNombreEstudianteM.FormattingEnabled = true;
            this.cbxNombreEstudianteM.Location = new System.Drawing.Point(176, 26);
            this.cbxNombreEstudianteM.Name = "cbxNombreEstudianteM";
            this.cbxNombreEstudianteM.Size = new System.Drawing.Size(183, 28);
            this.cbxNombreEstudianteM.TabIndex = 1;
            // 
            // lblMateriaM
            // 
            this.lblMateriaM.AutoSize = true;
            this.lblMateriaM.Location = new System.Drawing.Point(375, 34);
            this.lblMateriaM.Name = "lblMateriaM";
            this.lblMateriaM.Size = new System.Drawing.Size(63, 20);
            this.lblMateriaM.TabIndex = 2;
            this.lblMateriaM.Text = "Materia:";
            // 
            // cbxMateriaM
            // 
            this.cbxMateriaM.FormattingEnabled = true;
            this.cbxMateriaM.Location = new System.Drawing.Point(444, 26);
            this.cbxMateriaM.Name = "cbxMateriaM";
            this.cbxMateriaM.Size = new System.Drawing.Size(310, 28);
            this.cbxMateriaM.TabIndex = 3;
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(19, 69);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(182, 40);
            this.btnMatricular.TabIndex = 4;
            this.btnMatricular.Text = "Matricular estudiante";
            this.btnMatricular.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 451);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(773, 132);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.Text = "dataGridView2";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(691, 602);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 70);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(797, 684);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula de estudiantes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxMateriaA;
        private System.Windows.Forms.Label lblNombreMateriaA;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.ComboBox cbxMateriaM;
        private System.Windows.Forms.Label lblMateriaM;
        private System.Windows.Forms.ComboBox cbxNombreEstudianteM;
        private System.Windows.Forms.Label lblNombreEstudianteM;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSalir;
    }
}