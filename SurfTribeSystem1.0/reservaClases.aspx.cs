using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class reservaClases : System.Web.UI.Page
    {
        Reserva reserva = new Reserva();
        public static List<Reserva> listareserva = new List<Reserva>();
        Usuario usu = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] == null)
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }
            else {
                usu = (Usuario)Session["InicioSesion"];

                if (ValidaciónEstado() != "Aprobado")
                {
                    Session["validacionReserva"] = "Reprobado";
                    Session["valida"] = 1;
                    Response.Redirect("reporteReserva.aspx");
                }

            }

            if (Session["idReserva"] != null)
            {

                if (Session["idReserva"].ToString() != "")
                { 
                BajarCupo();
                Session["idReserva"] = "";

                }


            }

            if (Session["idTabRe"] != null)
            {
                if (Session["idTabRe"].ToString() != "0")
                {
                    BajarReservaTabla();
                    Session["idTabRe"] = "0";
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
        private string ValidaciónEstado()
        {
            Resultado resultado = new Resultado();
            string validado = "Reprobado";
            try
            {
               
                reserva.IdUsuario = usu.Correo;
                reserva.Tag = "ALQUILER";
                resultado = new ReporteReservaLogica().Acciones(reserva);


                listareserva = new List<Reserva>();
                listareserva = (List<Reserva>)resultado.ObjetoResultado;



                //
                reserva.Tag = "SINALQUILER";
                resultado = new ReporteReservaLogica().Acciones(reserva);

                List<Reserva> listareserva2 = new List<Reserva>();

                listareserva2 = (List<Reserva>)resultado.ObjetoResultado;

                foreach (Reserva re in listareserva2)
                {
                    listareserva.Add(re);
                }

                if (listareserva.Count <= 0)
                {
                    validado= "Aprobado";
                }
                else
                {
                    foreach (Reserva re1 in listareserva)
                    {
                        if (re1.Estado == "PENDIENTE")
                        {
                            validado = "Reprobado";
                            return validado;
                        }
                        else {

                            validado = "Aprobado";
                        }
                    }
                }

                return validado;

            }
            catch (Exception ex)
            {
                return validado;
            }
        }

        private void BajarCupo()
        {
            Sesion sesion = new Sesion();
            Resultado resultado = new Resultado();

            try
            {
                sesion.Id = Session["idReserva"].ToString();
                sesion.Tag = "DESELECCIONADA";

                resultado = new SesionLogica().Acciones(sesion);

                if (resultado.TipoResultado == "OK")
                {

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
        private void BajarReservaTabla()
        {
            Tabla tabla = new Tabla();
            Resultado resultado = new Resultado();
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["InicioSesion"];//setea el usuario registrado

            try
            {
                tabla.Id = Session["idTabRe"].ToString();
                tabla.Id_usuario = usuario.Correo;
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