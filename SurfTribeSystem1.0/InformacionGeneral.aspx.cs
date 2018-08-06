using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class InformacionGeneral : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


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


        protected void Sesion_Click(object sender, EventArgs e)
        {

            Session["InicioSesion"] = null;

            Response.Redirect("defaultSinLogeoUN.aspx");

        }
    }
}