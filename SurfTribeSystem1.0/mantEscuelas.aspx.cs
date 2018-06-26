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
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarEscuelas();
        }

        protected void grvEstado_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void grvEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListarEscuelas()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;");
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
                SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;");
                SqlDataAdapter sda = new SqlDataAdapter("select * from ESCUELA where ID='"+ ddlEscuelas.SelectedValue+"'", con);
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
                    //if (resultado.TipoResultado == "OK")
                    //{
                    //    string script = "swal('Excelente', 'Éxito en la insersión', 'success'); ";
                    //    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    //    Limpiar();
                    //}
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

        }
}