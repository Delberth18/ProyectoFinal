﻿using iTextSharp.text;
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
            fuenteT.Size = 22;
            fuenteT.SetStyle(Font.BOLD| Font.UNDERLINE);
            fuenteT.SetFamily("helvatica");
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
          clNombre.HorizontalAlignment= PdfPCell.ALIGN_RIGHT;
          clNombre.PaddingRight = 30;



            //clNombre.BorderWidthBottom = 0.75f;
            Font fuente2 = new Font();
            fuente2.Size = 15;
            
            PdfPCell clApellido = new PdfPCell(new Phrase(lblAlumno.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 5;

            //clApellido.BorderWidthBottom = 0.75f;


            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            

            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Escuela: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            clNombre.PaddingRight = 30;
            //
            clApellido = new PdfPCell(new Phrase(lblEscuela.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 5;


            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);

            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Nivel: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            clNombre.PaddingRight = 30;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblNivel.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 5;
            tblPrueba.AddCell(clApellido);
            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Fecha: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            clNombre.PaddingRight = 30;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblFecha.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 5;
            tblPrueba.AddCell(clApellido);
            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Hora: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            clNombre.PaddingRight = 30;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblHora.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 5;
            tblPrueba.AddCell(clApellido);
            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Instructor: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            clNombre.PaddingRight = 30;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblInstructor.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 5;
            tblPrueba.AddCell(clApellido);
            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Indumentaria: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            clNombre.PaddingRight = 30;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblAlquilerDeta.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 5;
            tblPrueba.AddCell(clApellido);
            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Ubicación: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            clNombre.PaddingRight = 30;
            tblPrueba.AddCell(clNombre);
            //Dato
            clApellido = new PdfPCell(new Phrase(lblUbicación.Text, fuente2));
            clApellido.BorderWidth = 0;
            clApellido.PaddingLeft = 5;
            tblPrueba.AddCell(clApellido);
            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);
            //linea
            PdfContentByte cb = writer.DirectContent;

            cb.MoveTo(15, doc.Top - 280f);
            cb.LineTo(600, doc.Top - 280f);
            cb.Stroke();
            //
            doc.Add(Chunk.NEWLINE);
           
            
          

            //tabla precio
            PdfPTable tblPrecio = new PdfPTable(1);
            tblPrecio.WidthPercentage = 100;
            //
            
            BaseFont bf = BaseFont.CreateFont("c:/windows/fonts/arialbd.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
          
            PdfPCell cldetalle = new PdfPCell(new Phrase("Lecciones:   " + lblPrecioLec.Text, new Font(bf, 15)));
            cldetalle.BorderWidth = 0;
            cldetalle.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            tblPrecio.AddCell(cldetalle);
            
            //
            if (lblAlquilerDeta.Text != "No alquilada")
            {
                PdfPCell cldetalle1 = new PdfPCell(new Phrase("Alquiler:  " + lblPrecioAlquiler.Text, new Font(bf, 15)));
                cldetalle1.BorderWidth = 0;
                cldetalle1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                tblPrecio.AddCell(cldetalle1);
            }
            //

            PdfPCell cldetalle2 = new PdfPCell(new Phrase("Impuestos:    " + lblImpuestos.Text, new Font(bf, 15)));
            cldetalle2.BorderWidth = 0;
            cldetalle2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            tblPrecio.AddCell(cldetalle2);
            //
            PdfPCell cldetalle3 = new PdfPCell(new Phrase("Total:  " + lblTotal.Text, new Font(bf, 15)));
            cldetalle3.BorderWidth = 0;
            cldetalle3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            tblPrecio.AddCell(cldetalle3);
            //
            doc.Add(tblPrecio);
            doc.Add(Chunk.NEWLINE);
            //
           
            //
            PdfPTable tblThanks = new PdfPTable(1);
            tblThanks.WidthPercentage = 100;
            Font fuente4 = new Font();
            fuente4.Size = 35;
            PdfPCell clparrafo = new PdfPCell(new Phrase("Muchas Gracias!!", fuente4));
            clparrafo.BorderWidth = 0;
            clparrafo.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            tblThanks.AddCell(clparrafo);
            //
            doc.Add(tblThanks);
            doc.Add(Chunk.NEWLINE);
            //
            PdfPTable tblTerminos = new PdfPTable(1);
            tblTerminos.WidthPercentage = 100;
            //
            string tyc = "Al aceptar los términos usted ha leído y esta de acuerdo con el uso de la aplicación Surf Tribe System. Al reservar el administrador de la escuela en un rango de 24 horas se pondrá en contacto contigo para confirmar el deposito de reserva que deberá de realizar el usuario, con el fin de que la reserva quede en pie, si no se realizá la reserva en un plazo acordado la reserva quedará libre";
            PdfPCell clTerminos = new PdfPCell(new Phrase(tyc, _standardFont));
            clTerminos.BorderWidth = 0;
            clTerminos.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblTerminos.AddCell(clTerminos);
            doc.Add(tblTerminos);
            //
            doc.Close();
            writer.Close();
          
            Response.ContentType = "application/pdf";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AppendHeader("content-disposition", "attachment;filename=DetallesReserva.pdf");
            // Response.TransmitFile("C:/Users/edu08/Downloads/prueba.pdf");
            Response.TransmitFile("C:/Users/Public/Downloads/prueba.pdf");
            Response.End();

           


        }
    }
}
