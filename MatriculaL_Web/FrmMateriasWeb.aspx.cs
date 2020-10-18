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
    public partial class FrmMaterias : System.Web.UI.Page
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
                //trhrow
                script = string.Format("javascrip:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
            }
        }

        protected void grdListaM_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdListaM.PageIndex = e.NewPageIndex;
            CargarLista();
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
                    grdListaM.DataSource = DS;
                    grdListaM.DataMember = DS.Tables[0].TableName;
                    grdListaM.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = string.Format("Nombre_materia like '%{0}%'", txtnombreM.Text);
                CargarLista(condicion);
            }
            catch (Exception ex)
            {
                //trhrow
                script = string.Format("javascrip:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMateriasWeb.aspx");
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Session.Remove("id_materia");
            Response.Redirect("FrmMateriasWebNuevo.aspx");
        }

        protected void linkModificar_Command(object sender, CommandEventArgs e)
        {
            Session["id_materia"] = e.CommandArgument.ToString();
            Response.Redirect("FrmMateriasWebNuevo.aspx");
        }

        protected void lnkEliminar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            MateriasLN logica = new MateriasLN(clsConfiguracion.getconnectionString);
            EntidadMaterias materias;
            string condicion;

            try
            {
                condicion = string.Format("ID_MATERIA={0}", id);
                materias = logica.ObtenerMateria(condicion);
                if (materias.ExisteRegistro)
                {
                    if (logica.Eliminar(materias) > 0)
                    {
                        //mensaje
                        //script = string.Format("javascrip:mostrarMensaje('{0}')", ex.Message);
                        //ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
                        CargarLista();
                        txtnombreM.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                //trhrow
                script = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
            }
        }
    }//clase
}//namespace