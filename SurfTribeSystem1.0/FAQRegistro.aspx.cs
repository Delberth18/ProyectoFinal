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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {

                faq.Tag = "INSER_ACTUA";
                if (preguntaText.Text=="")
                {
                    errorLabel.Visible = true;
                    errorLabel.Text="*Debe ingresar una pregunta";
                    return;
                }
                if (respuestaText.Text == "")
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "*Debe ingresar una respuesta a la pregunta";
                    return;
                }
                faq.Pregunta = preguntaText.Text;
                faq.Respuesta = respuestaText.Text;

                resultado = new FaqLogica().Listado(faq);
                if (resultado.TipoResultado == "OK")
                {
                    errorLabel.Visible = false;
                    confirmaLabel.Visible = true;
                    confirmaLabel.Text = "Se registro la pregunta con éxito";
                }
                else
                {
                    Response.Write("< script > alert('Error: " + resultado.Mensaje + " \n Lo sentimos') </ script >");
                }
            }
            catch (Exception ex)
            {

                Response.Write("< script > alert('Error: " + ex + " \n Lo sentimos') </ script >");
            }
        }
    }
}