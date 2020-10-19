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
    public partial class FrmProfesorWeb : System.Web.UI.Page
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
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                script = string.Format("javascrip:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
            }
        }

        protected void grdListaP_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdListaP.PageIndex = e.NewPageIndex;
            CargarLista();
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
                    grdListaP.DataSource = DS;
                    grdListaP.DataMember = DS.Tables[0].TableName;
                    grdListaP.DataBind();
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
                string condicion = string.Format("Nombre_profesor like '%{0}%'", txtnombreP.Text);
                CargarLista(condicion);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                script = string.Format("javascrip:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Session.Remove("id_profesor");
            Response.Redirect("FrmProfesorWebNuevo.aspx");
        }

        protected void linkModificar_Command1(object sender, CommandEventArgs e)
        {
            
        }

        protected void linkModificar_Command(object sender, CommandEventArgs e)
        {
            Session["id_profesor"] = e.CommandArgument.ToString();
            Response.Redirect("FrmProfesorWebNuevo.aspx");
        }

        protected void linkEliminar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            ProfesorLN logica = new ProfesorLN(clsConfiguracion.getconnectionString);
            EntidadProfesor profesor;
            string condicion;

            try
            {
                condicion = string.Format("ID_PROFESOR={0}", id);
                profesor = logica.ObtenerProfesor(condicion);
                if (profesor.ExisteRegistro)
                {
                    if (logica.Eliminar(profesor) > 0)
                    {
                        //mensaje
                        //script = string.Format("javascrip:mostrarMensaje('{0}')", ex.Message);
                        //ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
                        CargarLista();
                        txtnombreP.Text = "";
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

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmProfesorWeb.aspx");
        }
    }//clase

}//namespace