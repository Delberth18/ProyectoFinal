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
        protected void Page_Load(object sender, EventArgs e)
        {
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
                string msn = mensajeText.Text +"\nMensaje enviado por escuela de surf: "+"nombre de la escuela"+ "\n Para más información puede escribir al correo: " + "aqui va el correo de la escuela" + "\n Telefono: " + "telefono1" + " " + "telefono2";
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
                usu.IdEscuela = "AVELLANAS";
                usu.Tag = "CORREOS";

                resultado = new UsuarioLogica().Acciones(usu);

                if (resultado.TipoResultado=="OK")
                {
                    correos = (List<string>)resultado.ObjetoResultado;
                }
                else
                {
                    string script = "swal('Lo sentimos', ' Ha sucedido un problema con la carga de dadatos ', 'info'); ";
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