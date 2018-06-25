using System;
using SurfTribeSystem_LogicaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class reservaNivel : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["numero"] = 0;
            Session["asigando"] = 0;

            nombreUbicacíon.Text = Session["Ubicación"].ToString();
            string valor = Request.QueryString["escuela"].ToString();
            EncriptarLogica encry = new EncriptarLogica();
            nombreEscuela.Text= encry.Desencripta(valor);
            Session["escuela"] = nombreEscuela.Text;
        }

        protected void btnAvanzado_Click(object sender, EventArgs e)
        {
            Session["Nivel"] = "Avanzado";
            Response.Redirect("reservaHorario.aspx");

        }

        protected void btnIntermedio_Click(object sender, EventArgs e)
        {
            Session["Nivel"] = "Intermedio";
            Response.Redirect("reservaHorario.aspx");
        }

        protected void btnPrincipiante_Click(object sender, EventArgs e)
        {
            Session["Nivel"] = "Principiante";
            Response.Redirect("reservaHorario.aspx");
        }
    }
}