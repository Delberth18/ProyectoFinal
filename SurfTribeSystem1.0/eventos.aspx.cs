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
        Usuario usu = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            ObtenerListado();
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {

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