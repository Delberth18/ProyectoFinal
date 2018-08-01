using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class reservaSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarHoras();
        }

        public void CargarHoras()
        {
            ddlHi.Items.Add("6:00 AM");
            ddlHi.Items.Add("7:00 AM");
            ddlHi.Items.Add("8:00 AM");
            ddlHi.Items.Add("9:00 AM");
            ddlHi.Items.Add("10:00 AM");
            ddlHi.Items.Add("11:00 AM");
            ddlHi.Items.Add("12:00 MD");
            ddlHi.Items.Add("1:00 PM");
            ddlHi.Items.Add("2:00 PM");

            ddlHf.Items.Add("7:00 AM");
            ddlHf.Items.Add("8:00 AM");
            ddlHf.Items.Add("9:00 AM");
            ddlHf.Items.Add("10:00 AM");
            ddlHf.Items.Add("11:00 AM");
            ddlHf.Items.Add("12:00 MD");
            ddlHf.Items.Add("1:00 PM");
            ddlHf.Items.Add("2:00 PM");



        }
    }
}