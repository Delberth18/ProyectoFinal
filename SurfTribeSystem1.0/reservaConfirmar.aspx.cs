﻿
using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class reservaConfirmar : System.Web.UI.Page
    {
        string idTablaRser = "0";
        Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] == null)
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }
            lblEscuela.Text = Session["escuela"].ToString();//coloca el nombre de la escuela
            lblNivel.Text = Session["Nivel"].ToString();//coloca el nombre del nivel
            string valor = Request.QueryString["rseT"].ToString();//obtiene el valor de parametro
           

            lblUbicación.Text = Session["Ubicación"].ToString();//coloca la ubicación
            usuario = (Usuario)Session["InicioSesion"];//setea el usuario registrado
            lblAlumno.Text = usuario.Nombre + " " + usuario.Apellidos;//setea el nombre del alumno
            lblInstructor.Text = Session["ConfInstructor"].ToString();//setea el instructor
            lblFecha.Text = Session["ConfFecha"].ToString();//setea la fecha
            lblHora.Text = Session["ConfHinicio"].ToString();//setea la hora


            //variables cuando no hay alquiler
            if (valor == "0")
            {
                
                lblTotal.Text = "₡ "+ Session["PrecioReserva"].ToString();
                Session["idTabRe"] = valor;
                //Calculos de montos
                int precioSesionIV = Convert.ToInt32(Session["PrecioReserva"].ToString());
                double impuesto= precioSesionIV*(0.13);
                lblImpuestos.Text = "₡ " + impuesto;
                double precioSesion = precioSesionIV - impuesto;
                lblPrecioLec.Text = "₡ " + precioSesion;



            }//cuando hay alquiler
            else
            {

                EncriptarLogica seg = new EncriptarLogica();//decodifica el valor del id
                valor = seg.Base64Decode(valor);//decodifica el valor del id
                idTablaRser = valor;//setea el valor de la tabla
                Session["idTabRe"] = valor;
                lblAlquilerDeta.Text = Session["MarcaTa"].ToString();

                int precioSesionIV = Convert.ToInt32(Session["PrecioReserva"].ToString());
                double impuestoSesion = precioSesionIV * (0.13);

                int precioAlquilerIV = Convert.ToInt32(Session["PrecioAlqui"].ToString());
                double impuestoAlquiler = precioAlquilerIV * (0.13);

                lblImpuestos.Text = "₡ " + (impuestoSesion+impuestoAlquiler);

               
                lblPrecioLec.Text = "₡ " + (precioSesionIV-impuestoSesion);
                lblPrecioAlquiler.Text = "₡ " + (precioAlquilerIV - impuestoAlquiler);
                lblTotal.Text = "₡ " + (precioSesionIV + precioAlquilerIV);

               
                if (!IsPostBack)
                {
                    CrearReservaTabla();
                }

            }
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


        protected void btnOmitir_Click(object sender, EventArgs e)
        {
            if (ChkTerminosYCon.Checked == false)
            {
                string script = "swal('Error', 'Debes de Aceptar los Términos y Condiciones', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

            }
            else {

                Sesion sesion = new Sesion();
                Resultado resultado = new Resultado();
                try
                {
                    sesion.Id = Session["idReserva"].ToString();
                    sesion.IdUsuario = usuario.Correo;
                    sesion.Tag = "REALIZADA";

                    resultado = new ReservaSesionLogica().Acciones(sesion);

                    if (resultado.TipoResultado == "OK")
                    {
                        
                        Session["lblAlumno"] = lblAlumno.Text;
                        Session["lblEscuela"] = lblEscuela.Text;
                        Session["lblNivel"] = lblNivel.Text;
                        Session["lblFecha"] = lblFecha.Text;
                        Session["lblHora"] = lblHora.Text;
                        Session["lblInstructor"] = lblInstructor.Text;
                        Session["lblAlquilerDeta"] = lblAlquilerDeta.Text;
                        Session["lblUbicación"] = lblUbicación.Text;
                        Session["lblPrecioLec"] = lblPrecioLec.Text;
                        Session["lblPrecioAlquiler"] = lblPrecioAlquiler.Text;
                        Session["lblImpuestos"] = lblImpuestos.Text;
                        Session["lblTotal"] = lblTotal.Text;
                        Session["facPdf"] = 1;
                        string urlDownload = "pdfReserva.aspx";
                        string urlRedireccion = "defaultConLogeoUN.aspx";

                        string script = @"window.open('{0}','');
					window.location.href='{1}';";
                        script = string.Format(script, urlDownload, urlRedireccion);

                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "popup", script, true);
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

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            BajarReservaTabla();
            Response.Redirect("reservaIndumentaria.aspx");
            
        }
        private void CrearReservaTabla()
        {
            Tabla tabla = new Tabla();
            Resultado resultado = new Resultado();

            try
            {
                tabla.Id = idTablaRser;
                tabla.Id_usuario = usuario.Correo;
                tabla.Costo = Convert.ToDouble(Session["PrecioAlqui"].ToString());
                tabla.Fecha= Convert.ToDateTime(Session["fechaIndu"].ToString());
                tabla.Tag = "REGISTRAR";

                resultado = new ReservaTablaLogica().Acciones(tabla);

                if (resultado.TipoResultado == "OK")
                {

                }
                else
                {
                    string script = "swal('Error', 'La reserva de la tabla no se pudo realizar', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {

                string script = "swal('Error', 'La reserva de la tabla no se pudo realizar', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }
        private void BajarReservaTabla()
        {
            Tabla tabla = new Tabla();
            Resultado resultado = new Resultado();

            try
            {
                tabla.Id = idTablaRser;
                tabla.Id_usuario = usuario.Correo;
                tabla.Costo = Convert.ToDouble( Session["PrecioAlqui"].ToString());
                tabla.Fecha=  Convert.ToDateTime(Session["fechaIndu"].ToString());
                tabla.Tag = "ELIMINAR";

                resultado = new ReservaTablaLogica().Acciones(tabla);

                if (resultado.TipoResultado == "OK")
                {
                   
                }
                else
                {
                    string script = "swal('Error', 'La reserva de la tabla no se pudo realizar', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {

                string script = "swal('Error', 'La reserva de la tabla no se pudo realizar', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

       
    }
}