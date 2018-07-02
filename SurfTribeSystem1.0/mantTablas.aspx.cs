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
                ListarEscuelas();
            }
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


        protected void idSeleccionar_Click(object sender, EventArgs e)
        {
            if (ddlEscuelas.SelectedValue!= "Seleccione una escuela")
            {
                idEscuela = ddlEscuelas.SelectedValue;
                selecion();
            }
            
        }

        private void selecion()
        {
            Resultado resultado = new Resultado();
            try
            {
                List<Tabla> lista = new List<Tabla>();

                Tabla tab = new Tabla();

                tab.Tag = "LISTADO_ESCUELA_NO_VENTA";
                tab.Id_Escuela = idEscuela;
                resultado = new TablaLogica().Acciones(tab);

                lista = (List<Tabla>)resultado.ObjetoResultado;

                if (resultado.TipoResultado == "OK")
                {
                    if (lista.Count == 0)
                    {
                        string script = "swal('Lo sentimos', '" + "No se encontró ningun registro válido de tablas" + "', 'info'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        imagenesList.Visible = false;
                    }
                    else
                    {
                        imagenesList.DataSource = lista;
                        imagenesList.DataBind();

                        imagenesList.Visible = true;
                    }

                }
                else
                {
                    string script = "swal('Lo sentimos', '" + "No se encontró ningun registro válido de tablas" + "', 'info'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    imagenesList.Visible = false;
                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }

        }

        protected void imagenesList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            DropDownList ddl = e.Item.FindControl("estadoList") as DropDownList;
            Label lbl = e.Item.FindControl("idTable") as Label;
            Label lblEst = e.Item.FindControl("est") as Label;

            Resultado resultado = new Resultado();
            resultado = new TablaLogica().Estados();

            List<Estado> lista = (List<Estado>)resultado.ObjetoResultado;
            lista.Add(new Estado { Descripcion = "Seleccione un estado" });

            ddl.DataSource = lista;
            ddl.DataTextField = "Descripcion";
            ddl.DataValueField = "Descripcion";
            ddl.DataBind();

            ddl.SelectedValue = "Seleccione un estado";
            idTabla = lbl.Text;
        }

        protected void estadoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((DropDownList)sender).SelectedValue != "Seleccione un estado")
            {

                Resultado resultado = new Resultado();
                try
                {
                    List<Tabla> lista = new List<Tabla>();

                    Tabla tab = new Tabla();

                    tab.Tag = "CAMBIA_ESTADO";
                    tab.Id_Escuela = idEscuela;
                    tab.Id = idTabla;
                    tab.Estado = ((DropDownList)sender).SelectedValue;

                    resultado = new TablaLogica().Acciones(tab);

                    if (resultado.TipoResultado != "OK")
                    {
                        string script = "swal('Lo sentimos', '" + "No se encontró ningun registro válido de tablas" + "', 'info'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        imagenesList.Visible = false;
                    }
                    else
                    {
                        selecion();
                    }

                }
                catch (Exception ex)
                {
                    string script = "swal('Error', '" + ex + "', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }

                
            }
        }
    }
}