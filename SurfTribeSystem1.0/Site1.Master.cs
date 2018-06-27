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


        public void ingresarButton_Click(String claveUsu, String correoUsu)
        {

            registrarse re = new registrarse();
            

            Resultado resultado = new Resultado();
            try
            {
                Credencial credencial = new Credencial()
                {
                    ClaveUsuario = claveUsu,
                    CorreoUsuario = correoUsu
                };
                resultado = new SeguridadLogica().ValidarUsuario(credencial);

                if (resultado.TipoResultado == "OK")
                {
                    Session["InicioSesion"] = 1;
                    Response.Redirect("defaultConLogeoUDM.aspx");
                }
                else
                {
                    string script = "swal('Error', 'usuario no encontrado', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {

                string script = "swal('Error', 'usuario no encontrado', 'error'); ";
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