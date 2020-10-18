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
    public partial class FrmBuscarMateria : Form
    {

        //crear evento
        public event EventHandler Aceptar;
        int id = 0;
        public FrmBuscarMateria()
        {
            InitializeComponent();
        }


        private void CargarLista(string condicion = "")
        {
            MateriasLN logica = new MateriasLN(clsConfiguracion.getconnectionString);
            DataSet DS;
            try
            {
                DS = logica.ListarRegistros(condicion);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    grdLista2BM.DataSource = DS;
                    grdLista2BM.DataMember = DS.Tables[0].TableName;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmBuscarMateria_Load(object sender, EventArgs e)
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
                if (grdLista2BM.SelectedRows.Count > 0)
                {
                    id = (int)grdLista2BM.SelectedRows[0].Cells[0].Value;
                    Aceptar(id, null);
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void grdLista2BM_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnAceptarBM_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelarBM_Click(object sender, EventArgs e)
        {
            id = -1;
            Aceptar(id, null);
            Close();
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            string condicion;
            try
            {
                if (!string.IsNullOrEmpty(txtNombreMateriaBuscar.Text))
                {
                    condicion = string.Format("Nombre_materia like '%{0}%'", txtNombreMateriaBuscar.Text.Trim());
                    CargarLista(condicion);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }//clase
}//namespace
