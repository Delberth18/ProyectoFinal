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
    public partial class reporteUsuarioE : System.Web.UI.Page
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();
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
                ListarUsuarios();
            }
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.MasterPageFile = "~/Site2.master";
        }


        private void ListarUsuarios()
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new UsuarioLogica().Reporte("", usuario.IdEscuela, "");
                if (resultado.TipoResultado == "OK")
                {
                    listaUsuarios = null;

                    imagenesList.DataSource = null;
                    imagenesList.DataBind();

                    listaUsuarios = new List<Usuario>();
                    listaUsuarios = (List<Usuario>)resultado.ObjetoResultado;
                    imagenesList.DataSource = listaUsuarios;
                    imagenesList.DataBind();

                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }




        protected void reporteEscuela(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {
                string pais = paisLst.SelectedValue;
                string estado = estadoLst.SelectedValue;


                if (pais == "Seleccione un país")
                {
                    pais = "";
                }
                if (estado == "Seleccione un estado")
                {
                    estado = "";
                }

                resultado = new UsuarioLogica().Reporte(pais, usuario.IdEscuela, estado);
                if (resultado.TipoResultado == "OK")
                {
                    listaUsuarios = null;

                    imagenesList.DataSource = null;
                    imagenesList.DataBind();

                    listaUsuarios = new List<Usuario>();
                    listaUsuarios = (List<Usuario>)resultado.ObjetoResultado;
                    imagenesList.DataSource = listaUsuarios;
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
            doc.Add(new Paragraph("Detalles de usuarios                Escuela: " + usuario.IdEscuela, fuenteT));
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
            PdfPTable tblPrueba = new PdfPTable(7);
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

            clNombre = new PdfPCell(new Phrase("Apellidos: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Teléfono: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Correo: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Tipo usuario: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Estado: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);

            clNombre = new PdfPCell(new Phrase("Escuela: ", fuente));
            clNombre.BorderWidth = 0;
            clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            tblPrueba.AddCell(clNombre);


            foreach (Usuario usu in listaUsuarios)
            {


                // Configuramos el título de las columnas de la tabla

                //Contenido
                Font fuente2 = new Font();
                fuente2.Size = 10;

                clApellido = new PdfPCell(new Phrase(usu.Nombre, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.Apellidos, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.Telefono, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.Correo, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.Tipo_usu_dsc, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);


                clApellido = new PdfPCell(new Phrase(usu.Estado, fuente2));
                clApellido.BorderWidth = 0;
                clNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                tblPrueba.AddCell(clApellido);

                clApellido = new PdfPCell(new Phrase(usu.Escuela_dsc, fuente2));
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
            Response.AppendHeader("content-disposition", "attachment;filename=ReporteUsuarios.pdf");
            // Response.TransmitFile("C:/Users/edu08/Downloads/prueba.pdf");
            Response.TransmitFile("C:/Users/Public/Downloads/prueba.pdf");
            Response.End();

        }

    }
}