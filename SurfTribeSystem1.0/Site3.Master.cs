using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class Site3 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Sesion_Click(object sender, EventArgs e)
        {

            Session["InicioSesion"] = null;

            Response.Redirect("defaultSinLogeoUN.aspx");

        }
    }
}