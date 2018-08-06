using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class ususcribe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (correoText.Text.Trim()=="")
            {
                string script = "swal('Error', 'Debe ingresar su correo', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                return;
            }

            Resultado resultado = new Resultado();
            try
            {
                resultado = new unsuscribeLogica().Acciones(correoText.Text, comentarioText.Text);
                if (resultado.TipoResultado == "OK")
                {
                    string script = "swal( 'Se ha realizado la desactivación satisfactoriamente.','', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    correoText.Text = "";
                    comentarioText.Text = "";
                   
                }
                else
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }

            }
            catch (Exception)
            {
                string script = "swal('Lo sentimos, ha ocurrido un error', 'No podemos procesar su solicitud en este momento', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("defaultSinLogeoUN.aspx");
        }
    }
}