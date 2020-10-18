using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaLN;

namespace CapaIU
{
    public partial class FrmProfesor : Form
    {

        EntidadProfesor EntidadRegistrada;
        FrmBuscarProfesor encontrar;
        public FrmProfesor()
        {
            InitializeComponent();
        }

        //metodos
        private void Limpiar()
        {
            //metodo para limpiar
            txtId.Text = string.Empty;
            txtCedulaP.Text = string.Empty;
            txtNombreP.Text = string.Empty;
            txtApellido1P.Text = string.Empty;
            txtApellido2P.Text = string.Empty;
            txtTelefonoP.Text = string.Empty;
            txtCorreoP.Text = string.Empty;
            //txtFechaIngreso.Text = string.Empty;
            txtEstadoP.Text = string.Empty;
            txtCedulaP.Focus();
        }

        private EntidadProfesor GenerarEntidad()
        {
            //crear una entidad apartir de datos nuevos o de registros existentes
            EntidadProfesor profesor;
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                profesor = EntidadRegistrada;
            }
            else
            {
                profesor = new EntidadProfesor();
            }


            profesor.CedulaProfesor = txtCedulaP.Text;
            profesor.NombreProfesor = txtNombreP.Text;
            profesor.Apellido1Profesor = txtApellido1P.Text;
            profesor.Apellido2Profesor = txtApellido2P.Text;
            profesor.CorreoProfesor = txtCorreoP.Text;
            profesor.TelefonoProfesor = txtTelefonoP.Text;
            //estudiante.FechaIngreso = txtFechaIngreso.Text;
            profesor.EstadoProfesor = txtEstadoP.Text;

            return profesor;
        }


        private void CargarLista(string condicion = "")
        {
            //usando un objeto list
            ProfesorLN logica = new ProfesorLN(clsConfiguracion.getconnectionString);
            List<EntidadProfesor> DS;
            try
            {
                DS = logica.ListarRegistros1(condicion);
                if (DS.Count > 0)
                {
                    grdListaP.DataSource = DS;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void CargarListaDataSet(string condicion = "")
        {
            ProfesorLN logica = new ProfesorLN(clsConfiguracion.getconnectionString);
            DataSet DS;
            try
            {
                DS = logica.ListarRegistros(condicion);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    grdListaP.DataSource = DS;
                    grdListaP.DataMember = DS.Tables[0].TableName;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarProfesor(int id)
        {
            EntidadProfesor profesor;
            ProfesorLN logica = new ProfesorLN(clsConfiguracion.getconnectionString);
            string condicion = string.Format("ID_PROFESOR={0}", id);
            try
            {
                profesor = logica.ObtenerProfesor(condicion);
                if (profesor.ExisteRegistro)
                {
                    txtId.Text = profesor.Id.ToString();
                    txtCedulaP.Text = profesor.CedulaProfesor;
                    txtNombreP.Text = profesor.NombreProfesor;
                    txtApellido1P.Text = profesor.Apellido1Profesor;
                    txtApellido2P.Text = profesor.Apellido2Profesor;
                    txtTelefonoP.Text = profesor.TelefonoProfesor;
                    txtCorreoP.Text = profesor.CorreoProfesor;
                    //txtFechaIngreso.Text = estudiante.FechaIngreso;
                    txtEstadoP.Text = profesor.EstadoProfesor;
                    EntidadRegistrada = profesor;
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSalirP_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            ProfesorLN logica = new ProfesorLN(clsConfiguracion.getconnectionString);
            EntidadProfesor profesor;
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtCedulaP.Text) &&
                    !string.IsNullOrEmpty(txtNombreP.Text) &&
                    !string.IsNullOrEmpty(txtApellido1P.Text) &&
                    !string.IsNullOrEmpty(txtApellido2P.Text) &&
                    !string.IsNullOrEmpty(txtTelefonoP.Text) &&
                    !string.IsNullOrEmpty(txtCorreoP.Text))

                {
                    profesor = GenerarEntidad();
                    if (profesor.ExisteRegistro == false)
                    {
                        //si el profesor es nuevo
                        resultado = logica.Insertar(profesor);
                    }
                    else
                    {
                        //si el profesor se va a modificar

                        resultado = logica.Modificar(profesor);
                    }
                    if (resultado > 0)
                    {
                        Limpiar();
                        CargarLista();
                        MessageBox.Show("Operación realizada satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se puede realizar la operación, favor verifique los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLista();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdListaP_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)grdListaP.SelectedRows[0].Cells[0].Value;
                CargarProfesor(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            ProfesorLN logica = new ProfesorLN(clsConfiguracion.getconnectionString);
            EntidadProfesor profesor;
            string condicion;
            int resultado = -1;
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    condicion = string.Format("ID_PROFESOR={0}", txtId.Text);
                    profesor = logica.ObtenerProfesor(condicion);
                    if (profesor.ExisteRegistro)
                    {
                        //usando el SP de la bd
                        resultado = logica.Eliminar(profesor.Id);
                        if (resultado > 0)
                        {
                            MessageBox.Show(logica.Mensaje);
                            CargarLista();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(logica.Mensaje);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Profesor no existe");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el profesor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            encontrar = new FrmBuscarProfesor();
            encontrar.Aceptar += new EventHandler(Aceptar);
            encontrar.Show();
        }


        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int id_seleccionado = (int)id;
                if (id_seleccionado != -1)
                {
                    CargarProfesor(id_seleccionado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }//clase
}//namespace
