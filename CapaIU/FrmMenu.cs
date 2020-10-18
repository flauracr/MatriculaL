using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaIU
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void mnuMEstudiante_Click(object sender, EventArgs e)
        {
            FrmEstudiante frm = new FrmEstudiante();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuMMaterias_Click(object sender, EventArgs e)
        {
            FrmMaterias frm = new FrmMaterias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuAcercade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Matrícula - Universidad J&M - Elaborado por Laura Fonseca Rojas");
        }

        private void mnuSalirA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuMProfesor_Click(object sender, EventArgs e)
        {
            FrmProfesor frm = new FrmProfesor();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
