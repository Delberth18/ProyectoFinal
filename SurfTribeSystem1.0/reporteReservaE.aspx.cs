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
    public partial class reporteReservaE : System.Web.UI.Page
    {
       
        Usuario usu = new Usuario();
        public static List<Reserva> listaReservaF = new List<Reserva>();
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
                CargarDatos();
               

            }
        }

        public void CargarDatos()
        {
            ddlAnno.Items.Add("2018");
            ddlAnno.Items.Add("2019");
            ddlAnno.Items.Add("2020");


            ddlmes.Items.Add("Enero");
            ddlmes.Items.Add("Febrero");
            ddlmes.Items.Add("Marzo");
            ddlmes.Items.Add("Abril");
            ddlmes.Items.Add("Mayo");
            ddlmes.Items.Add("Junio");
            ddlmes.Items.Add("Julio");
            ddlmes.Items.Add("Agosto");
            ddlmes.Items.Add("Septiembre");
            ddlmes.Items.Add("Octubre");
            ddlmes.Items.Add("Noviembre");
            ddlmes.Items.Add("Diciembre");
        }

        public void CargarReserva()
        {
            string mesno;
            mesno = ddlmes.SelectedItem.ToString();
            Reserva re = new Reserva();
            Resultado resultado = new Resultado();
            switch (mesno)
            {
                case "Enero":
                    re.Dificultad= "1";
                    break;
                case "Febrero":
                    re.Dificultad = "2";
                    break;
                case "Marzo":
                    re.Dificultad = "3";
                    break;
                case "Abril":
                    re.Dificultad = "4";
                    break;
                case "Mayo":
                    re.Dificultad = "5";
                    break;
                case "Junio":
                    re.Dificultad = "6";
                    break;
                case "Julio":
                    re.Dificultad = "7";
                    break;
                case "Agosto":
                    re.Dificultad = "8";
                    break;
                case "Septiembre":
                    re.Dificultad = "9";
                    break;
                case "Octubre":
                    re.Dificultad = "10";
                    break;
                case "Noviembre":
                    re.Dificultad = "11";
                    break;
                case "Diciembre":
                    re.Dificultad = "12";
                    break;
            }
            re.Marca= ddlAnno.SelectedItem.ToString();
            //
            re.IdEscuela = usu.IdEscuela;
            re.Tag = "ALQUILERFILTRO";
            resultado = new ReporteReservaLogica().Acciones(re);
            List<Reserva> listareserva = new List<Reserva>();
            listareserva = (List<Reserva>)resultado.ObjetoResultado;



            //
            re.Tag = "SINALQUILERFILTRO";
            resultado = new ReporteReservaLogica().Acciones(re);

            List<Reserva> listareserva2 = new List<Reserva>();

            listareserva2 = (List<Reserva>)resultado.ObjetoResultado;

            foreach (Reserva res in listareserva2)
            {
                listareserva.Add(res);
            }

            if (listareserva.Count <= 0)
            {
                
                lblEti.Visible = true;
                grvreportes.DataSource = listareserva;
                grvreportes.DataBind();
                listaReservaF = listareserva;

            }
            else
            {
                grvreportes.DataSource = listareserva;
                grvreportes.DataBind();
                listaReservaF = listareserva;
                btnGenerar.Visible = true;
                lblEti.Visible = false;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarReserva();
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
            doc.AddTitle("Detalles de reservas");
            doc.AddCreator("STS");

            // Abrimos el archivo
            doc.Open();
            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            Font fuenteT = new Font();
            fuenteT.Size = 18;
            fuenteT.SetStyle(Font.BOLD | Font.UNDERLINE);
            doc.Add(new Paragraph("Detalles de reservas                Escuela: " + usu.IdEscuela, fuenteT));
            Font fuent = new Font();
            fuent.Size = 10;
            doc.Add(new Paragraph("Fecha y hora de realización: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + "    Usuario: " + usu.Nombre + " " + usu.Apellidos, fuent));
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
            PdfPTable tblPrueba = new PdfPTable(11);
            tblPrueba.WidthPercentage = 100;

            PdfPCell clNombre;
            PdfPCell clApellido;

            Font fuente = new Font();
            fuente.Size = 9;
            fuente.SetStyle(Font.BOLD);

            clNombre = new PdfPCell(new Phrase("Fecha: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Almno(a):  ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Escuela: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Dificultad: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Instr(a): ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Hra Inicio: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Alquiler: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Precio Alquiler: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Precio Clase: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Total: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Estado:  ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            PdfContentByte cb = writer.DirectContent;
            cb.MoveTo(15, doc.Top - 94f);
            cb.LineTo(600, doc.Top - 94f);
            cb.Stroke();
            foreach (Reserva usu in listaReservaF)
            {


                // Configuramos el título de las columnas de la tabla

                //Contenido
                Font fuente2 = new Font();
                fuente2.Size = 8;

                Font fuente3 = new Font();
                fuente3.Size = 7;

                Font fuente4 = new Font();
                fuente4.Size = 6;

                clApellido = new PdfPCell(new Phrase(usu.Fecha, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.NombreUsu, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.IdEscuela, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.Dificultad, fuente4));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.NombreIns, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);

                clApellido = new PdfPCell(new Phrase(usu.Horainicio, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);

                clApellido = new PdfPCell(new Phrase(usu.Marca, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);

                clApellido = new PdfPCell(new Phrase(usu.Precioreserva.ToString(), fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);

                clApellido = new PdfPCell(new Phrase(usu.PrecioCl.ToString(), fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);

                clApellido = new PdfPCell(new Phrase(usu.PrecioTotal.ToString(), fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);

                clApellido = new PdfPCell(new Phrase(usu.Estado, fuente3));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                //linea
                PdfPCell linea = new PdfPCell(new Phrase(" ", fuente));
                linea.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                linea.Colspan = 11;
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
            Response.AppendHeader("content-disposition", "attachment;filename=ReporteReserva.pdf");
            // Response.TransmitFile("C:/Users/edu08/Downloads/prueba.pdf");
            Response.TransmitFile("C:/Users/Public/Downloads/prueba.pdf");
            Response.End();

        }
    }
}