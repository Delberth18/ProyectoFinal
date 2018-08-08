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
    public partial class mantEventos : System.Web.UI.Page
    {
        Evento evento = new Evento();
        List<Evento> eventosList = new List<Evento>();
        Usuario usu = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null)
            {
                usu = (Usuario)Session["InicioSesion"];

                if (usu.Tipo_usu != "ADMG"&& usu.Tipo_usu != "ADM")
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

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null)
            {
                Usuario usu = (Usuario)Session["InicioSesion"];

                switch (usu.Tipo_usu)
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


        protected void eliminar_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {
                LinkButton link = new LinkButton();
                link = (LinkButton)sender;
                evento.Tag = "ELIMINAR";
                string datos = link.CommandName;
                evento.Id = Convert.ToInt32(datos);
                resultado = new EventoLogica().Acciones(evento);


                if (resultado.TipoResultado == "OK")
                {

                    string script = "swal('Excelente', 'Proceso exitoso', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    eventosLst.DataSource = null;
                    eventosLst.DataBind();
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