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
    public partial class FrmEstudiante : Form
    {
        EntidadEstudiante EntidadRegistrada;
        FrmBuscarEstudiante buscar;



        public FrmEstudiante()
        {
            InitializeComponent();
        }


        //metodos
        private void Limpiar()
        {
            //metodo para limpiar
            txtId.Text = string.Empty;
            txtCedulaE.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            txtCorreoE.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreoE.Text = string.Empty;
            //txtFechaIngreso.Text = string.Empty;
            //txtEstado.Text = string.Empty;
            txtCedulaE.Focus();
        }


        private EntidadEstudiante GenerarEntidad()
        {
            //crear una entidad apartir de datos nuevos o de registros existentes
            EntidadEstudiante estudiante;
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                estudiante = EntidadRegistrada;
            }
            else
            {
                estudiante = new EntidadEstudiante();
            }

            
            estudiante.CedulaEstudiante = txtCedulaE.Text;
            estudiante.NombreEstudiante= txtNombre.Text;
            estudiante.Apellido1Estudiante = txtApellido1.Text;
            estudiante.Apellido2Estudiante = txtApellido2.Text;
            estudiante.CorreoEstudiante = txtCorreoE.Text;
            estudiante.TelefonoEstudiante = txtTelefono.Text;
            //estudiante.FechaIngreso = txtFechaIngreso.Text;
            //estudiante.EstadoEstudiante = txtEstado.Text;

            return estudiante;
        }

        private void CargarLista(string condicion = "")
        {
            //usando un objeto list
            EstudianteLN logica = new EstudianteLN(clsConfiguracion.getconnectionString);
            List<EntidadEstudiante> DS;
            try
            {
                DS = logica.ListarRegistros1(condicion);
                if (DS.Count > 0)
                {
                    grdLista.DataSource = DS;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarListaDataSet(string condicion = "")
        {
            EstudianteLN logica = new EstudianteLN(clsConfiguracion.getconnectionString);
            DataSet DS;
            try
            {
                DS = logica.ListarRegistros(condicion);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    grdLista.DataSource = DS;
                    grdLista.DataMember = DS.Tables[0].TableName;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarEstudiante(int id)
        {
            EntidadEstudiante estudiante;
            EstudianteLN logica = new EstudianteLN(clsConfiguracion.getconnectionString);
            string condicion = string.Format("ID_ESTUDIANTE={0}", id);
            try
            {
                estudiante = logica.ObtenerEstudiante(condicion);
                if (estudiante.ExisteRegistro)
                {
                    txtId.Text = estudiante.Id.ToString();
                    txtCedulaE.Text= estudiante.CedulaEstudiante;
                    txtNombre.Text = estudiante.NombreEstudiante;
                    txtApellido1.Text = estudiante.Apellido1Estudiante;
                    txtApellido2.Text = estudiante.Apellido2Estudiante;
                    txtTelefono.Text = estudiante.TelefonoEstudiante;
                    txtCorreoE.Text = estudiante.CorreoEstudiante;
                    //txtFechaIngreso.Text = estudiante.FechaIngreso;
                    txtEstado.Text = estudiante.EstadoEstudiante;
                    EntidadRegistrada = estudiante;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EstudianteLN logica = new EstudianteLN(clsConfiguracion.getconnectionString);
            EntidadEstudiante estudiante;
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtCedulaE.Text) &&
                    !string.IsNullOrEmpty(txtNombre.Text) &&
                    !string.IsNullOrEmpty(txtApellido1.Text) &&
                    !string.IsNullOrEmpty(txtApellido2.Text) &&
                    !string.IsNullOrEmpty(txtTelefono.Text)&&
                    !string.IsNullOrEmpty(txtCorreoE.Text))
                    
                {
                    estudiante = GenerarEntidad();
                    if (estudiante.ExisteRegistro == false)
                    {
                        //si el cliente es nuevo
                        resultado = logica.Insertar(estudiante);
                    }
                    else
                    {
                        //si el cliente se va a modificar

                        resultado = logica.Modificar(estudiante);
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

        private void FrmEstudiante_Load(object sender, EventArgs e)
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

        private void grdLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)grdLista.SelectedRows[0].Cells[0].Value;
                CargarEstudiante(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EstudianteLN logica = new EstudianteLN(clsConfiguracion.getconnectionString);
            EntidadEstudiante estudiante;
            string condicion;
            int resultado = -1;
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    condicion = string.Format("ID_ESTUDIANTE={0}", txtId.Text);
                    estudiante = logica.ObtenerEstudiante(condicion);
                    if (estudiante.ExisteRegistro)
                    {
                        //usando el SP de la bd
                        resultado = logica.Eliminar(estudiante.Id);
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
                        MessageBox.Show("Estudiante no existe");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el estudiante");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar = new FrmBuscarEstudiante();
            buscar.Aceptar += new EventHandler(Aceptar);
            buscar.Show();
        }

        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int id_seleccionado = (int)id;
                if (id_seleccionado != -1)
                {
                    CargarEstudiante(id_seleccionado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
