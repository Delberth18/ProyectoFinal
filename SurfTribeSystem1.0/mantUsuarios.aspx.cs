using SurfTribeSystem_Entidades;
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
    public partial class mantUsuarios : System.Web.UI.Page
    {
        Usuario usu = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null)
            {
                usu = (Usuario)Session["InicioSesion"];

                if (usu.Tipo_usu != "ADM")
                {
                    Response.Redirect("defaultSinLogeoUN.aspx");
                }
            }
            else
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }
            if (Session["Exito"]!= null) {

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
        protected void idBuscar_Click(object sender, EventArgs e)
        {
            
                try
                {
                SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;");//delberth
                //SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");//Eduardo
                SqlDataAdapter sda = new SqlDataAdapter("select * from USUARIO where CORREO='"+txtCed.Text+"'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);





                if (dt.Rows.Count > 0)
                {

                    grvEstado.DataSource = dt;
                    grvEstado.DataBind();
                    idEditar.Visible = true;
                    lblexito.Text = "";

                }
                else {

                    lblexito.Text = "Usuario no encontrado";
                    idEditar.Visible = false;
                    grvEstado.DataBind();
                    


                }

                }
                catch
                {
                    lblexito.Text = "Usuario no encontrado";
                    idEditar.Visible = false;
                    grvEstado.DataBind();

            }
            
        }

        protected void idEditar_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = grvEstado.SelectedRow;
              
                Session["idEditar"]  = (row.Cells[2].Text);//esta es la ubicacion del id en el grid para guardar

                Response.Redirect("editarUsuarios.aspx");
            }
            catch
            {
                alert.Text = "Lo sentimos no existe ningún usuario";
            }
        }
    }
}