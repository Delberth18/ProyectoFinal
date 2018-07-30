using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class prueba2 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnOmitir_Click(object sender, EventArgs e)
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
            doc.AddTitle("Detalles de Reserva");
            doc.AddCreator("STS");

            // Abrimos el archivo
            doc.Open();
            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            Font fuenteT = new Font();
            fuenteT.Size = 18;
            fuenteT.SetStyle(Font.BOLD| Font.UNDERLINE);
            doc.Add(new Paragraph("Detalles de Reserva",fuenteT));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
           
            //imagen
            string imageURL = Server.MapPath(".") + "/ccss/star-1-3/Static HTML/img/logo-dark.png";
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance( imageURL);

            img.ScaleToFit(125f, 60F);
            //Imagen - Movio en el eje de las Y
            img.SetAbsolutePosition(500, 750);
            doc.Add(img);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(2);
            tblPrueba.WidthPercentage = 100;


            // Configuramos el título de las columnas de la tabla
            Font fuente = new Font();
            fuente.Size=15;
            fuente.SetStyle(Font.BOLD);

            PdfPCell clNombre = new PdfPCell(new Phrase("Alumno(a):  ", fuente));
            clNombre.BorderWidth = 0;
          clNombre.HorizontalAlignment= PdfPCell.ALIGN_CENTER;



            //clNombre.BorderWidthBottom = 0.75f;
            Font fuente2 = new Font();
            fuente2.Size = 15;
            
            PdfPCell clApellido = new PdfPCell(new Phrase(lblAlumno.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 30;

            //clApellido.BorderWidthBottom = 0.75f;


            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            

            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Escuela: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            // clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            //
            clApellido = new PdfPCell(new Phrase(lblEscuela.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 30;


            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);

            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Nivel: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblNivel.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 30;
            tblPrueba.AddCell(clApellido);
            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Fecha: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            // clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblFecha.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 30;
            tblPrueba.AddCell(clApellido);
            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Hora: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            // clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblHora.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 30;
            tblPrueba.AddCell(clApellido);
            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Instructor: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            // clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblInstructor.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 30;
            tblPrueba.AddCell(clApellido);
            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Indumentaria: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            // clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblAlquilerDeta.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 30;
            tblPrueba.AddCell(clApellido);
            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Ubicación: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            // clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblUbicación.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 30;
            tblPrueba.AddCell(clApellido);
            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);
            //linea
            PdfContentByte cb = writer.DirectContent;

            cb.MoveTo(10, doc.Top - 280f);
            cb.LineTo(600, doc.Top - 280f);
            cb.Stroke();
            //
            Font fuente4 = new Font();
            fuente4.Size = 10;
            //tabla precio
            PdfPTable tblPrecio = new PdfPTable(2);
            tblPrueba.WidthPercentage = 50;
            //
            PdfPCell cldetalle = new PdfPCell(new Phrase("Lecciones:  ", fuente4));
            cldetalle.BorderWidth = 0;
            cldetalle.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;


            //
            doc.Close();
            writer.Close();
          
            Response.ContentType = "application/pdf";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AppendHeader("content-disposition", "attachment;filename=TestPage.pdf");
            // Response.TransmitFile("C:/Users/edu08/Downloads/prueba.pdf");
            Response.TransmitFile("C:/Users/Public/Downloads/prueba.pdf");
            Response.End();

           


        }
    }
}
