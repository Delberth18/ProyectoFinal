using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaDeNegocios;
using SurfTribeSystem_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class registrarse : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ingresarButton_Click(object sender, EventArgs e)
        {

            Resultado resultado = new Resultado();
            try
            {

               String ClaveUsuario = claveText.Text;
               String CorreoUsuario = correoText1.Text;

                Master.login(CorreoUsuario, ClaveUsuario);
               
               
            }
            catch (Exception ex)
            {
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }


        protected void registrar_Click(object sender, EventArgs e)
        {
            if (correoText.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar su correo";
                contrasenaText.Focus();
                return;
            }
            if (contrasenaText.Text=="")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar la contraseña";
                contrasenaText.Focus();
                return;
            }
            if (contrasenaText.Text.Length <=5)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*La contraseña debe contener al menos 6 caracteres";
                contrasenaText.Focus();
                return;
            }
            if (valido(contrasenaText.Text)==false)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*La contraseña no debe de contener caracteres especiales";
                contrasenaText.Focus();
                return;
            }
           
            if (confirmaContrasenaText.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe confirmar la contraseña";
                contrasenaText.Focus();
                return;
            }
            if (valido(confirmaContrasenaText.Text) == false)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*La contraseña no debe de contener caracteres especiales";
                contrasenaText.Focus();
                return;
            }
            if (!confirmaContrasenaText.Text.Equals(contrasenaText.Text))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Las contraseñas deben ser iguales";
                contrasenaText.Focus();
                return;
            }
            if (nombreText.Text == "" || nombreText.Text.Length <= 2)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar su nombre";
                nombreText.Focus();
                return;
            }
            if (apellidosText.Text == "" || apellidosText.Text.Length <= 2)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar sus apellidos";
                apellidosText.Focus();
                return;
            }
            if (telefonoText.Text == "" || telefonoText.Text.Length < 8)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar su número de teléfono";
                telefonoText.Focus();
                return;
            }
            if (chkboxLeido.Checked==false)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe Aceptar los términos y condiciones";
                telefonoText.Focus();
                return;
            }
            errorLabel.Visible = false; 

            Resultado resultado = new Resultado();
            try
            {
                Usuario usu = new Usuario()
                {
                    Correo = correoText.Text,
                    Clave = contrasenaText.Text,
                    Nombre = nombreText.Text,
                    Apellidos = apellidosText.Text,
                    Telefono = telefonoText.Text,
                    Pais = paisesList.SelectedValue,
                    Tipo_usu = "REG",
                    IdEscuela = ddlEscuela.SelectedValue.ToString(),
                    Tag="INSERTAR"
                };
                resultado = new UsuarioLogica().Acciones(usu);

                if (resultado.TipoResultado == "OK")
                {
                    confirmaLabel.Visible = true;
                    confirmaLabel.Text = "El registro se realizó con éxito";

                    Session["InicioSesion"] = usu;
                    Session["InicioNombre"] = nombreText.Text + " " + apellidosText.Text;

                    Response.Redirect("defaultConLogeoUN.aspx");
                }
                else
                {
                    string script = "swal('Error', 'Correo ya utilizado', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "ERROR" +ex;
            }
        }


        public bool valido(string cadena)
        {
            string formato = "^([a-zA-Z0-9]{4,16})$";

            Regex r = new Regex(formato);

            if (r.IsMatch(cadena))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}