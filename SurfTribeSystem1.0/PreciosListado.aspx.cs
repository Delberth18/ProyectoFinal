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
    public partial class PreciosListado : System.Web.UI.Page
    {
        Precio precio = new Precio();
        List<Precio> faqs = new List<Precio>();
        string esc;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["esc"] == null)
            {
                string script = "swal('Lo sentimos,', 'Debe seleccionar primeramente una escuela, para poder ver los comentarios', 'info'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

            }
            else
            {
                if (!IsPostBack)
                {
                    esc = Request.QueryString["esc"].ToString();
                    ObtenerListado();
                }
            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
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

        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                precio.IdEscuela = esc;
                precio.Tag = "LISTADO";
                resultado = new PrecioLogica().Acciones(precio);
                if (resultado.TipoResultado == "OK")
                {
                    tituloLabel.Text = "Precios de la escuela: " + esc;
                    info1.Text = "Le mostramos nuestros diferentes precios para las clases y alquiler de tablas. ";
                    faqs = (List<Precio>)resultado.ObjetoResultado;
                    preciosLst.DataSource = faqs;
                    preciosLst.DataBind();
                }
                else
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {

                string script = "swal('Lo sentimos, ha ocurrido un error', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        
        
    }
}