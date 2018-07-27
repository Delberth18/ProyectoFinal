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
    public partial class registroUsuario : System.Web.UI.Page
    {
        List<Escuela> escuelas = new List<Escuela>();
        List<TipoUsuario> tipos = new List<TipoUsuario>();
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
                ListadoEscuela();
                ListadoTipos();
            }
        }

        private void ListadoEscuela()
        {
            Resultado resultado = new Resultado();
            Escuela escuela = new Escuela();
            try
            {
                escuela.Tag = "LISTA_PRINCIPAL";
                resultado = new EscuelaLogica().Acciones(escuela);

                if (resultado.TipoResultado == "OK")
                {
                    escuelas = (List<Escuela>)resultado.ObjetoResultado;
                    escuelasList.DataSource = escuelas;
                    escuelasList.DataTextField = "Nombre";
                    escuelasList.DataValueField = "Id";
                    escuelasList.DataBind();
                }
                else
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void ListadoTipos()
        {
            Resultado resultado = new Resultado();
            TipoUsuario tipo = new TipoUsuario();
            try
            {
                tipo.Tag = "LISTADO";
                resultado = new TipoUsuarioLogica().Acciones(tipo);

                if (resultado.TipoResultado == "OK")
                {
                    tipos = (List<TipoUsuario>)resultado.ObjetoResultado;
                    tipoUsuList.DataSource = tipos;
                    tipoUsuList.DataTextField = "Descripcion";
                    tipoUsuList.DataValueField = "Id";
                    tipoUsuList.DataBind();
                }
                else
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNombre.Text.Length <= 2)
            {
                string script = "swal('Error', 'Debe ingresar un nombre real', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtNombre.Focus();
                return;
            }
            if (txtApellidos.Text == "" || txtApellidos.Text.Length <= 2)
            {
                string script = "swal('Error', 'Debe ingresar un apellido real', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtApellidos.Focus();
                return;
            }
            if (txtCorreo.Text == "")
            {
                string script = "swal('Error', 'Debe ingresar su correo', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtCorreo.Focus();
                return;
            }
            if (txtTelefono.Text == "" || txtTelefono.Text.Length < 8)
            {
                string script = "swal('Error', 'Debe ingresar un numero de teléfono existente', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtNombre.Focus();
                return;
            }   

            if (txtContraseña.Text.Length <= 5)
            {
                string script = "swal('Error', 'La contraseña debe contener al menos 6 caracteres', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtContraseña.Focus();
                return;
            }
            
           

            Guardar();
        }

        private void Guardar()
        {
            Resultado resultado = new Resultado();
            try
            {
                usu.Tag = "INSERTAR";
                usu.Correo = txtCorreo.Text;
                usu.Nombre = txtNombre.Text;
                usu.Apellidos = txtApellidos.Text;
                usu.Telefono = txtTelefono.Text;
                usu.Clave = txtContraseña.Text;
                usu.IdEscuela = escuelasList.SelectedValue;
                usu.Tipo_usu = tipoUsuList.SelectedValue;
                usu.Pais = paisesList.SelectedValue;
                resultado = new UsuarioLogica().Acciones(usu);

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
            catch (Exception ex)
            {
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtContraseña.Text = "";
            txtNombre.Focus();
        }
    }
}