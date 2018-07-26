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
            lblUbicación.Text = Session["Ubicación"].ToString();


            //variables cuando hay reserva
            if (valor == "0")
            {
                usuario = (Usuario)Session["InicioSesion"];
                lblAlumno.Text = usuario.Nombre + " " + usuario.Apellidos;
                lblPrecioLec.Text = "₡ "+ Session["PrecioReserva"].ToString();
                

            }
            else
            {

                EncriptarLogica seg = new EncriptarLogica();
                valor = seg.Base64Decode(valor);
                idTablaRser = valor;
                usuario = (Usuario)Session["InicioSesion"];
                lblAlumno.Text = usuario.Nombre + " " + usuario.Apellidos;
                lblPrecioLec.Text = "₡ " + Session["PrecioReserva"].ToString();
            }
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