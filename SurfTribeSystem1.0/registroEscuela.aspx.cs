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
    public partial class registroEscuela : System.Web.UI.Page
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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Escuela escuela = new Escuela();
            Resultado resultado = new Resultado();

            escuela.Id = txtNombre.Text.Trim().ToUpper();
            escuela.Nombre = txtNombre.Text;
            escuela.Ubicacion = txtUbicacion.Text;
            escuela.Zona = ddlZona.Text;
            escuela.Playa_concurrida = txtPlaya.Text;
            escuela.Descripcion = txtDescripcion.Text;
            escuela.Anio_fundacion = txtAnioFundacion.Text;
            escuela.Correo = txtCorreo.Text;
            escuela.Telefono = txtTelefono1.Text;
            escuela.Telefono2 = txtTelefono2.Text;
            escuela.Activa = true;
            escuela.Tag = "INSER_ACTUA";

            try
            {
                if (Validar())
                {
                    resultado = new EscuelaLogica().Acciones(escuela);

                    if (resultado.TipoResultado == "OK")
                    {
                        string script = "swal('Excelente', 'Éxito en la insersión, le recordamos que debe registrar imagenes también', 'success'); ";
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

        protected bool Validar()
        {
            if (txtNombre.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe ingresar el nombre ', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtNombre.Focus();
                return false;
            }
            if (txtUbicacion.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe ingresar la ubicación ', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtUbicacion.Focus();
                return false;
            }
            if (txtPlaya.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe ingresar la playa ', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtPlaya.Focus();
                return false;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe ingresar una pequeña descripción ', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtDescripcion.Focus();
                return false;
            }
            if (txtAnioFundacion.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe ingresar el año de fundación. Ej (2003)', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtAnioFundacion.Focus();
                return false;
            }
            else
            {
                try
                {
                    int num = 0;
                    num = Convert.ToInt32(txtAnioFundacion.Text);

                    if (num > DateTime.Now.Year)
                    {
                        string script = "swal('Error', ' Debe ingresar un año igual o menor al actual.', 'error'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        txtAnioFundacion.Focus();
                        return false;
                    }
                    else if (num < 1900)
                    {
                        string script = "swal('Error', ' Debe ingresar un año válido.', 'error'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        txtAnioFundacion.Focus();
                        return false;
                    }
                }
                catch (Exception)
                {

                    string script = "swal('Error', ' Debe ingresar un año de fundación válido. Ej (2003)', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    txtAnioFundacion.Focus();
                    return false;
                }
            }

            if (txtCorreo.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe ingresar el correo para ser contactado', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtCorreo.Focus();
                return false;
            }

            return true;
        }

        protected void Limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtUbicacion.Text = "";
            txtPlaya.Text = "";
            txtAnioFundacion.Text = "";
            txtCorreo.Text = "";
            txtTelefono1.Text = "";
            txtTelefono2.Text = "";

            txtNombre.Focus();
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Escuela esc = new Escuela();

            esc.Id = txtNombre.Text.Trim().ToUpper();
            esc.Tag = "VALIDA";

            Resultado resultado = new Resultado();
            try
            {
                resultado = new EscuelaLogica().Acciones(esc);

                if (resultado.TipoResultado == "ERROR")
                { 
                    string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    txtNombre.Focus();
                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }
    }
}