using System;
using SurfTribeSystem_LogicaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SurfTribeSystem_Entidades;

namespace SurfTribeSystem1._0
{
    public partial class reservaNivel : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] == null)
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }

            Session["numero"] = 0;
            Session["asigando"] = 0;

            nombreUbicacíon.Text = Session["Ubicación"].ToString();
            string valor = Request.QueryString["escuela"].ToString();
            EncriptarLogica encry = new EncriptarLogica();
            nombreEscuela.Text= encry.Desencripta(valor);
            Session["escuela"] = nombreEscuela.Text;
            
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {

            if (Session["InicioSesion"] != null)
            {
                Usuario usu = (Usuario)Session["InicioSesion"];

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

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
           
            Response.Redirect(Session["devuelta"].ToString());
        }
    }
}