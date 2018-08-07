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
    public partial class reporteReserva : System.Web.UI.Page
    {
        Usuario usu = new Usuario();
        Reserva reserva = new Reserva();
        public static List<Reserva> listareserva = new List<Reserva>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null)
            {
                usu = (Usuario)Session["InicioSesion"];

                //if (usu.Tipo_usu != "ADM")
                //{
                //    Response.Redirect("defaultSinLogeoUN.aspx");
                //}
                ListarReservas();
            }
            else
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }

        }
        private void ListarReservas()
        {
            Resultado resultado = new Resultado();
            try
            {
                reserva.IdUsuario = usu.Correo;
                reserva.Tag = "ALQUILER";
                resultado = new ReporteReservaLogica().Acciones(reserva);

               
                listareserva = new List<Reserva>();
                listareserva = (List<Reserva>)resultado.ObjetoResultado;

  

                //
                reserva.Tag = "SINALQUILER";
                resultado = new ReporteReservaLogica().Acciones(reserva);

                List<Reserva> listareserva2 = new List<Reserva>();

                listareserva2 = (List<Reserva>)resultado.ObjetoResultado;

                foreach (Reserva re in listareserva2)
                {
                    listareserva.Add(re);
                }


                grvreportes.DataSource = listareserva;
                grvreportes.DataBind();

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

    }
}