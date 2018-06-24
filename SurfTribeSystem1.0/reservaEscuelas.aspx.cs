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
    public partial class reservaEscuelas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from ESCUELA",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            repeater1.DataSource = dt;
            repeater1.DataBind();   

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            Response.Redirect("ccss/star-1-3/Static HTML/single-package-right-sidebar.html");

        }
    }
}