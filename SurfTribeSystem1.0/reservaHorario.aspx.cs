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
    public partial class reservaHorario : System.Web.UI.Page
    {
        int cuenta = 1;
        int numero = 0;
        Sesion sesion = new Sesion();
        List<Sesion> sesiones = new List<Sesion>();
        protected void Page_Load(object sender, EventArgs e)
        {

            Ubicacion.Text = Session["Ubicación"].ToString();
            nombreEscuela.Text= Session["escuela"].ToString();
            nivel.Text= Session["Nivel"].ToString();

           

            

            ObtenerListado();
            

        }
        private void ObtenerListado()
        {
            
            Resultado resultado = new Resultado();
            try
            {
                string nivel= Session["Nivel"].ToString().ToUpper();
                String escuela = Session["escuela"].ToString();
                
                sesion.Tag = "PRINCIPAL";
                sesion.Activa = true;
                sesion.IdEscuela = escuela;
                sesion.Dificultad = nivel;

                Usuario usu = new Usuario();
                usu = (Usuario)Session["InicioSesion"];
                sesion.IdUsuario = usu.Correo;


                resultado = new SesionLogica().Acciones(sesion);

                if (resultado.TipoResultado == "OK")
                {
                    

                    sesiones = (List<Sesion>)resultado.ObjetoResultado;

                    repeater1.DataSource = sesiones;
                    repeater1.DataBind();
                }
                else
                {
                    Response.Redirect("reservaSinCampo.aspx");
                }
            }
            catch (Exception ex)
            {

                Response.Write("< script > alert('Error: " + ex + " \n Lo sentimos') </ script >");
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {


            Response.Redirect("reservaIndumentaria.aspx");
            
        }

        protected void btnDesselecionar_Click(object sender, EventArgs e)
        {

        }

        protected void repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

          

            Image lbl = e.Item.FindControl("ss") as Image;
            Button btn = e.Item.FindControl("btnDesselecionar") as Button;
           

            btn.Visible = true;
            // lbl.Visible = true;
            btn.ID = Convert.ToString(cuenta);

        }

        protected void repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            int numeroposible = 0;
            numeroposible= (int) Session["numero"]+1;
            Session["numero"] = numeroposible;


            Image lbl = e.Item.FindControl("ss") as Image;
            Button btn = e.Item.FindControl("1") as Button;//se selecciona 1 en referencia al primer repeater generico
            Label lblPrecio = e.Item.FindControl("lblPrecio") as Label;// precio sesion
            Label lblNombre = e.Item.FindControl("lblNombre") as Label;//nombre instructor
            Label lblApellidos = e.Item.FindControl("lblApellidos") as Label;//apellidos instructor
            Label lblDia = e.Item.FindControl("lblDia") as Label;//dia
            Label lblMes = e.Item.FindControl("lblMes") as Label;//mes
            Label lblHoraInicio = e.Item.FindControl("hInicio") as Label;//Hora Inicio



            if ((int)Session["asigando"] == 0) {

                Session["nombreBoton"] = btn.CommandName;

            }


            if ((String)Session["nombreBoton"] == btn.CommandName)
            {
               

                if (numeroposible % 2 == 0)
                {
                    btn.Text = "  Reservar  ";
                    lbl.Visible = false;
                    Session["asigando"] = 0;
                    btnContinuar.Visible = false;
                    Session["idReserva"] = "";

                }
                else
                {

                    btn.Text = "Desseleccionar";
                    lbl.Visible = true;
                    Session["asigando"] = +1;
                    btnContinuar.Visible = true;
                    Session["idReserva"] = btn.CommandName;
                    Session["PrecioReserva"] = lblPrecio.Text;
                    Session["ConfInstructor"] = lblNombre.Text + " " + lblApellidos.Text;
                    Session["ConfFecha"] = lblDia.Text + " de " + lblMes.Text + " del " + DateTime.Now.Year.ToString();
                    Session["ConfHinicio"] = lblHoraInicio.Text;
                }
            }
            else
            {
                btn.Text = "Desseleccionar";
                lbl.Visible = true;
                Session["asigando"] = +1;
                btnContinuar.Visible = true;
                Session["idReserva"] = btn.CommandName;
                Session["PrecioReserva"] = lblPrecio.Text;
                Session["ConfInstructor"] = lblNombre.Text + " " + lblApellidos.Text;
                Session["ConfFecha"] = lblDia.Text + " de " + lblMes.Text + " del " + DateTime.Now.Year.ToString();
                Session["ConfHinicio"] = lblHoraInicio.Text;


            }

           // if ((int)Session["asigando"] == 1)
            //{
              //  btn.Text = "Desseleccionar";
               // lbl.Visible = true;
           // }


            //  btn2.OnClientClick=" <script>";


            //   if (btn2.CausesValidation==true) {


           // foreach (string n in a)
            //{

             //   if (btn.CommandArgument == n)
               // {
                 //   btn.Visible = false;
                   // btn.Visible = true;
                    //lbl.Visible = true;
                    //btn.ID = Convert.ToString(cuenta);
                //}

            //}
        }

       
    }
}