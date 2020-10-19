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
   
    public partial class FrmProfesorWebNuevo : System.Web.UI.Page
    {
        string script;
        protected void Page_Load(object sender, EventArgs e)
        {
            EntidadProfesor profesor;
            ProfesorLN logica = new ProfesorLN(clsConfiguracion.getconnectionString);
            string condicion;
            try
            {
                if (!Page.IsPostBack)
                {
                    if (Session["id_profesor"] != null)
                    {
                        condicion = string.Format("ID_PROFESOR={0}", Session["id_profesor"].ToString());
                        profesor = logica.ObtenerProfesor(condicion);
                        if (profesor.ExisteRegistro)
                        {
                            txtid.Text = profesor.Id.ToString();
                            txtCedula.Text = profesor.CedulaProfesor;
                            txtNombre.Text = profesor.NombreProfesor;
                            txtApellido1.Text = profesor.Apellido1Profesor;
                            txtApellido2.Text = profesor.Apellido2Profesor;
                            txtTelefono.Text = profesor.TelefonoProfesor;
                            txtCorreo.Text = profesor.CorreoProfesor;
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
                System.Diagnostics.Debug.WriteLine(ex.ToString());
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

        private EntidadProfesor GenerarEntidad()
        {
            EntidadProfesor profesor = new EntidadProfesor();
            if (Session["id_profesor"] != null)
            {
                profesor.Id = int.Parse(Session["id_profesor"].ToString());
                profesor.ExisteRegistro = true;
            }
            else
            {
                profesor.Id = -1;
                profesor.ExisteRegistro = false;
            }

            profesor.CedulaProfesor = txtCedula.Text;
            profesor.NombreProfesor = txtNombre.Text;
            profesor.Apellido1Profesor = txtApellido1.Text;
            profesor.Apellido2Profesor = txtApellido2.Text;
            profesor.TelefonoProfesor = txtTelefono.Text;
            profesor.CorreoProfesor = txtCorreo.Text;
            return profesor;
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            EntidadProfesor profesor;
            ProfesorLN logica = new ProfesorLN(clsConfiguracion.getconnectionString);
            int res;
            try
            {
                profesor = GenerarEntidad();
                if (profesor.ExisteRegistro)
                {
                    res = logica.Modificar(profesor);
                }
                else
                {
                    res = logica.Insertar(profesor);
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
                Response.Redirect("FrmProfesorWeb.aspx");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                script = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensjeRetorno", script, true);
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmProfesorWeb.aspx");
        }
    }//clase
}//namespace