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
    public partial class mantEscuelas : System.Web.UI.Page
    {
        public static string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarEscuelas();
            }
            if (Session["Exito"] != null)
            {

                string script = "swal('Excelente', 'Guardado con éxito', 'success'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                Session["Exito"] = null;

            }



            if (Session["exiBorrar"] != null)
            {

                string script = "swal('Excelente', 'Eliminado con éxito', 'success'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                Session["exiBorrar"] = null;

            }
        }
        

        protected void grvEstado_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
      
        protected void grvEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListarEscuelas()
        {
           //SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;");//Delberth
           SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");//Eduardo
            SqlDataAdapter sda = new SqlDataAdapter("select * from ESCUELA", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ddlEscuelas.DataSource = dt;
            ddlEscuelas.DataTextField = "NOMBRE";
            ddlEscuelas.DataValueField = "ID";
            ddlEscuelas.DataBind();
        }

        protected void Seleccionar(object sender, EventArgs e)
        {

            try
            {
                id = ddlEscuelas.SelectedValue;
              // SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;");//delberth
               SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");//Eduardo
                SqlDataAdapter sda = new SqlDataAdapter("select * from ESCUELA where ID='"+ id+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);





                if (dt.Rows.Count > 0)
                {

                    grvEstado.DataSource = dt;
                    grvEstado.DataBind();
                    idEditar.Visible = true;
                   

                }
                else
                {
                        string script = "swal('Lo sentimos, ha ocurrido un error', 'En este momento no podemos procesar la información', 'error'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    
                    
                    idEditar.Visible = false;


                }

            }
            catch(Exception ex)
            {
                string script = "swal('Lo sentimos, ha ocurrido un error', 'En este momento no podemos procesar la información', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

                idEditar.Visible = false;

            }
        }

        protected void idEditar_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = grvEstado.SelectedRow;

                Session["idEditar"] = id;

                Response.Redirect("editarEscuela.aspx");
            }
            catch
            {
                string script = "swal('Lo sentimos, ha ocurrido un error', 'En este momento no podemos procesar la información', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }
    }
}