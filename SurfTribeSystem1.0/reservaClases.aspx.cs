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
    public partial class reservaClases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idReserva"] != null)
            {

                if (Session["idReserva"].ToString() != "")
                { 
                BajarCupo();
                Session["idReserva"] = "";

                }

            }

        }

        private void BajarCupo()
        {
            Sesion sesion = new Sesion();
            Resultado resultado = new Resultado();

            try
            {
                sesion.Id = Session["idReserva"].ToString();
                sesion.Tag = "DESELECCIONADA";

                resultado = new SesionLogica().Acciones(sesion);

                if (resultado.TipoResultado == "OK")
                {

                }
                else
                {
                    string script = "swal('Error', 'La reserva no se pudo realizar', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {

                string script = "swal('Error', 'La reserva no se pudo realizar', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

    }
}