using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaNegocio;
using SurfTribeSystem1._0.Clases;
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
        Usuario usu = new Usuario();

        string esc;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["esc"] == null)
            {
                string script = "swal('Lo sentimos,', 'Debe seleccionar primeramente una escuela, para poder ver los comentarios', 'info'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                
            }
            else
            {
                if (!IsPostBack)
                {
                    esc = Request.QueryString["esc"].ToString();
                    if (esc!="null")
                    {
                        Session["esc"] = esc;
                    }
                    ObtenerListado();
                }
            }

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
                comentario.Tag = "LISTADO_APROBADO";
                comentario.Escuela = esc;
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

        private void Guardar()
        {
            if (Session["InicioSesion"] == null)
            {
                string script = "swal('Lo sentimos, ', 'Para poder dejar su comentario debe de estar logueado', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                return;
            }
            else
            {
                usu = (Usuario)Session["InicioSesion"];
            }
            if (comentarioText.Text.Trim() == "")
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
                comentario.Id_Usuario = usu.Correo;
                comentario.Escuela = Session["esc"].ToString();

                resultado = new ComentarioLogica().Acciones(comentario);
                if (resultado.TipoResultado == "OK")
                {
                    string script = "swal('Éxito', 'El comentario será revisado lo más pronto posible, para su aprobación', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

                    string from = "surftcr@gmail.com";
                    string password = "tribe12345";
                    string msn = "Han realizado un nuevo comentario";

                    string subject = "Nuevo Comentario";
                    string to = "surftcr@gmail.com";
                    List<string> correos = new List<string>();
                    correos.Add(to);
                    new Email().enviarCorreos(from, subject, password, correos, msn);
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