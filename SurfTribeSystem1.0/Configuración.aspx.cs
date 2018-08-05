using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class Configuración : System.Web.UI.Page
    {
        
        Usuario usu2 = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_PreInit(object sender, EventArgs e)
        {

            if (Session["InicioSesion"] != null)
            {
                usu2 = (Usuario)Session["InicioSesion"];

                switch (usu2.Tipo_usu)
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

        }
    }
}