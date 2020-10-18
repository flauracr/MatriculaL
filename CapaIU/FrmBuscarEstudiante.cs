using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaLN;


namespace CapaIU
{
    public partial class FrmBuscarEstudiante : Form
    {

        //crear evento
        public event EventHandler Aceptar;
        int id = 0;



        public FrmBuscarEstudiante()
        {
            InitializeComponent();
        }


        private void CargarLista(string condicion = "")
        {
            EstudianteLN logica = new EstudianteLN(clsConfiguracion.getconnectionString);
            DataSet DS;
            try
            {
                DS = logica.ListarRegistros(condicion);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    grdLista2.DataSource = DS;
                    grdLista2.DataMember = DS.Tables[0].TableName;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }



        private void FrmBuscarEstudiante_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLista();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Seleccionar()
        {
            try
            {
                if (grdLista2.SelectedRows.Count > 0)
                {
                    id = (int)grdLista2.SelectedRows[0].Cells[0].Value;
                    Aceptar(id, null);
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void grdLista_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            id = -1;
            Aceptar(id, null);
            Close();


        }

        private void btnBuscarEstu_Click(object sender, EventArgs e)
        {
            string condicion;
            try
            {
                if (!string.IsNullOrEmpty(txtNombreEB.Text))
                {
                    condicion = string.Format("Nombre_estudiante like '%{0}%'", txtNombreEB.Text.Trim());
                    CargarLista(condicion);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }
    }
}
