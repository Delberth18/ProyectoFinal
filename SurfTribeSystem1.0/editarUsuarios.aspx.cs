using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class editarUsu : System.Web.UI.Page
    {
        Usuario usuario = new Usuario();
        List<Usuario> usu = new List<Usuario>();
        Usuario usu2 = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null)
            {
                usu2 = (Usuario)Session["InicioSesion"];

                if (usu2.Tipo_usu != "ADMG")
                {
                    Response.Redirect("defaultSinLogeoUN.aspx");
                }
            }
            else
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }
            String correo = Session["idEditar"].ToString();
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;");//delberth
                //SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");//eduardo
                SqlDataAdapter sda = new SqlDataAdapter("select * from USUARIO where CORREO='" + correo + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataRow row = dt.Rows[0];
                txtCorreo.Text = Convert.ToString(row["CORREO"]);


                txtClave.Text = Convert.ToString(row["CLAVE"]);


                txtNombre.Text = Convert.ToString(row["NOMBRE"]);


                txtApellidos.Text = Convert.ToString(row["APELLIDOS"]);


                txtNumero.Text = Convert.ToString(row["TELEFONO"]);


                txtPaís.Text = Convert.ToString(row["PAIS"]);

                txtUsu.Text = Convert.ToString(row["ID_TIPO_USU"]);

                txtauxClave.Text= Convert.ToString(row["CLAVE"]);

            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("mantUsuarios.aspx");
        }

        protected void idGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtNombre.Text.Length < 2)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar un nombre ";
                txtNombre.Focus();
                return;
            }
            if (txtApellidos.Text == "" || txtApellidos.Text.Length < 2)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar los Apellidos";
                txtApellidos.Focus();
                return;
            }
            if (txtNumero.Text.Length > 8)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Digite un numero de télefono correcto";
                txtNumero.Focus();
                return;
            }
            if (txtPaís.Text == "" || txtPaís.Text.Length < 2)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe colocar un país correcto";
                txtPaís.Focus();
                return;
            }
           
            errorLabel.Visible = false;


            //Validaciones








            if (txtClave.Text != "")
            {

                try
                {
                    //  SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");
                    //SqlDataAdapter sda = new SqlDataAdapter("UPDATE [dbo].[USUARIO] SET CLAVE = '" + txtClave.Text + "',NOMBRE = '" + txtNombre.Text + "',APELLIDOS ='" + txtApellidos.Text + "', TELEFONO ='" + txtNumero.Text + "' WHERE USUARIO.CORREO = '" + txtCorreo.Text + "'", con);
                    Resultado resultado = new Resultado();
                    usuario.Tag = "ACTUALIZAR";
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellidos = txtApellidos.Text;
                    usuario.Correo = txtCorreo.Text;
                    usuario.Telefono = txtNumero.Text;
                    usuario.Clave = txtClave.Text;
                    usuario.Pais = txtPaís.Text;
                    usuario.Tipo_usu = txtUsu.Text;


                    resultado = new UsuarioLogica().Acciones(usuario);

                    if (resultado.TipoResultado == "OK")
                    {
                        Session["Exito"] = 1;
                        Response.Redirect("mantUsuarios.aspx");
                    }
                    else
                    {
                        if (resultado.CodigoMensaje == "1")
                        {
                            string script = "swal('Lo sentimos,', '" + resultado.Mensaje + "', 'info'); ";
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        }
                        else
                        {
                            string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        }

                    }



                }
                catch
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '*Debe ingresar una pregunta', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

                }

            }
            else {

                try
                {
                    //  SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");
                    //SqlDataAdapter sda = new SqlDataAdapter("UPDATE [dbo].[USUARIO] SET CLAVE = '" + txtClave.Text + "',NOMBRE = '" + txtNombre.Text + "',APELLIDOS ='" + txtApellidos.Text + "', TELEFONO ='" + txtNumero.Text + "' WHERE USUARIO.CORREO = '" + txtCorreo.Text + "'", con);
                    Resultado resultado = new Resultado();
                    usuario.Tag = "ACTUALIZAR";
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellidos = txtApellidos.Text;
                    usuario.Correo = txtCorreo.Text;
                    usuario.Telefono = txtNumero.Text;
                    usuario.Clave = txtauxClave.Text;
                    usuario.Pais = txtPaís.Text;
                    usuario.Tipo_usu = txtUsu.Text;


                    resultado = new UsuarioLogica().Acciones(usuario);

                    if (resultado.TipoResultado == "OK")
                    {
                        Session["Exito"] = 1;
                        Response.Redirect("mantUsuarios.aspx");
                    }
                    else
                    {
                        if (resultado.CodigoMensaje == "1")
                        {
                            string script = "swal('Lo sentimos,', '" + resultado.Mensaje + "', 'info'); ";
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        }
                        else
                        {
                            string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        }

                    }



                }
                catch
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '*Debe ingresar una pregunta', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

                }

                

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
               
                Resultado resultado = new Resultado();
                usuario.Tag = "BORRAR";
                usuario.Correo= txtCorreo.Text;

                resultado = new UsuarioLogica().Acciones(usuario);

                if (resultado.TipoResultado == "OK")
                {
                    Session["exiBorrar"] = 1;
                    Response.Redirect("mantUsuarios.aspx");
                }
                else
                {
                    if (resultado.CodigoMensaje == "1")
                    {
                        string script = "swal('Lo sentimos,', '" + resultado.Mensaje + "', 'info'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                    else
                    {
                        string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }

                }



            }
            catch
            {
                string script = "swal('Lo sentimos, ha ocurrido un error', 'No podemos procesar la información', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

            }
        }
    }
}