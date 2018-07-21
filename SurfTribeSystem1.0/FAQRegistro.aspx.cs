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
    public partial class FAQRegistro : System.Web.UI.Page
    {
        Faq faq = new Faq();
        Usuario usu = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null)
            {
                usu = (Usuario)Session["InicioSesion"];

                if (usu.Tipo_usu != "ADMG")
                {
                    Response.Redirect("defaultSinLogeoUN.aspx");
                }
            }
            else
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }
            if (!IsPostBack)
            {
                preguntaText.Text = Request.QueryString["valor1"];
                respuestaText.Text = Request.QueryString["valor2"];
            }
                
            
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {

                faq.Tag = "INSER_ACTUA";
                if (preguntaText.Text=="")
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '*Debe ingresar una pregunta', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    return;
                }
                if (respuestaText.Text == "")
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '*Debe ingresar una respuesta a la pregunta', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    return;
                }
                faq.Pregunta = preguntaText.Text;
                faq.Respuesta = respuestaText.Text;

                faq.Pregunta = faq.Pregunta.Replace('¿', ' ');
                faq.Pregunta = faq.Pregunta.Replace('?', ' ');

                resultado = new FaqLogica().Acciones(faq);
                if (resultado.TipoResultado == "OK")
                {
                    string script = "swal('Excelente', 'Se registró la pregunta con éxito', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
                 else
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }
    }
}