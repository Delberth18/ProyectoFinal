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
    public partial class editarEvento : System.Web.UI.Page
    {
        Usuario usu = new Usuario();
        int id;

        Evento evento = new Evento();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null && Session["idEvento"] != null)
            {
                usu = (Usuario)Session["InicioSesion"];

                if (usu.Tipo_usu != "ADMG")
                {
                    Response.Redirect("defaultSinLogeoUN.aspx");
                    return;
                }
                id =Convert.ToInt32( Session["idEvento"]);
                if (!IsPostBack)
                {
                    CargarEvento();
                }
               
            }
            else
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.MasterPageFile = "~/Site3.master";
        }


        private void CargarEvento()
        {
            Resultado resultado = new Resultado();
            try
            {
                evento.Tag = "UNICO";
                evento.Id = id;
                resultado = new EventoLogica().Acciones(evento);
                if (resultado.TipoResultado == "OK")
                {
                    evento = (Evento)resultado.ObjetoResultado;
                    tituloText.Text = evento.Titulo;
                    dscText2.Text = evento.Descripcion;
                }
                else
                {
                    string script = "swal('Lo sentimos,', '" + resultado.Mensaje + "', 'info'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {
                string script = "swal('Lo sentimos,', '" + ex.Message + "', 'info'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Evento evento2 = new Evento();
            Resultado resultado = new Resultado();

            string Extension = string.Empty;
            string Nombre = string.Empty;

            evento2.Descripcion = dscText2.Text;
            evento2.Titulo = tituloText.Text;
            evento2.Id = id;
            evento2.Tag = "ACTUALIZAR";




            try
            {
                if (Validar())
                {
                    resultado = new EventoLogica().Acciones(evento2);

                    if (resultado.TipoResultado == "OK")
                    {
                        Session["exito"] = "ok";
                        Response.Redirect("mantEventos.aspx");
                    }
                    else
                    {
                        string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                }
            }
            catch (Exception ex)
            {
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected bool Validar()
        {
            if (tituloText.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe ingresar el título', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                tituloText.Focus();
                return false;
            }

            if (dscText2.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe ingresar la descripción del evento', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                dscText2.Focus();
                return false;
            }
            return true;
        }


    }

}