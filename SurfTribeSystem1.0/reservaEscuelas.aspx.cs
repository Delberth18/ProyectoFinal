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
    public partial class reservaEscuelas : System.Web.UI.Page
    {
        Escuela escuela = new Escuela();
        List<Escuela> escuelas = new List<Escuela>();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["InicioSesion"] == null)
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }


            if (Request.QueryString["nombreUbicación"].ToString() == "LIMON")
            {
                idUbicación.Text = "Limón";
            }
            else {

                if (Request.QueryString["nombreUbicación"].ToString() == "GUANACASTE")
                {
                    idUbicación.Text = "Guanacaste";
                }
                else {

                    idUbicación.Text = "Puntarenas";
                }

            }

            Session["Ubicación"] = idUbicación.Text;

            ObtenerListado();
            Session["devuelta"] = HttpContext.Current.Request.Url.AbsoluteUri;


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

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            Response.Redirect("ccss/star-1-3/Static HTML/single-package-right-sidebar.html");

        }
        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                string valor = Request.QueryString["nombreUbicación"].ToString();//captura el parametro pasado por el usuario en la URL
                escuela.Tag = valor;
                resultado = new EscuelaLogica().Acciones(escuela);

                if (resultado.TipoResultado == "OK")
                {
                    escuelas = (List<Escuela>)resultado.ObjetoResultado;
                    
                      repeater1.DataSource = escuelas;
                      repeater1.DataBind(); 
                }
                else
                {
                    Response.Write("< script > alert('Error: " + resultado.Mensaje + " \n Lo sentimos') </ script >");
                }
            }
            catch (Exception ex)
            {

                Response.Write("< script > alert('Error: " + ex + " \n Lo sentimos') </ script >");
            }
        }

        protected void repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            Label lbl = e.Item.FindControl("nombre") as Label;
            HyperLink hyp = e.Item.FindControl("hpvReservaNivel") as HyperLink;

            EncriptarLogica encrip = new EncriptarLogica();
            String encripNombre= encrip.Encripta(lbl.Text);
            hyp.NavigateUrl = "reservaNivel.aspx?escuela=" + encripNombre;


        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("reservaClases.aspx");
        }
    }
}