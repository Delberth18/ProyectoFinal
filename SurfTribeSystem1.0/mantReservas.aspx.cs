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
    public partial class mantReservas : System.Web.UI.Page
    {
        Reserva reserva = new Reserva();
        List<Reserva> reservas = new List<Reserva>();
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
                ObtenerListado();

            }
        }

        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                reserva.Tag = "LISTADO_PENDIENTE";
                resultado = new ReservaLogica().Acciones(reserva);
                if (resultado.TipoResultado == "OK")
                {
                    reservas = (List<Reserva>)resultado.ObjetoResultado;
                    reservasLst.DataSource = reservas;
                    reservasLst.DataBind();
                }
                else
                {
                    string script = "swal('Lo sentimos,', '" + resultado.Mensaje + "', 'info'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {
                string script = "swal('Lo sentimos,', '" + resultado.Mensaje + "', 'info'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void noConfirmarBtn_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {
                LinkButton link = new LinkButton();
                link = (LinkButton)sender;
                reserva.Tag = "NO_CONFIRMADA";
                string[] datos = link.CommandName.Split('-');
                reserva.IdSesion = datos[0];
                reserva.IdUsuario = datos[1];
                resultado = new ReservaLogica().Acciones(reserva);


                if (resultado.TipoResultado == "OK")
                {

                    string script = "swal('Excelente', 'Proceso exitoso', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    reservasLst.DataSource = null;
                    reservasLst.DataBind();
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

        protected void confirmarBtn_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {
                LinkButton link = new LinkButton();
                link = (LinkButton)sender;
                reserva.Tag = "CONFIRMADA";
                string[] datos = link.CommandName.Split('-');
                reserva.IdSesion = datos[0];
                reserva.IdUsuario = datos[1];
                resultado = new ReservaLogica().Acciones(reserva);


                if (resultado.TipoResultado == "OK")
                {

                    string script = "swal('Excelente', 'Proceso exitoso', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    reservasLst.DataSource = null;
                    reservasLst.DataBind();
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