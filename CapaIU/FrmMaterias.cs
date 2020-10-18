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
    public partial class FrmMaterias : Form
    {
        EntidadMaterias EntidadRegistrada;
        FrmBuscarMateria buscar;
        public FrmMaterias()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            //limpiar los campos
              txtIdMateria.Text = string.Empty;
              txtCodMateria.Text = string.Empty;
              txtNombreMateria.Text = string.Empty;
              txtHorasTotales.Text = string.Empty;
              txtCodMateria.Focus();     
        }


        private EntidadMaterias GenerarEntidad()
        {
            //crear una entidad apartir de datos nuevos o de registros existentes
            EntidadMaterias materias;
            if (!string.IsNullOrEmpty(txtIdMateria.Text))
            {
                materias = EntidadRegistrada;
            }
            else
            {
                materias = new EntidadMaterias();
            }


            materias.CodMateria= txtCodMateria.Text;
            materias.NombreMatertia = txtNombreMateria.Text;
            materias.HorasTotales = Convert.ToInt32(txtHorasTotales.Text);

            return materias;
        }

        private void CargarLista(string condicion = "")
        {
            //usando un objeto list
            MateriasLN logica = new MateriasLN(clsConfiguracion.getconnectionString);
            List<EntidadMaterias> DS;
            try
            {
                DS = logica.ListarRegistros1(condicion);
                if (DS.Count > 0)
                {
                    grdListaM.DataSource = DS;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void CargarListaDataSet(string condicion = "")
        {
            MateriasLN logica = new MateriasLN(clsConfiguracion.getconnectionString);
            DataSet DS;
            try
            {
                DS = logica.ListarRegistros(condicion);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    grdListaM.DataSource = DS;
                    grdListaM.DataMember = DS.Tables[0].TableName;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarMateria(int id)
        {
            EntidadMaterias materias;
            MateriasLN logica = new MateriasLN(clsConfiguracion.getconnectionString);
            string condicion = string.Format("ID_MATERIA={0}", id);
            try
            {
                materias = logica.ObtenerMateria(condicion);
                if (materias.ExisteRegistro)
                {
                    txtIdMateria.Text = materias.IdMateria.ToString();
                    txtCodMateria.Text = materias.CodMateria;
                    txtNombreMateria.Text = materias.NombreMatertia;
                    txtHorasTotales.Text = materias.HorasTotales.ToString();
                    
                   
                    EntidadRegistrada = materias;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSalirM_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizarM_Click(object sender, EventArgs e)
        {
            MateriasLN logica = new MateriasLN(clsConfiguracion.getconnectionString);
            EntidadMaterias materias;
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtCodMateria.Text) &&
                    !string.IsNullOrEmpty(txtNombreMateria.Text) &&
                    !string.IsNullOrEmpty(txtHorasTotales.Text))
                    

                {
                    materias = GenerarEntidad();
                    if (materias.ExisteRegistro == false)
                    {
                        //si el cliente es nuevo
                        resultado = logica.Insertar(materias);
                    }
                    else
                    {
                        //si el cliente se va a modificar

                        resultado = logica.Modificar(materias);
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

        private void FrmMaterias_Load(object sender, EventArgs e)
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

        private void grdListaM_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)grdListaM.SelectedRows[0].Cells[0].Value;
                CargarMateria(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            MateriasLN logica = new MateriasLN(clsConfiguracion.getconnectionString);
            EntidadMaterias materias;
            string condicion;
            int resultado = -1;
            try
            {
                if (!string.IsNullOrEmpty(txtIdMateria.Text))
                {
                    condicion = string.Format("ID_MATERIA={0}", txtIdMateria.Text);
                    materias = logica.ObtenerMateria(condicion);
                    if (materias.ExisteRegistro)
                    {
                        //usando el SP de la bd
                        resultado = logica.Eliminar(materias.IdMateria);
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
                        MessageBox.Show("Materia no existe");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el materia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            buscar = new FrmBuscarMateria();
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
                    CargarMateria(id_seleccionado);
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

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }//clase
}//namespace
