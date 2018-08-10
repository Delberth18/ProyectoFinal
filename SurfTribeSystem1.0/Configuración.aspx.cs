using SurfTribeSystem_Entidades;
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
    public partial class Configuración : System.Web.UI.Page
    {
        
        Usuario usu2 = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_PreInit(object sender, EventArgs e)
        {

            if (Session["InicioSesion"] != null)
            {
                usu2 = (Usuario)Session["InicioSesion"];

                switch (usu2.Tipo_usu)
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

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtContraPasa.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar su contraseña antigua";
                txtContraPasa.Focus();
                return;
            }
            if (txtContraNueva.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar su contraseña Nueva";
                txtContraNueva.Focus();
                return;
            }
            if (txtContraNConfirmar.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar su contraseña nueva para confirmar";
                txtContraNConfirmar.Focus();
                return;
            }
            if (txtContraPasa.Text.Length <= 5)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*La contraseña pasada debe contener al menos 6 caracteres";
                txtContraPasa.Focus();
                return;
            }
            if (txtContraNueva.Text.Length <= 5)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*La contraseña Nueva debe contener al menos 6 caracteres";
                txtContraNueva.Focus();
                return;
            }
            if (txtContraNConfirmar.Text.Length <= 5)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*La contraseña de confirmación debe contener al menos 6 caracteres";
                txtContraNConfirmar.Focus();
                return;
            }
            if (txtContraNConfirmar.Text!=txtContraNueva.Text)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*La contraseña nueva y la de confirmación deben de ser la misma";
                txtContraNueva.Focus();
                return;
            }
            if (valido(txtContraNConfirmar.Text) == false)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*La contraseña no debe de contener caracteres especiales";
                txtContraNConfirmar.Focus();
                return;
            }
            if (valido(txtContraNueva.Text) == false)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*La contraseña no debe de contener caracteres especiales";
                txtContraNueva.Focus();
                return;
            }
            if (valido(txtContraPasa.Text) == false)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*La contraseña no debe de contener caracteres especiales";
                txtContraPasa.Focus();
                return;
            }


            Usuario us = new Usuario();
            Resultado resultado = new Resultado();
            try
            {
                us.Clave = txtContraNueva.Text;
                us.Clave_antigua = txtContraPasa.Text;
                us.Correo = usu2.Correo;
                us.Tag = "CAMBIAR_CONTRASENA";

                
                resultado = new UsuarioLogica().Acciones(us);


                if (resultado.TipoResultado == "OK")
                {

                    string script = "swal('Excelente', 'Se cambio la contraseña con éxito ', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

                    txtContraNConfirmar.Text = "";
                    txtContraNueva.Text = "";
                    txtContraPasa.Text = "";
                    errorLabel.Visible = false;

                }
                else
                {
                    string script = "swal('Error', 'No se puede cambiar la contraseña', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {
                string script = "swal('Error', 'No se puede cambiar la contraseña', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
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