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
	public partial class PreciosListado : System.Web.UI.Page
	{
        Precio precio = new Precio();
        List<Precio> faqs = new List<Precio>();

        protected void Page_Load(object sender, EventArgs e)
		{
            ObtenerListado();
        }

        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                precio.Tag = "LISTADO";
                resultado = new PrecioLogica().Acciones(precio);
                if (resultado.TipoResultado == "OK")
                {
                    faqs = (List<Precio>)resultado.ObjetoResultado;
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