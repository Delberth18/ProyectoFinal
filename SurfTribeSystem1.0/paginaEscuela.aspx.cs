
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
    public partial class paginaEscuela : System.Web.UI.Page
    {
        string nombreEscuela = "";
        Escuela escuela = new Escuela();
        Usuario usu = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!IsPostBack)
                {
                    nombreEscuela = Request.QueryString["idEscuela"].ToString();
                    nombreEscuela = nombreEscuela.Trim().ToUpper();

                    MostrarBaner();
                    CargarGaleria();
                    CargarInfo();
                    CargarInfoSencilla();
                }
            }
            catch (Exception)
            {

                Response.Redirect("defaultSinLogeoUN.aspx");
            }

        }

        protected void Page_PreInit(object sender, EventArgs e)
        {

            if (Session["InicioSesion"] != null)
            {
                usu = (Usuario)Session["InicioSesion"];

                switch (usu.Tipo_usu)
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
            else
            {
                this.MasterPageFile = "~/Site1.master";
            }

        }

        private void CargarGaleria()
        {

            Resultado resultado = new Resultado();
            Imagen img = new Imagen();
            List<Imagen> lista = new List<Imagen>();
            try
            {
                img.Tag = "LISTADOESCUELA";
                img.Pertenece = "Galeria Escuela";
                img.Dueño = nombreEscuela;

                resultado = new ImagenLogica().Acciones(img);
                if (resultado.TipoResultado == "OK")
                {
                    lista = (List<Imagen>)resultado.ObjetoResultado;
                    galeria.DataSource = lista;
                    galeria.DataBind();
                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void MostrarBaner()
        {

            Resultado resultado = new Resultado();
            Imagen img = new Imagen();
            List<Imagen> lista = new List<Imagen>();
            try
            {
                img.Tag = "LISTADOESCUELA";
                img.Pertenece = "Baner Escuela";
                img.Dueño = nombreEscuela;

                resultado = new ImagenLogica().Acciones(img);
                if (resultado.TipoResultado == "OK")
                {
                    lista = (List<Imagen>)resultado.ObjetoResultado;
                    banerImg.DataSource = lista;
                    banerImg.DataBind();
                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void CargarInfo()
        {
            Resultado resultado = new Resultado();
            List<Escuela> lista = new List<Escuela>();
            try
            {
                escuela.Nombre = nombreEscuela;
                escuela.Tag = "LISTADO_POR_NOMBRE";

                resultado = new EscuelaLogica().Acciones(escuela);
                if (resultado.TipoResultado == "OK")
                {
                    linkComent.HRef = "ComentariosListado.aspx?esc=" + nombreEscuela;
                    linkPrecios.HRef = "PreciosListado.aspx?esc=" + nombreEscuela;
                    lista = (List<Escuela>)resultado.ObjetoResultado;
                    info.DataSource = lista;
                    info.DataBind();
                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void CargarInfoSencilla()
        {
            Resultado resultado = new Resultado();
            List<Escuela> lista = new List<Escuela>();
            try
            {
                escuela.Nombre = nombreEscuela;
                escuela.Tag = "LISTADO_SENCILLO_IMAGEN";

                resultado = new EscuelaLogica().Acciones(escuela);
                if (resultado.TipoResultado == "OK")
                {
                    lista = (List<Escuela>)resultado.ObjetoResultado;
                    infoSencilla.DataSource = lista;
                    infoSencilla.DataBind();
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