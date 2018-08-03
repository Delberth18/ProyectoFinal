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
    public partial class FAQMantenimiento : System.Web.UI.Page
    {
        Faq faq = new Faq();
        List<Faq> faqs = new List<Faq>();
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
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.MasterPageFile = "~/Site3.master";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ObtenerListado();
        }

        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                faq.Tag = "LISTADO";
                resultado = new FaqLogica().Acciones(faq);
                if (resultado.TipoResultado == "OK")
                {
                    faqs = new List<Faq>();
                    faqs = (List<Faq>)resultado.ObjetoResultado;
                    preguntasLst.DataSource = faqs;
                    preguntasLst.DataBind();
                }
                else
                {
                    if (resultado.CodigoMensaje == "1")
                    {
                        string script = "swal('Lo sentimos,', '" + resultado.Mensaje + "', 'info'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                    else
                    {
                        string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }

                }
            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void editarBtn_Click(object sender, EventArgs e)
        {
            LinkButton link = new LinkButton();
            link = (LinkButton)sender;
            faq.Pregunta = link.CommandName;

            foreach (Faq item in faqs)
            {
                if (item.Pregunta == link.CommandName)
                {
                    faq.Respuesta = item.Respuesta;
                    break;
                }
            }
            Response.Redirect("FAQRegistro.aspx?valor1=" + faq.Pregunta + "&valor2=" + faq.Respuesta);

        }

        protected void borrarBtn_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {
                LinkButton link = new LinkButton();
                link = (LinkButton)sender;
                faq.Tag = "BORRAR";
                faq.Pregunta = link.CommandName;
                resultado = new FaqLogica().Acciones(faq);


                if (resultado.TipoResultado == "OK")
                {

                    string script = "swal('Excelente', 'Éxito en el borrado', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    preguntasLst.DataSource = null;
                    preguntasLst.DataBind();
                    ObtenerListado();
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