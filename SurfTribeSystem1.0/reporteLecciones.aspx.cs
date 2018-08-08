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
    public partial class reporteLecciones : System.Web.UI.Page
    {
        public static List<Sesion> listaSesiones = new List<Sesion>();
        Usuario usuario = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null)
            {
                usuario = (Usuario)Session["InicioSesion"];

                if (usuario.Tipo_usu != "ADM")
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
                ListarDificultad();
                ListarHorarios();
                ListarInstructores();

                reportSesion();


            }
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.MasterPageFile = "~/Site2.master";
        }

        private void ListarDificultad()
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SesionLogica().datosParaReporte( usuario.IdEscuela, "DIFICULTAD");
                if (resultado.TipoResultado == "OK")
                {

                    List<string> lista = (List<string>)resultado.ObjetoResultado;
                    lista.Add("Seleccione la dificultad");

                    dificultadLst.DataSource = lista;
                    dificultadLst.DataBind();

                    dificultadLst.SelectedValue = "Seleccione la dificultad";

                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void ListarHorarios()
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SesionLogica().datosParaReporte(usuario.IdEscuela, "FECHA");
                if (resultado.TipoResultado == "OK")
                {

                    List<string> lista = (List<string>)resultado.ObjetoResultado;
                    lista.Add("Seleccione una fecha");

                    fechalst.DataSource = lista;
                    fechalst.DataBind();

                    fechalst.SelectedValue = "Seleccione una fecha";

                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void ListarInstructores()
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SesionLogica().datosParaReporte(usuario.IdEscuela, "INSTRUCTOR");
                if (resultado.TipoResultado == "OK")
                {

                    List<string> lista = (List<string>)resultado.ObjetoResultado;
                    lista.Add("Seleccione un instructor");

                    instructorlst.DataSource = lista;
                    instructorlst.DataBind();

                    instructorlst.SelectedValue = "Seleccione un instructor";

                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }


        private void reportSesion()
        {
            Resultado resultado = new Resultado();
            try
            {
                string dificultad = dificultadLst.SelectedValue;
                string fecha = fechalst.SelectedValue;
                string instructor = instructorlst.SelectedValue;


                if (dificultad == "Seleccione la dificultad")
                {
                    dificultad = "";
                }
                if (fecha == "Seleccione una fecha")
                {
                    fecha = "";
                }
                if (instructor == "Seleccione un instructor")
                {
                    instructor = "";
                }

                resultado = new SesionLogica().Reporte(usuario.IdEscuela, dificultad, fecha, instructor);
                if (resultado.TipoResultado == "OK")
                {
                    listaSesiones = null;

                    infoLst.DataSource = null;
                    infoLst.DataBind();

                    listaSesiones = new List<Sesion>();
                    listaSesiones = (List<Sesion>)resultado.ObjetoResultado;
                    infoLst.DataSource = listaSesiones;
                    infoLst.DataBind();

                }




            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }



        protected void reporteSesion(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {
                string dificultad = dificultadLst.SelectedValue;
                string fecha = fechalst.SelectedValue;
                string instructor = instructorlst.SelectedValue;


                if (dificultad == "Seleccione la dificultad")
                {
                    dificultad = "";
                }
                if (fecha == "Seleccione una fecha")
                {
                    fecha = "";
                }
                if(instructor== "Seleccione un instructor")
                {
                    instructor = "";
                }

                resultado = new SesionLogica().Reporte(usuario.IdEscuela, dificultad, fecha, instructor);
                if (resultado.TipoResultado == "OK")
                {
                    listaSesiones = null;

                    infoLst.DataSource = null;
                    infoLst.DataBind();

                    listaSesiones = new List<Sesion>();
                    listaSesiones = (List<Sesion>)resultado.ObjetoResultado;
                    infoLst.DataSource = listaSesiones;
                    infoLst.DataBind();

                }




            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void GenerarReporte(object sender, EventArgs e)
        {

            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // PdfWriter writer = PdfWriter.GetInstance(doc,
            // new FileStream(@"C:\Users\edu08\Downloads\prueba.pdf", FileMode.Create));

            PdfWriter writer = PdfWriter.GetInstance(doc,
            new FileStream(@"C:\Users\Public\Downloads\prueba.pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Detalles de tablas");
            doc.AddCreator("STS");

            // Abrimos el archivo
            doc.Open();
            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            Font fuenteT = new Font();
            fuenteT.Size = 18;
            fuenteT.SetStyle(Font.BOLD | Font.UNDERLINE);
            doc.Add(new Paragraph("Detalles de lecciones                Escuela: " + usuario.IdEscuela, fuenteT));
            Font fuent = new Font();
            fuent.Size = 10;
            doc.Add(new Paragraph("Fecha y hora de realización: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + "    Usuario: " + usuario.Nombre + " " + usuario.Apellidos, fuent));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            //imagen
            string imageURL = Server.MapPath(".") + "/ccss/star-1-3/Static HTML/img/logo-dark.png";
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imageURL);

            img.ScaleToFit(125f, 60F);
            //Imagen - Movio en el eje de las Y
            img.SetAbsolutePosition(500, 750);
            doc.Add(img);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(6);
            tblPrueba.WidthPercentage = 100;

            PdfPCell clNombre;
            PdfPCell clApellido;

            Font fuente = new Font();
            fuente.Size = 12;
            fuente.SetStyle(Font.BOLD);

            clNombre = new PdfPCell(new Phrase("Nombre:  ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Fecha: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Dificultad: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Hora inicio: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Hora final: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Estado: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);
            


            foreach (Sesion usu in listaSesiones)
            {


                // Configuramos el título de las columnas de la tabla

                //Contenido
                Font fuente2 = new Font();
                fuente2.Size = 10;

                clApellido = new PdfPCell(new Phrase(usu.Nombre, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.FechaBasica, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.Dificultad, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.HraInicio1, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.HraFinal1, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.EstaActiva, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);
                

                //linea
                PdfPCell linea = new PdfPCell(new Phrase(" ", fuente));
                linea.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                linea.Colspan = 7;
                tblPrueba.AddCell(linea);



            }
            doc.Add(tblPrueba);
            //
            //Font fuente4 = new Font();
            //fuente4.Size = 10;
            //tabla precio
            //PdfPTable tblPrecio = new PdfPTable(2);
            //tblPrueba.WidthPercentage = 50;
            ////
            //PdfPCell cldetalle = new PdfPCell(new Phrase("Lecciones:  ", fuente4));
            //cldetalle.BorderWidth = 0;
            //cldetalle.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

            //
            doc.Close();
            writer.Close();

            Response.ContentType = "application/pdf";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AppendHeader("content-disposition", "attachment;filename=ReporteLecciones.pdf");
            // Response.TransmitFile("C:/Users/edu08/Downloads/prueba.pdf");
            Response.TransmitFile("C:/Users/Public/Downloads/prueba.pdf");
            Response.End();

        }

    }
}