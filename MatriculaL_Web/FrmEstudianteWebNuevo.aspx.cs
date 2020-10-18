using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidadesWeb;
using CapaLNWeb;
using System.Security.Cryptography.X509Certificates;

namespace MatriculaL_Web
{
    public partial class FrmEstudianteWebNuevo : System.Web.UI.Page
    {
        string script;
        protected void Page_Load(object sender, EventArgs e)
        {
            EntidadEstudiante estudiante;
            EstudianteLN logica = new EstudianteLN(clsConfiguracion.getconnectionString);
            string condicion;
            try
            {
                if (!Page.IsPostBack)
                {
                    if (Session["id_Estudiante"] != null)
                    {
                        condicion = string.Format("ID_ESTUDIANTE={0}", Session["id_estudiante"].ToString());
                        estudiante = logica.ObtenerEstudiante(condicion);
                        if (estudiante.ExisteRegistro)
                        {
                            txtid.Text = estudiante.Id.ToString();
                            txtCedula.Text = estudiante.CedulaEstudiante;
                            txtNombre.Text = estudiante.NombreEstudiante;
                            txtApellido1.Text = estudiante.Apellido1Estudiante;
                            txtApellido2.Text = estudiante.Apellido1Estudiante;
                            txtTelefono.Text = estudiante.TelefonoEstudiante;
                            txtCorreo.Text = estudiante.CorreoEstudiante;
                            //lblId.Visible = true; 
                            txtid.Visible = true;
                        }
                        else
                        {
                            script = string.Format("javascript:mostrarMensaje('El cliente no se encontró')");
                            ScriptManager.RegisterStartupScript(this, typeof(string), "MensjeRetorno", script, true);
                        }
                    }
                    else
                    {
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                script = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensjeRetorno", script, true);
                Response.Redirect("FrmEstudianteWeb.aspx");
                //throw;
            }


        }

        public void Limpiar()
        {

            txtid.Text = "-1";
            txtid.Text = "false";
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private EntidadEstudiante GenerarEntidad()
        {
            EntidadEstudiante estudiante = new EntidadEstudiante();
            if (Session["id_estudiante"] != null)
            {
                estudiante.Id = int.Parse(Session["id_estudiante"].ToString());
                estudiante.ExisteRegistro = true;
            }
            else
            {
                estudiante.Id = -1;
                estudiante.ExisteRegistro = false;
            }

            estudiante.CedulaEstudiante = txtCedula.Text;
            estudiante.NombreEstudiante = txtNombre.Text;
            estudiante.Apellido1Estudiante = txtApellido1.Text;
            estudiante.Apellido2Estudiante = txtApellido2.Text;
            estudiante.TelefonoEstudiante = txtTelefono.Text;
            estudiante.CorreoEstudiante = txtCorreo.Text;
            return estudiante;
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            EntidadEstudiante estudiante;
            EstudianteLN logica = new EstudianteLN(clsConfiguracion.getconnectionString);
            int res;
            try
            {
                estudiante = GenerarEntidad();
                if (estudiante.ExisteRegistro)
                {
                    res = logica.Modificar(estudiante);
                }
                else
                {
                    res = logica.Insertar(estudiante);
                }
                if (res > 0)
                {
                    script = string.Format("javascript:mostrarMensaje('Operacion realizada satisfactoriamente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensjeRetorno", script, true);
                }
                else
                {
                    script = string.Format("javascript:mostrarMensaje('No se pudo ejecutar la operacion')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensjeRetorno", script, true);
                }
                Response.Redirect("FrmEstudianteWeb.aspx");
            }
            catch (Exception ex)
            {
                script = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensjeRetorno", script, true);
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmEstudianteWeb.aspx");
        }
    }//clase
}//namespace