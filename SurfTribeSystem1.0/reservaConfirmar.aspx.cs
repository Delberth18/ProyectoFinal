using SurfTribeSystem_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class reservaConfirmar : System.Web.UI.Page
    {
        string idTablaRser = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            lblEscuela.Text = Session["escuela"].ToString();
            lblNivel.Text = Session["Nivel"].ToString();

            
            string valor = Request.QueryString["rseT"].ToString();
            int s = valor.Count();
            valor = valor.Substring(s-1, 1);

            idTablaRser = valor;
        }

     

        protected void btnOmitir_Click(object sender, EventArgs e)
        {
           

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("reservaIndumentaria.aspx");
        }
    }
}