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
    public partial class ComentariosListado : System.Web.UI.Page
    {
        Comentario comentario = new Comentario();
        List<Comentario> comentarios = new List<Comentario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ObtenerListado();
        }

        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                comentario.Tag = "LISTADO_APROBADO";
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
                    Response.Write("< script > alert('Error: " + resultado.Mensaje + " \n Lo sentimos') </ script >");
                }
            }
            catch (Exception ex)
            {

                Response.Write("< script > alert('Error: " + ex + " \n Lo sentimos') </ script >");
            }
        }

        private void Guardar()
        {
            if (comentarioText.Text.Trim()=="")
            {
                string script = "swal('Lo sentimos, ha ocurrido un error', 'Debe ingresar algún comentario', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                return;
            }
            Resultado resultado = new Resultado();
            try
            {
                comentario.Tag = "GUARDAR";
                comentario.Comentariol = comentarioText.Text;
                comentario.Id_Usuario = "tavoval@live.com";//aqui debe ir el que esta logueado
                resultado = new ComentarioLogica().Acciones(comentario);
                if (resultado.TipoResultado == "OK")
                {
                    string script = "swal('Éxito', 'El comentario será revisado lo más pronto posible, para su aprobación', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
                else
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {

                string script = "swal('Lo sentimos, ha ocurrido un error', '', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}