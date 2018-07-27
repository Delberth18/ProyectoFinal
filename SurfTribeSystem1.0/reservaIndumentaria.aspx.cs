using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class reservaIndumentaria : System.Web.UI.Page
    {
        Tabla tabla = new Tabla();
        List<Tabla> tablas = new List<Tabla>();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            Session["asigando"] = 0;// no tocar
            Session["numero"] = 0;// no tocar

           

            ObtenerListado();


        }
        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                string nivel = Session["Nivel"].ToString().ToUpper();
                string escuela = Session["escuela"].ToString().ToUpper();

                tabla.Dificultad = nivel;
                tabla.Id_Escuela = escuela;
               

                resultado = new AlquilerTablaLogica().Acciones(tabla);
                tablas = (List<Tabla>)resultado.ObjetoResultado;

                if (tablas.Count > 0)
                {
                    
                    repeater1.DataSource = tablas;
                    repeater1.DataBind();
                }
                else
                {
                    Response.Redirect("reservaConfirmar.aspx?rseT=0");
                }
            }
            catch (Exception ex)
            {

                Response.Write("< script > alert('Error: " + ex + " \n Lo sentimos') </ script >");
            }
        }

        protected void btnOmitir_Click(object sender, EventArgs e)
        {
            Response.Redirect("reservaConfirmar.aspx?rseT=0");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("reservaHorario.aspx");
        }

        protected void repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lbl = e.Item.FindControl("IDTabla") as Label;
            Label lblPrecio = e.Item.FindControl("lblPrecio") as Label;
            Label lblMarca = e.Item.FindControl("lblMarca") as Label;

            HyperLink hyp = e.Item.FindControl("hpvReservaConfi") as HyperLink;
            EncriptarLogica segr = new EncriptarLogica();
           string valor= segr.Base64Encode(lbl.Text);
            Session["PrecioAlqui"] = lblPrecio.Text;
            Session["MarcaTa"] = lblMarca.Text;

            hyp.NavigateUrl = "reservaConfirmar.aspx?rseT=" +valor;
            //hyp.NavigateUrl = "reservaConfirmar.aspx?rseT=" +"SFo¿0y"+lbl.Text;

           

        }

    
    }
}