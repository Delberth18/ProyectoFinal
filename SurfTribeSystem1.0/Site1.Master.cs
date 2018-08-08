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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarGuana();
            ListarLimon();
            ListarPuerto();
        }


        protected void ingresarButton_Click(object sender, EventArgs e)
        {
            login(correoText.Text, claveText.Text);
        }

        public void login(string correo,string clave)
        {
            Resultado resultado = new Resultado();
            try
            {
                Credencial credencial = new Credencial()
                {
                    ClaveUsuario = clave,
                    CorreoUsuario = correo
                };
                resultado = new SeguridadLogica().ValidarUsuario(credencial);

                if (resultado.TipoResultado == "OK")
                {


                    List<Usuario> usu2 = new List<Usuario>();

                    usu2 = (List<Usuario>)resultado.ObjetoResultado;


                    Session["InicioNombre"] = usu2[0].Nombre.ToString() + " " + usu2[0].Apellidos.ToString();

                    Session["InicioSesion"] = usu2[0];

                    String idUsu = usu2[0].Tipo_usu.ToString();

                    if (idUsu == "ADM")
                    {

                        Response.Redirect("defaultConLogeoUADE.aspx");

                    }
                    else if (idUsu == "ADMG")
                    {

                        Response.Redirect("defaultConLogeoUADM.aspx");

                    }
                    else
                    {

                        if (idUsu == "REG")
                        {

                            Response.Redirect("defaultConLogeoUN.aspx");

                        }


                    }
                }
                else
                {
                    lblError.Text = "Usuario no encontrado";
                    lblError.Visible = true;

                    string script = "swal('Error', '" + resultado.Mensaje + "', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Usuario no encontrado";
                lblError.Visible = true;
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }


        private void ListarGuana()
        {
            Resultado resultado = new Resultado();
            Escuela escuela = new Escuela();
            List<Escuela> lista = new List<Escuela>();
            try
            {
                escuela.Tag = "GUANACASTE";
                resultado = new EscuelaLogica().Acciones(escuela);
                if (resultado.TipoResultado == "OK")
                {
                    lista = new List<Escuela>();
                    lista = (List<Escuela>)resultado.ObjetoResultado;
                    GuanaRepeat.DataSource = lista;
                    GuanaRepeat.DataBind();

                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void ListarPuerto()
        {
            Resultado resultado = new Resultado();
            Escuela escuela = new Escuela();
            List<Escuela> lista = new List<Escuela>();
            try
            {
                escuela.Tag = "PUNTARENAS";
                resultado = new EscuelaLogica().Acciones(escuela);
                if (resultado.TipoResultado == "OK")
                {
                    lista = new List<Escuela>();
                    lista = (List<Escuela>)resultado.ObjetoResultado;
                   PuertoRepeat.DataSource = lista;
                    PuertoRepeat.DataBind();

                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void ListarLimon()
        {
            Resultado resultado = new Resultado();
            Escuela escuela = new Escuela();
            List<Escuela> lista = new List<Escuela>();
            try
            {
                escuela.Tag = "LIMON";
                resultado = new EscuelaLogica().Acciones(escuela);
                if (resultado.TipoResultado == "OK")
                {
                    lista = new List<Escuela>();
                    lista = (List<Escuela>)resultado.ObjetoResultado;
                   LimonRepeat.DataSource = lista;
                    LimonRepeat.DataBind();

                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }



    }
}