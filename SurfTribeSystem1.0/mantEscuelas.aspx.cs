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
            Resultado resultado = new Resultado();
            try
            {
                List<Escuela> lista = new List<Escuela>();

                Escuela esc = new Escuela();

                esc.Tag = "LISTA_PRINCIPAL";
                resultado = new EscuelaLogica().Acciones(esc);

                lista = (List<Escuela>)resultado.ObjetoResultado;
                lista.Add(new Escuela { Nombre = "Seleccione una escuela", Id = "Seleccione una escuela" });

                ddlEscuelas.DataSource = lista;
                ddlEscuelas.DataTextField = "NOMBRE";
                ddlEscuelas.DataValueField = "ID";
                ddlEscuelas.DataBind();

                ddlEscuelas.SelectedValue = "Seleccione una escuela";

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void Seleccionar(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {
                id = ddlEscuelas.SelectedValue;
              
                List<Escuela> lista = new List<Escuela>();

                Escuela esc = new Escuela();
                esc.Id = id;
                esc.Tag = "LISTADO_POR_ID";
                resultado = new EscuelaLogica().Acciones(esc);

                lista = (List<Escuela>)resultado.ObjetoResultado;



                if (lista.Count > 0)
                {

                    grvEstado.DataSource = lista;
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