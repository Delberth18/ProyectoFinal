using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class registroEvento : System.Web.UI.Page
    {
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
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {

            this.MasterPageFile = "~/Site3.master";
        }

        private Boolean ValidarExtension(string sExtension)
        {
            Boolean verif = false;
            switch (sExtension)
            {
                case ".jpg":
                case ".JPG":
                case ".jpeg":
                case ".JPEG":
                case ".png":
                case ".PNG":
                case ".gif":
                case ".GIF":
                case ".bmp":
                case ".BMP":
                    verif = true;
                    break;
                default:
                    verif = false;
                    break;
            }
            return verif;
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

            if (dscText.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe ingresar la descripción del evento', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                dscText.Focus();
                return false;
            }
            return true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            Resultado resultado = new Resultado();

            string Extension = string.Empty;
            string Nombre = string.Empty;


            if (FileUpload.HasFile == false)
            {
                string script = "swal('Error', ' No puede faltar la imagen ', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                return;
            }

            Nombre = FileUpload.FileName;
            Extension = Path.GetExtension(Nombre);

            if (ValidarExtension(Extension))
            {
                evento.Descripcion = dscText.Text;
                evento.Titulo = tituloText.Text;

                string base64ImageRepresentation = Convert.ToBase64String(FileUpload.FileBytes);

                evento.Imagen = base64ImageRepresentation;
                evento.Tag = "INSERTAR";

            }
            else
            {
                string script = "swal('Error', ' El archivo no es de tipo imagen. ', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                return;
            }



            try
            {
                if (Validar())
                {
                    resultado = new EventoLogica().Acciones(evento);

                    if (resultado.TipoResultado == "OK")
                    {
                        string script = "swal('Excelente', 'Éxito en la insersión', 'success'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        Limpiar();
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

        protected void Limpiar()
        {
            tituloText.Text = "";
            dscText.Text = "";
            tituloText.Focus();
        }
    }
}