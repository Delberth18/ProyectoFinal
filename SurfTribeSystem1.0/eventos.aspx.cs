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
    public partial class eventos : System.Web.UI.Page
    {
        Evento evento = new Evento();
        List<Evento> eventosList = new List<Evento>();

        protected void Page_Load(object sender, EventArgs e)
        {
            ObtenerListado();
        }

        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                evento.Tag = "LISTADO";
                resultado = new EventoLogica().Acciones(evento);
                if (resultado.TipoResultado == "OK")
                {
                    eventosList = (List<Evento>)resultado.ObjetoResultado;
                    eventosLst.DataSource = eventosList;
                    eventosLst.DataBind();
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
    }
}