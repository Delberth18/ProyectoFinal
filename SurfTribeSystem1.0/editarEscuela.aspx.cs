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
            String id = Session["idEditar"].ToString();
            if (!IsPostBack)
            {
                Resultado resultado = new Resultado();
                List<Escuela> lista = new List<Escuela>();

                Escuela esc = new Escuela();
                esc.Id = id;
                esc.Tag = "LISTADO_POR_ID";
                resultado = new EscuelaLogica().Acciones(esc);

                lista = (List<Escuela>)resultado.ObjetoResultado;
                esc = lista[0];
                
                txtCorreo.Text =esc.Correo;


                txtNombre.Text = esc.Nombre;


                txtUbicacion.Text = esc.Ubicacion;


                txtTelefono1.Text = esc.Telefono;


                txtTelefono2.Text = esc.Telefono2;


                txtDescripcion.Text = esc.Descripcion;

                txtPlaya.Text = esc.Playa_concurrida;

                txtAnio.Text = esc.Anio_fundacion;


                ddlActiva.SelectedValue = esc.Activa.ToString();
                ddlZona.SelectedValue = esc.Zona;



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
                string script = "swal('Error', '*Debe ingresar un nombre', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtNombre.Focus();
                return;
            }
            if (txtUbicacion.Text == "" || txtUbicacion.Text.Length < 2)
            {
                string script = "swal('Error', '*Debe ingresar la ubicación', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtUbicacion.Focus();
                return;
            }
            if (txtCorreo.Text == "")
            {
                string script = "swal('Error', '*Digite el correo de la escuela', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtCorreo.Focus();
                return;
            }
            if (txtDescripcion.Text == "" || txtDescripcion.Text.Length < 2)
            {
                string script = "swal('Error', '*Debe digitar una breve descripción', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtDescripcion.Focus();
                return;
            }
            if (txtPlaya.Text == "" || txtPlaya.Text.Length < 2)
            {
                string script = "swal('Error', '*Debe digitar el nombre de la playa', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtPlaya.Focus();
                return;
            }
            if (txtAnio.Text == "" || txtAnio.Text.Length < 2)
            {
                string script = "swal('Error', '*Debe digitar el año de fundación', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtAnio.Focus();
                return;
            }


            try
            {
                Resultado resultado = new Resultado();
                escuela.Id = Session["idEditar"].ToString();
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
                escuela.Activa = Convert.ToBoolean(ddlActiva.SelectedValue);


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