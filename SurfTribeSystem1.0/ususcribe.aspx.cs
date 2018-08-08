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
    public partial class ususcribe : System.Web.UI.Page
    {
        Usuario usu = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null)
            {
                usu = (Usuario)Session["InicioSesion"];
                if (usu.Tipo_usu != "REG")
                {
                    Response.Redirect("defaultSinLogeoUN.aspx");
                }

            }
            else
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
                    case "REG":
                        this.MasterPageFile = "~/Site4.master";
                        break;
                }
            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new unsuscribeLogica().Acciones(usu.Correo, comentarioText.Text);
                if (resultado.TipoResultado == "OK")
                {
                    
                    Session["Desactivado"] = "DES";
                    Response.Redirect("defaultSinLogeoUN.aspx");
                }
                else
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }

            }
            catch (Exception)
            {
                string script = "swal('Lo sentimos, ha ocurrido un error', 'No podemos procesar su solicitud en este momento', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("defaultSinLogeoUN.aspx");
        }
    }
}