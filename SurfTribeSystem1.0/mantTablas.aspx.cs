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
    public partial class mantTablas : System.Web.UI.Page
    {
        public static string idEscuela = "";
        public static string idTabla = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarRegistro();
                ListarEscuelas();
            }
        }

        private void ListarRegistro()
        {
            Resultado resultado = new Resultado();
            try
            {
                List<Tabla> lista = new List<Tabla>();
                Tabla tab = new Tabla();
                tab.Tag = "LISTADO";
                resultado = new TablaLogica().Acciones(tab);
                if (resultado.TipoResultado == "OK")
                {
                    lista = new List<Tabla>();
                    lista = (List<Tabla>)resultado.ObjetoResultado;
                    //imagenesList.DataSource = lista;
                    //imagenesList.DataBind();

                    //imagenesList.DataSource = lista;
                    //imagenesList.DataBind();
                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
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

        //private void ListarEstado()
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;");//Delberth
        //    //SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");//Eduardo
        //    SqlDataAdapter sda = new SqlDataAdapter("select * from Estado", con);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);

        //    e.DataSource = dt;
        //    ddlEscuelas.DataTextField = "DESCRIPCION";
        //    ddlEscuelas.DataValueField = "DESCRIPCION";
        //    ddlEscuelas.DataBind();
        //}

        protected void idSeleccionar_Click(object sender, EventArgs e)
        {

            selecion();
            //ListarEstado();
        }

        private void selecion()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;");//Delberth
            //SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");//Eduardo
            SqlDataAdapter sda = new SqlDataAdapter("select * from TABLASURF where ID_ESCUELA='" + ddlEscuelas.SelectedValue + "' and ESTADO<>'VENDIDA'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            idEscuela = ddlEscuelas.SelectedValue;
            imagenesList.DataSource = dt;
            imagenesList.DataBind();

            imagenesList.Visible = true;
           
        }

        protected void imagenesList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            DropDownList ddl = e.Item.FindControl("estadoList") as DropDownList;
            Label lbl= e.Item.FindControl("idTable") as Label;

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;");//Delberth
            //SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");//Eduardo
            SqlDataAdapter sda = new SqlDataAdapter("select * from Estado_Tabla", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ddl.DataSource = dt;
            ddl.DataTextField = "DESCRIPCION";
            ddl.DataValueField = "DESCRIPCION";
            ddl.DataBind();

            idTabla = lbl.Text;
        }

        protected void estadoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;");//Delberth
            //SqlConnection con = new SqlConnection("Data Source=laptop-r7vb3im9\\mssqlserver01;Initial Catalog=SURF_TRIBE;Integrated Security=True");//Eduardo
            SqlDataAdapter sda = new SqlDataAdapter("update TABLASURF set ESTADO='" +((DropDownList) sender).SelectedValue + "' where ID_ESCUELA='"+ idEscuela + "' and ID='" + idTabla + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            selecion();
        }
    }
}