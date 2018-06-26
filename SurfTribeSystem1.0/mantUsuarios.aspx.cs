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
        protected void Page_Load(object sender, EventArgs e)
        {

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
                SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select * from USUARIO where CORREO='"+txtCed.Text+"'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);





                if (dt.Rows.Count > 0)
                {

                    grvEstado.DataSource = dt;
                    grvEstado.DataBind();
                    idEditar.Visible = true;

                }
                else {

                    lblexito.Text = "Usuario no encontrado";
                    idEditar.Visible = false;


                }

                }
                catch
                {
                    lblexito.Text = "Usuario no encontrado";
                    idEditar.Visible = false;

                }
            
        }

        protected void idEditar_Click(object sender, EventArgs e)
        {
          
        }
    }
}