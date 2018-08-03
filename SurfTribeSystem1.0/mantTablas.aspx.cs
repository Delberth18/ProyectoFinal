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
        public static string idTabla = "";
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
            if (!IsPostBack)
            {
                selecion();
            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.MasterPageFile = "~/Site2.master";

        }

        private void selecion()
        {
            Resultado resultado = new Resultado();
            try
            {
                List<Tabla> lista = new List<Tabla>();

                Tabla tab = new Tabla();

                tab.Tag = "LISTADO_ESCUELA_NO_VENTA";
                tab.Id_Escuela = usu.IdEscuela;
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
                    tab.Id_Escuela = usu.IdEscuela;
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