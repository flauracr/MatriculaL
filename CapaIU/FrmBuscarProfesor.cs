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
    public partial class FrmBuscarProfesor : Form
    {
        //crear evento
        public event EventHandler Aceptar;
        int id = 0;
        public FrmBuscarProfesor()
        {
            InitializeComponent();
        }

        private void CargarLista(string condicion = "")
        {
            ProfesorLN logica = new ProfesorLN(clsConfiguracion.getconnectionString);
            DataSet DS;
            try
            {
                DS = logica.ListarRegistros(condicion);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    grdLista2P.DataSource = DS;
                    grdLista2P.DataMember = DS.Tables[0].TableName;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void FrmBuscarProfesor_Load(object sender, EventArgs e)
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
                if (grdLista2P.SelectedRows.Count > 0)
                {
                    id = (int)grdLista2P.SelectedRows[0].Cells[0].Value;
                    Aceptar(id, null);
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void grdLista2P_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelarP_Click(object sender, EventArgs e)
        {
            id = -1;
            Aceptar(id, null);
            Close();
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            string condicion;
            try
            {
                if (!string.IsNullOrEmpty(txtNombreProfesor.Text))
                {
                    condicion = string.Format("Nombre_profesor like '%{0}%'", txtNombreProfesor.Text.Trim());
                    CargarLista(condicion);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptarP_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }
    }//clase
}//namespace
