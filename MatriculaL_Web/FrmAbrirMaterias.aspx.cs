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
    public partial class FrmAbrirMaterias : System.Web.UI.Page
    {

        string script = "";

        private bool Cargando { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    CargarComboMaterias();
                    CargarComboProfesor();
                    
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

        private void CargarComboMaterias(string condicion = "")
        {
            MateriasLN logica = new MateriasLN(clsConfiguracion.getconnectionString);
            DataSet DS;
            try
            {
                DS = logica.ListarRegistros(condicion);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    dlistMaterias.DataSource = DS;
                    dlistMaterias.DataValueField = "ID_MATERIA";
                    dlistMaterias.DataTextField = "NOMBRE_MATERIA";
                    dlistMaterias.DataBind();
                    dlistMaterias.Items.Insert(0, new ListItem("SELECCIONE UNA MATERIA", String.Empty));
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void CargarComboProfesor(string condicion = "")
        {

            ProfesorLN logica = new ProfesorLN(clsConfiguracion.getconnectionString);
            DataSet DS;
            try
            {
                DS = logica.ListarRegistros(condicion);
                if (DS.Tables[0].Rows.Count > 0)
                {

                    dlistProfesores.DataSource = DS;

                    dlistProfesores.DataValueField = "ID_PROFESOR";
                    dlistProfesores.DataTextField = "NOMBRE_PROFESOR";

                    dlistProfesores.DataBind();
                    dlistProfesores.Items.Insert(0, new ListItem("SELECCIONE UN PROFESOR", String.Empty));
                }
            }
            catch (Exception)
            {
                throw;
            }



        }

        protected void grdListaMA_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdListaMA.PageIndex = e.NewPageIndex;
            CargarLista();
        }


        private void CargarLista(string condicion = "")
        {
            MateriasAbiertasLN logica = new MateriasAbiertasLN(clsConfiguracion.getconnectionString);
            DataSet DS;
            try
            {
                DS = logica.ListarRegistros(condicion);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    grdListaMA.DataSource = DS.Tables[0];
                    grdListaMA.DataMember = DS.Tables[0].TableName;
                    grdListaMA.DataBind();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                throw;
            }
        }    

            private EstidadMateriaAbierta GenerarEntidad()
            {
                EstidadMateriaAbierta materiasA = new EstidadMateriaAbierta();
                if (Session["idMateriaAbierta"] != null)
                {
                    materiasA.IdMateriaAbierta = int.Parse(Session["idMateriaAbierta"].ToString());
                    materiasA.ExisteRegistro = true;
                }
                else
                {
                    materiasA.IdMateriaAbierta = -1;
                    materiasA.ExisteRegistro = false;
                }

                materiasA.IdMateria = Convert.ToInt32(dlistMaterias.SelectedValue);
                materiasA.CedulaProfesor = dlistProfesores.SelectedValue.ToString();


                return materiasA;
            }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            EstidadMateriaAbierta materiasA;
            MateriasAbiertasLN logica = new MateriasAbiertasLN(clsConfiguracion.getconnectionString);
            int res;
            try
            {
                materiasA = GenerarEntidad();
                if (materiasA.ExisteRegistro)
                {
                    res = logica.Modificar(materiasA);
                }
                else
                {
                    res = logica.Insertar(materiasA);
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
                Response.Redirect("FrmMateriasWeb.aspx");
            }
            catch (Exception ex)
            {
                script = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensjeRetorno", script, true);
            }
        }
    

    
    }//clase
}//namespace