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
    public partial class editarEscuela : System.Web.UI.Page
    {
        Escuela escuela = new Escuela();
        List<Escuela> esc = new List<Escuela>();
        protected void Page_Load(object sender, EventArgs e)
        {
            String id = Session["idEditar"].ToString();
            if (!IsPostBack)
            {
               // SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;");//delberth
               SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");//eduardo
                SqlDataAdapter sda = new SqlDataAdapter("select * from ESCUELA where ID='" + id + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataRow row = dt.Rows[0];
                txtCorreo.Text = Convert.ToString(row["CORREO"]);


                txtNombre.Text = Convert.ToString(row["NOMBRE"]);


                txtUbicacion.Text = Convert.ToString(row["UBICACION"]);


                txtTelefono1.Text = Convert.ToString(row["TELEFONO"]);


                txtTelefono2.Text = Convert.ToString(row["TELEFONO2"]);


                txtDescripcion.Text = Convert.ToString(row["DESCRIPCION"]);

                txtPlaya.Text = Convert.ToString(row["PLAYA_CONCURRIDA"]);

                txtAnio.Text = Convert.ToString(row["ANIO_FUNDACION"]);


                ddlActiva.SelectedValue = Convert.ToBoolean(row["ACTIVA"]).ToString();
                ddlZona.SelectedValue = Convert.ToString(row["ZONA"]);

                

            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("mantEscuelas.aspx");
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
            if (txtUbicacion.Text == "" || txtUbicacion.Text.Length < 2)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe ingresar la ubicación";
                txtUbicacion.Focus();
                return;
            }
            if (txtCorreo.Text=="")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Digite el correo de la escuela";
                txtCorreo.Focus();
                return;
            }
            if (txtDescripcion.Text == "" || txtDescripcion.Text.Length < 2)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe digitar una breve descripción";
                txtDescripcion.Focus();
                return;
            }
            if (txtPlaya.Text == "" || txtPlaya.Text.Length < 2)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe digitar el nombre de la playa";
                txtPlaya.Focus();
                return;
            }
            if (txtAnio.Text == "" || txtAnio.Text.Length < 2)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "*Debe digitar el año de fundación";
                txtAnio.Focus();
                return;
            }
            errorLabel.Visible = false;


            //Validaciones





                try
                {
                    //  SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");
                    //SqlDataAdapter sda = new SqlDataAdapter("UPDATE [dbo].[USUARIO] SET CLAVE = '" + txtClave.Text + "',NOMBRE = '" + txtNombre.Text + "',APELLIDOS ='" + txtApellidos.Text + "', TELEFONO ='" + txtNumero.Text + "' WHERE USUARIO.CORREO = '" + txtCorreo.Text + "'", con);
                    Resultado resultado = new Resultado();
                escuela.Id= Session["idEditar"].ToString();
                escuela.Tag = "INSER_ACTUA";
                    escuela.Nombre = txtNombre.Text;
                escuela.Ubicacion = txtUbicacion.Text;
                escuela.Telefono = txtTelefono1.Text;
                escuela.Telefono2 = txtTelefono2.Text;
                escuela.Anio_fundacion = txtAnio.Text;
                escuela.Playa_concurrida = txtPlaya.Text;
                escuela.Correo = txtCorreo.Text;
                escuela.Zona = ddlZona.SelectedValue;
                escuela.Descripcion = txtDescripcion.Text;
                escuela.Activa =Convert.ToBoolean( ddlActiva.SelectedValue);


                    resultado = new EscuelaLogica().Acciones(escuela);

                    if (resultado.TipoResultado == "OK")
                    {
                        Session["Exito"] = 1;
                        Response.Redirect("mantEscuelas.aspx");
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