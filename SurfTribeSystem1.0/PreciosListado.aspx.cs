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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtenerListado();
                ListarEscuelas();
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
                precio.Tag = "LISTADO";
                resultado = new PrecioLogica().Acciones(precio);
                if (resultado.TipoResultado == "OK")
                {
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

        private void ListarEscuelas()
        {
            Resultado resultado = new Resultado();
            try
            {
                List<Escuela> lista = new List<Escuela>();

                Escuela esc = new Escuela();

                esc.Tag = "LISTA_PRINCIPAL";
                resultado = new EscuelaLogica().Acciones(esc);

                lista = (List<Escuela>)resultado.ObjetoResultado;
                lista.Add(new Escuela { Nombre = "Seleccione una escuela", Id = "Seleccione una escuela" });

                ddlEscuela.DataSource = lista;
                ddlEscuela.DataTextField = "NOMBRE";
                ddlEscuela.DataValueField = "ID";
                ddlEscuela.DataBind();

                ddlEscuela.SelectedValue = "Seleccione una escuela";

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void Seleccionar(object sender, EventArgs e)
        {
            precio.IdEscuela = ddlEscuela.SelectedValue;
            ObtenerListado();
        }
    }
}