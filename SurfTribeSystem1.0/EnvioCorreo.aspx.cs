using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaNegocio;
using SurfTribeSystem1._0.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class EnvioCorreo : System.Web.UI.Page
    {
        List<string> correos = new List<string>();
        Usuario usu2 = new Usuario();

        protected void Page_PreInit(object sender, EventArgs e)
        {

            if (Session["InicioSesion"] != null)
            {
                usu2 = (Usuario)Session["InicioSesion"];

                switch (usu2.Tipo_usu)
                {
                    case "ADM":
                        this.MasterPageFile = "~/Site2.master";
                        break;
                    case "ADMG":
                        this.MasterPageFile = "~/Site3.master";
                        break;
                }
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null)
            {
                usu2 = (Usuario)Session["InicioSesion"];

                if (usu2.Tipo_usu != "ADMG" && usu2.Tipo_usu != "ADM")
                {
                    Response.Redirect("defaultSinLogeoUN.aspx");
                }
            }
            else
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }
            ObtenerCorreos();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if(asuntoText.Text.Trim()=="" || mensajeText.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe digitar tanto el asunto como el mensaje correspondiente', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                return;
            }
            try
            {
                string from = "surftcr@gmail.com";
                string password = "tribe12345";
                string msn = "";

                if (usu2.Tipo_usu=="ADM")
                {
                    msn = mensajeText.Text + "\n\nMensaje enviado por escuela de surf: " + usu2.IdEscuela + "\n Para más información puede escribir al correo: " + "surftcr@gmail.com" ;
                }
                else
                {
                    msn = mensajeText.Text + "\n\nMensaje enviado desde la página Surf Tribe" ;
                }

                string subject = asuntoText.Text ;
                string to = "";
                foreach (string item in correos)
                {                    
                     to = item;

                    new Email().enviarCorreos(from, subject, password, to, msn);
                }
                string script = "swal('Éxito', 'EL correo se ha enviado a todos los usuarios', 'succes'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
            catch (Exception)
            {

                string script = "swal('Lo sentimos', ' Ha sucedido un problema con el envío del correo, algunos usuarios no lo recibirán', 'info'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void ObtenerCorreos()
        {
            Resultado resultado = new Resultado();
            Usuario usu = new Usuario();
            try
            {
                usu.IdEscuela = usu.IdEscuela;

                if (usu2.Tipo_usu=="ADM")
                {
                    usu.Tag = "CORREOS";
                }
                else
                {
                    usu.Tag = "CORREOS2";
                }
               

                resultado = new UsuarioLogica().Acciones(usu);

                if (resultado.TipoResultado=="OK")
                {
                    correos = (List<string>)resultado.ObjetoResultado;
                }
                else
                {
                    string script = "swal('Lo sentimos', ' Ha sucedido un problema con la carga de datos ', 'info'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {
                string script = "swal('Lo sentimos', ' Ha sucedido un problema con la carga de datos ', 'info'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }
    }
}