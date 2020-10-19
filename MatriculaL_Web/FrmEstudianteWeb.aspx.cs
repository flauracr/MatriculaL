using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidadesWeb;
using CapaADWeb;
using CapaLNWeb;
using System.Data;


namespace MatriculaL_Web
{
    public partial class FrmEstudianteWeb : System.Web.UI.Page
    {
        string script = "";
        

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    CargarLista();
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                script = string.Format("javascrip:mostrarMensaje('{0}')",ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
            }
        }

        protected void grdLista_PageIndexChanged(object sender, EventArgs e)
        {
            
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
                    grdLista.DataSource = DS;
                    grdLista.DataMember = DS.Tables[0].TableName;
                    grdLista.DataBind();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                throw;
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = string.Format("Nombre_estudiante like '%{0}%'", txtnombre.Text);
                CargarLista(condicion);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                script = string.Format("javascrip:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
            }
        }

        protected void linkEliminar_Command(object sender, CommandEventArgs e)
        {
           
            int id = int.Parse(e.CommandArgument.ToString());
            EstudianteLN logica = new EstudianteLN(clsConfiguracion.getconnectionString);
            EntidadEstudiante estudiante;
            string condicion;

            try
            {
                condicion = string.Format("ID_ESTUDIANTE={0}", id);
                estudiante = logica.ObtenerEstudiante(condicion);
                if (estudiante.ExisteRegistro)   
                {
                    if (logica.Eliminar(estudiante)>0)
                    {
                        //mensaje
                        //script = string.Format("javascrip:mostrarMensaje('{0}')", ex.Message);
                        //ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
                        CargarLista();
                        txtnombre.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                script = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
            }

        }

        protected void grdLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdLista.PageIndex = e.NewPageIndex;
            CargarLista();
        }

        protected void linkModificar_Command(object sender, CommandEventArgs e)
        {
            
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Session.Remove("id_estudiante");
            Response.Redirect("FrmEstudianteWebNuevo.aspx");
        }

        protected void linkModificar_Command1(object sender, CommandEventArgs e)
        {
            Session["id_estudiante"] = e.CommandArgument.ToString();
            Response.Redirect("FrmEstudianteWebNuevo.aspx");
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmEstudianteWeb.aspx");
        }
    }//clase
}//namespace