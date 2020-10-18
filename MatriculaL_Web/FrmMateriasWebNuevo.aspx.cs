using System;
using System.Collections.Generic;
using System.Linq;
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
    public partial class FrmMateriasWebNuevo : System.Web.UI.Page
    {
        string script;
        protected void Page_Load(object sender, EventArgs e)
        {
            EntidadMaterias materias;
            MateriasLN logica = new MateriasLN(clsConfiguracion.getconnectionString);
            string condicion;
            try
            {
                if (!Page.IsPostBack)
                {
                    if (Session["id_materia"] != null)
                    {
                        condicion = string.Format("ID_MATERIA={0}", Session["id_materia"].ToString());
                        materias = logica.ObtenerMateria(condicion);
                        if (materias.ExisteRegistro)
                        {
                            txtid.Text = materias.IdMateria.ToString();
                            txtCodigo.Text = materias.CodMateria;
                            txtMateria.Text = materias.NombreMatertia;
                            txtHorasT.Text = materias.HorasTotales.ToString();
                            
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
                Response.Redirect("FrmMateriasWeb.aspx");
                //throw;
            }
        }


        public void Limpiar()
        {
            txtid.Text = "-1";
            txtid.Text = "false";
            txtCodigo.Text = string.Empty;
            txtMateria.Text = string.Empty;
            txtHorasT.Text = string.Empty;
        }


        private EntidadMaterias GenerarEntidad()
        {
            EntidadMaterias materias = new EntidadMaterias();
            if (Session["id_materia"] != null)
            {
                materias.IdMateria = int.Parse(Session["id_materia"].ToString());
                materias.ExisteRegistro = true;
            }
            else
            {
                materias.IdMateria = -1;
                materias.ExisteRegistro = false;
            }

            materias.CodMateria = txtCodigo.Text;
            materias.NombreMatertia = txtMateria.Text;
            materias.HorasTotales = Convert.ToInt32(txtHorasT.Text);
            
            return materias;
        }
        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            EntidadMaterias materias;
            MateriasLN logica = new MateriasLN(clsConfiguracion.getconnectionString);
            int res;
            try
            {
                materias = GenerarEntidad();
                if (materias.ExisteRegistro)
                {
                    res = logica.Modificar(materias);
                }
                else
                {
                    res = logica.Insertar(materias);
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

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMateriasWeb.aspx");
        }
    }//clase
}//namespace