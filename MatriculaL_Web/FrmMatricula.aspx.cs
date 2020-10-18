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
    public partial class FrmMatricula : System.Web.UI.Page
    {

        string script = "";

        private bool Cargando { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                         
                    CargarComboEstudiante();
                    //CargarLista();
                }
            }
            catch (Exception ex)
            {
                //trhrow
                script = string.Format("javascrip:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", script, true);
            }

        }

        

        private void CargarComboEstudiante(string condicion = "")
        {

            EstudianteLN logica = new EstudianteLN(clsConfiguracion.getconnectionString);
            DataSet DS;
            try
            {
                DS = logica.ListarRegistros(condicion);
                if (DS.Tables[0].Rows.Count > 0)
                {

                    dlistEstudiantes.DataSource = DS;

                    dlistEstudiantes.DataValueField = "ID_ESTUDIANTE";
                    dlistEstudiantes.DataTextField = "NOMBRE_ESTUDIANTE";

                    dlistEstudiantes.DataBind();
                    dlistEstudiantes.Items.Insert(0, new ListItem("SELECCIONE UN ESTUDIANTE", String.Empty));
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        

        
        
        
    }//clse
}//namespace