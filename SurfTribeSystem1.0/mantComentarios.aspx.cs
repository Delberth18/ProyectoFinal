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
    public partial class mantComentarios : System.Web.UI.Page
    {

        Comentario comentario = new Comentario();
        List<Comentario> comentarios = new List<Comentario>();
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
            ObtenerListado();
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {

            this.MasterPageFile = "~/Site3.master";
        }

        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                comentario.Tag = "LISTADO_PENDIENTE";
                resultado = new ComentarioLogica().Acciones(comentario);
                if (resultado.TipoResultado == "OK")
                {
                    comentarios = (List<Comentario>)resultado.ObjetoResultado;
                    preguntasLst.DataSource = comentarios;
                    preguntasLst.DataBind();
                    cantidadLabel.Text = "(" + comentarios.Count + ")";
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

        protected void aceptar_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {
                LinkButton link = new LinkButton();
                link = (LinkButton)sender;
                comentario.Tag = "APROBADO";
                comentario.Id = link.CommandName;
                resultado = new ComentarioLogica().Acciones(comentario);


                if (resultado.TipoResultado == "OK")
                {

                    string script = "swal('Excelente', 'Aceptado con éxito', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    preguntasLst.DataSource = null;
                    preguntasLst.DataBind();
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

        protected void rechazar_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {
                LinkButton link = new LinkButton();
                link = (LinkButton)sender;
                comentario.Tag = "ELIMINAR";
                comentario.Id = link.CommandName;
                resultado = new ComentarioLogica().Acciones(comentario);


                if (resultado.TipoResultado == "OK")
                {

                    string script = "swal('Excelente', 'Rechazo con éxito', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    preguntasLst.DataSource = null;
                    preguntasLst.DataBind();
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