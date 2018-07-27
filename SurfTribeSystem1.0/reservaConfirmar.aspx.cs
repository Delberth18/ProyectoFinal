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
            lblEscuela.Text = Session["escuela"].ToString();//coloca el nombre de la escuela
            lblNivel.Text = Session["Nivel"].ToString();//coloca el nombre del nivel
            string valor = Request.QueryString["rseT"].ToString();//obtiene el valor de parametro

            lblUbicación.Text = Session["Ubicación"].ToString();//coloca la ubicación
            usuario = (Usuario)Session["InicioSesion"];//setea el usuario registrado
            lblAlumno.Text = usuario.Nombre + " " + usuario.Apellidos;//setea el nombre del alumno
            lblInstructor.Text = Session["ConfInstructor"].ToString();//setea el instructor
            lblFecha.Text = Session["ConfFecha"].ToString();//setea la fecha
            lblHora.Text = Session["ConfHinicio"].ToString();//setea la hora


            //variables cuando no hay alquiler
            if (valor == "0")
            {
                
                lblTotal.Text = "₡ "+ Session["PrecioReserva"].ToString();
                

                //Calculos de montos
                int precioSesionIV = Convert.ToInt32(Session["PrecioReserva"].ToString());
                double impuesto= precioSesionIV*(0.13);
                lblImpuestos.Text = "₡ " + impuesto;
                double precioSesion = precioSesionIV - impuesto;
                lblPrecioLec.Text = "₡ " + precioSesion;



            }//cuando hay alquiler
            else
            {

                EncriptarLogica seg = new EncriptarLogica();//decodifica el valor del id
                valor = seg.Base64Decode(valor);//decodifica el valor del id
                idTablaRser = valor;//setea el valor de la tabla
                lblAlquilerDeta.Text = Session["MarcaTa"].ToString();

                int precioSesionIV = Convert.ToInt32(Session["PrecioReserva"].ToString());
                double impuestoSesion = precioSesionIV * (0.13);

                int precioAlquilerIV = Convert.ToInt32(Session["PrecioAlqui"].ToString());
                double impuestoAlquiler = precioAlquilerIV * (0.13);

                lblImpuestos.Text = "₡ " + (impuestoSesion+impuestoAlquiler);

               
                lblPrecioLec.Text = "₡ " + (precioSesionIV-impuestoSesion);
                lblPrecioAlquiler.Text = "₡ " + (precioAlquilerIV - impuestoAlquiler);
                lblTotal.Text = "₡ " + (precioSesionIV + precioAlquilerIV);



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