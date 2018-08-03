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
    public partial class reporteTablas : System.Web.UI.Page
    {
        Tabla tabla = new Tabla();
        public static List<Tabla> listaTablas = new List<Tabla>();
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
                ListarTablas();
                ListarEstados();
                ListarMarcas();
                ListarTipos();
                ListarDificultad();
            }
        }

        private void ListarTablas()
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new TablaLogica().Reporte("HERMOSA RIDERS", "", "", "", "");
                if (resultado.TipoResultado == "OK")
                {
                    listaTablas = null;

                    listaTablas = new List<Tabla>();
                    listaTablas = (List<Tabla>)resultado.ObjetoResultado;
                    imagenesList.DataSource = listaTablas;
                    imagenesList.DataBind();

                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void ListarEstados()
        {
            Resultado resultado = new Resultado();
            resultado = new TablaLogica().Estados();

            List<Estado> lista = (List<Estado>)resultado.ObjetoResultado;
            lista.Add(new Estado { Descripcion = "Seleccione un estado" });

            estadoLst.DataSource = lista;
            estadoLst.DataTextField = "Descripcion";
            estadoLst.DataValueField = "Descripcion";
            estadoLst.DataBind();

            estadoLst.SelectedValue = "Seleccione un estado";
        }

        private void ListarMarcas()
        {
            Resultado resultado = new Resultado();
            resultado = new TablaLogica().Marcas();

            List<string> lista = (List<string>)resultado.ObjetoResultado;
            lista.Add("Seleccione una marca");

            marcaLst.DataSource = lista;
            marcaLst.DataBind();

            marcaLst.SelectedValue = "Seleccione una marca";
        }

        private void ListarTipos()
        {
            Resultado resultado = new Resultado();
            resultado = new TablaLogica().Tipos();

            List<string> lista = (List<string>)resultado.ObjetoResultado;
            lista.Add("Seleccione un tipo");

            tipoLst.DataSource = lista;
            tipoLst.DataBind();

            tipoLst.SelectedValue = "Seleccione un tipo";
        }

        private void ListarDificultad()
        {
            Resultado resultado = new Resultado();
            resultado = new TablaLogica().Dificultad();

            List<string> lista = (List<string>)resultado.ObjetoResultado;
            lista.Add("Seleccione la dificultad");

            dificultadLst.DataSource = lista;
            dificultadLst.DataBind();

            dificultadLst.SelectedValue = "Seleccione la dificultad";
        }


        protected void reporteTablaSurf(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {

                string marca = marcaLst.SelectedValue;
                string tipo = tipoLst.SelectedValue;
                string estado = estadoLst.SelectedValue;
                string dificultad = dificultadLst.SelectedValue;

                if (marca == "Seleccione una marca")
                {
                    marca = "";
                }
                if (tipo == "Seleccione un tipo")
                {
                    tipo = "";
                }
                if (estado == "Seleccione un estado")
                {
                    estado = "";
                }
                if (dificultad == "Seleccione la dificultad")
                {
                    dificultad = "";
                }

                resultado = new TablaLogica().Reporte(usu.IdEscuela, marca, tipo, estado, dificultad);
                if (resultado.TipoResultado == "OK")
                {
                    listaTablas = null;

                    imagenesList.DataSource = null;
                    imagenesList.DataBind();

                    listaTablas = new List<Tabla>();
                    listaTablas = (List<Tabla>)resultado.ObjetoResultado;
                    imagenesList.DataSource = listaTablas;
                    imagenesList.DataBind();

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
            doc.Add(new Paragraph("Detalles de tablas de surf              Escuela: " + usu.IdEscuela, fuenteT));
            Font fuent = new Font();
            fuent.Size = 10;
            doc.Add(new Paragraph("Hora y hora de realización: "+DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")+ "    Usuario: " + usu.Nombre +" "+usu.Apellidos, fuent));
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

            foreach (Tabla tab in listaTablas)
            {
                iTextSharp.text.Image gif = null;
                string base64string = tab.Imagen;
                Byte[] bytes = Convert.FromBase64String(base64string);
                gif = iTextSharp.text.Image.GetInstance(bytes);
                gif.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
                gif.Border = iTextSharp.text.Rectangle.NO_BORDER;
                gif.BorderColor = iTextSharp.text.BaseColor.WHITE;
                gif.ScaleToFit(170f, 100f);

                clNombre = new PdfPCell(gif);
                clNombre.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                clNombre.Colspan = 6;
                tblPrueba.AddCell(clNombre);

                // Configuramos el título de las columnas de la tabla
                Font fuente = new Font();
                fuente.Size = 14;
                fuente.SetStyle(Font.BOLD);

                clNombre = new PdfPCell(new Phrase("Marca:  ", fuente));
                clNombre.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clNombre);

                clNombre = new PdfPCell(new Phrase("Tamaño: ", fuente));
                clNombre.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clNombre);

                clNombre = new PdfPCell(new Phrase("Tipo: ", fuente));
                clNombre.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clNombre);

                clNombre = new PdfPCell(new Phrase("Dificultad: ", fuente));
                clNombre.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clNombre);

                clNombre = new PdfPCell(new Phrase("Estado: ", fuente));
                clNombre.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clNombre);

                clNombre = new PdfPCell(new Phrase("Precio: ", fuente));
                clNombre.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clNombre);

                //Contenido
                Font fuente2 = new Font();
                fuente2.Size = 12;

                clApellido = new PdfPCell(new Phrase(tab.Marca, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(tab.Tamanio, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(tab.Tipo, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(tab.Dificultad, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(tab.Estado, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(tab.Costo.ToString() + " colones", fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                //linea
                PdfPCell linea = new PdfPCell(new Phrase(" ", fuente));
                linea.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                linea.Colspan = 6;
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
            Response.AppendHeader("content-disposition", "attachment;filename=ReporteTablasSurf.pdf");
            // Response.TransmitFile("C:/Users/edu08/Downloads/prueba.pdf");
            Response.TransmitFile("C:/Users/Public/Downloads/prueba.pdf");
            Response.End();

        }


    }
}