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
    public partial class reservaHorario : System.Web.UI.Page
    {
        int cuenta = 1;
        int numero = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from ESCUELA", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            repeater1.DataSource = dt;
            repeater1.DataBind();
            

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("reservaIndumentaria.aspx");
            
        }

        protected void btnDesselecionar_Click(object sender, EventArgs e)
        {

        }

        protected void repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

          

            Image lbl = e.Item.FindControl("ss") as Image;
            Button btn = e.Item.FindControl("btnDesselecionar") as Button;
           

            btn.Visible = true;
            // lbl.Visible = true;
            btn.ID = Convert.ToString(cuenta);

        }

        protected void repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            int numeroposible = 0;
            numeroposible= (int)Session[numero]+1;
            Session[numero] = numeroposible;


            Image lbl = e.Item.FindControl("ss") as Image;
            Button btn = e.Item.FindControl("1") as Button;

            if ((int)Session["asigando"] == 0) {

                Session["nombreBoton"] = btn.CommandName;

            }


            if ((String)Session["nombreBoton"] == btn.CommandName)
            {
               

                if (numeroposible % 2 == 0)
                {
                    btn.Text = "  Reservar  ";
                    lbl.Visible = false;
                    Session["asigando"] = 0;

                }
                else
                {

                    btn.Text = "Desseleccionar";
                    lbl.Visible = true;
                    Session["asigando"] = +1;

                }
            }
            else
            {
                btn.Text = "Desseleccionar";
                lbl.Visible = true;
                Session["asigando"] = +1;


            }

           // if ((int)Session["asigando"] == 1)
            //{
              //  btn.Text = "Desseleccionar";
               // lbl.Visible = true;
           // }


            //  btn2.OnClientClick=" <script>";


            //   if (btn2.CausesValidation==true) {


           // foreach (string n in a)
            //{

             //   if (btn.CommandArgument == n)
               // {
                 //   btn.Visible = false;
                   // btn.Visible = true;
                    //lbl.Visible = true;
                    //btn.ID = Convert.ToString(cuenta);
                //}

            //}
        }
    }
}