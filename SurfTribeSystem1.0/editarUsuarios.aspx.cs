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
    public partial class editarUsu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String correo = Session["idEditar"].ToString();
            SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from USUARIO where CORREO='" + correo+ "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataRow row = dt.Rows[0];
            txtCorreo.Text = Convert.ToString(row["CORREO"]);

         
            txtClave.Text = Convert.ToString(row["CLAVE"]);

           
            txtNombre.Text = Convert.ToString(row["NOMBRE"]);

            
            txtApellidos.Text = Convert.ToString(row["APELLIDOS"]);

            
            txtNumero.Text = Convert.ToString(row["TELEFONO"]);

            
            txtPaís.Text = Convert.ToString(row["PAIS"]);


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("mantUsuarios.aspx");
        }
    }
}