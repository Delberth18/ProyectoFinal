using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaDeNegocios;
using SurfTribeSystem_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
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

                Master.ingresarButton_Click(ClaveUsuario,CorreoUsuario);
               
               
            }
            catch (Exception ex)
            {

                Response.Write("< script > alert('Error: " + ex + " \n Lo sentimos') </ script >");
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
            if (confirmaContrasenaText.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe confirmar la contraseña";
                contrasenaText.Focus();
                return;
            }
            if (!confirmaContrasenaText.Text.Equals(contrasenaText.Text))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Las contraseñas deben ser igules";
                contrasenaText.Focus();
                return;
            }
            if (nombreText.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar su nombre";
                nombreText.Focus();
                return;
            }
            if (apellidosText.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar sus apellidos";
                apellidosText.Focus();
                return;
            }
            if (telefonoText.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar su número de teléfono";
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
                    Tag="INSERTAR"
                };
                resultado = new UsuarioLogica().Acciones(usu);

                if (resultado.TipoResultado == "OK")
                {
                    confirmaLabel.Visible = true;
                    confirmaLabel.Text = "El registro se realizó con éxito";
                }
                else
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "ERROR"+ resultado.Mensaje+" - "+resultado.CodigoMensaje;
                }
            }
            catch (Exception ex)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "ERROR" +ex;
            }
        }



    }
}