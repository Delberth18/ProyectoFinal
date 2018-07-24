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
    public partial class reservaConfirmar : System.Web.UI.Page
    {
        string idTablaRser = "0";
        Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblEscuela.Text = Session["escuela"].ToString();
            lblNivel.Text = Session["Nivel"].ToString();
            string valor = Request.QueryString["rseT"].ToString();
           
            if (!IsPostBack)
            {


                if (Session["control"] == null)
                {

                    Session["timer"] = DateTime.Now.AddMinutes(2).ToString();
                    Session["control"] = 1;// hay que cambiar el estado control o destruirlo donde lo redirige
                }

            }
            //variables cuando hay reserva
            if (valor == "0")
            {
                usuario = (Usuario)Session["InicioSesion"];
                lblAlumno.Text = usuario.Nombre + " " + usuario.Apellidos;

            }
            else
            {

                EncriptarLogica seg = new EncriptarLogica();
                valor = seg.Base64Decode(valor);
                idTablaRser = valor;
                usuario = (Usuario)Session["InicioSesion"];
                lblAlumno.Text = usuario.Nombre + " " + usuario.Apellidos;
            }
        }

     

        protected void btnOmitir_Click(object sender, EventArgs e)
        {
           

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("reservaIndumentaria.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Compare(DateTime.Now, DateTime.Parse(Session["timer"].ToString())) < 0)
            {

                listMSg.Text =
                    ((Int32)DateTime.Parse(Session["timer"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString()
                    + ":"
                    +
                    (((Int32)DateTime.Parse(Session["timer"].ToString()).Subtract(DateTime.Now).TotalSeconds) % 60).ToString();


            }
            else
            {

                listMSg.Text = "Tiempo fuera";

            }

        }
    }
}