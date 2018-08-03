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
    public partial class FAQlistado : System.Web.UI.Page
    {
        Faq faq = new Faq();
        List<Faq> faqs = new List<Faq>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ObtenerListado();
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            if (Session["InicioSesion"] != null)
            {
                usu = (Usuario)Session["InicioSesion"];

                switch (usu.Tipo_usu)
                {
                    case "ADM":
                        this.MasterPageFile = "~/Site2.master";
                        break;
                    case "ADMG":
                        this.MasterPageFile = "~/Site3.master";
                        break;
                    case "REG":
                        this.MasterPageFile = "~/Site4.master";
                        break;
                }
            }
            else
            {
                this.MasterPageFile = "~/Site1.master";
            }

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
                    faqs = (List<Faq>)resultado.ObjetoResultado;

                    preguntasLst.DataSource = faqs;
                    preguntasLst.DataBind();
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