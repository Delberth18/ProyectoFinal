﻿using SurfTribeSystem_Entidades;
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
    public partial class reservaIndumentaria : System.Web.UI.Page
    {
        Tabla tabla = new Tabla();
        List<Tabla> tablas = new List<Tabla>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] == null)
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }
            Session["asigando"] = 0;// no tocar
            Session["numero"] = 0;// no tocar

           

            ObtenerListado();


        }
        protected void Page_PreInit(object sender, EventArgs e)
        {

            if (Session["InicioSesion"] != null)
            {
                Usuario usu = (Usuario)Session["InicioSesion"];

                switch (usu.Tipo_usu)
                {
                    case "ADM":
                        this.MasterPageFile = "~/Site2.master";
                        break;
                    case "ADMG":
                        this.MasterPageFile = "~/Site3.master";
                        break;
                    case "REG":
                        this.MasterPageFile = "~/Site4.master";
                        break;
                }
            }


        }
        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                string nivel = Session["Nivel"].ToString().ToUpper();
                string escuela = Session["escuela"].ToString().ToUpper();

                tabla.Dificultad = nivel;
                tabla.Id_Escuela = escuela;
               

                resultado = new AlquilerTablaLogica().Acciones(tabla);
                tablas = (List<Tabla>)resultado.ObjetoResultado;

                if (tablas.Count > 0)
                {
                    
                    repeater1.DataSource = tablas;
                    repeater1.DataBind();
                }
                else
                {
                    Response.Redirect("reservaConfirmar.aspx?rseT=0");
                }
            }
            catch (Exception ex)
            {

                Response.Write("< script > alert('Error: " + ex + " \n Lo sentimos') </ script >");
            }
        }

        protected void btnOmitir_Click(object sender, EventArgs e)
        {
            Response.Redirect("reservaConfirmar.aspx?rseT=0");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            BajarCupo();

            Response.Redirect("reservaHorario.aspx");
        }

        protected void repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lbl = e.Item.FindControl("IDTabla") as Label;
            Label lblPrecio = e.Item.FindControl("lblPrecio") as Label;
            Label lblMarca = e.Item.FindControl("lblMarca") as Label;

            HyperLink hyp = e.Item.FindControl("hpvReservaConfi") as HyperLink;
            EncriptarLogica segr = new EncriptarLogica();
           string valor= segr.Base64Encode(lbl.Text);
            Session["PrecioAlqui"] = lblPrecio.Text;
            Session["MarcaTa"] = lblMarca.Text;

            hyp.NavigateUrl = "reservaConfirmar.aspx?rseT=" +valor;
            //hyp.NavigateUrl = "reservaConfirmar.aspx?rseT=" +"SFo¿0y"+lbl.Text;

           

        }

        private void BajarCupo()
        {
            Sesion sesion = new Sesion();
            Resultado resultado = new Resultado();

            try
            {
                sesion.Id = Session["idReserva"].ToString();
                sesion.Tag = "DESELECCIONADA";
                sesion.Fecha = Convert.ToDateTime(Session["fechaIndu"].ToString());

                resultado = new SesionLogica().Acciones(sesion);

                if (resultado.TipoResultado == "OK")
                {
                    Session["Seleccionado"] = 0;
                }
                else
                {
                    string script = "swal('Error', 'La reserva no se pudo realizar', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {

                string script = "swal('Error', 'La reserva no se pudo realizar', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }


    }
}