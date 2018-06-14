using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class RegistroImagenes : System.Web.UI.Page
    {
        Imagen img = new Imagen();
        List<Imagen> lista = new List<Imagen>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarRegistro();
        }
        private void borrar()
        {
            txtDescripcion.Text = "";
            txtFecha.Text = "";
        }
        private Boolean ValidarExtension(string sExtension)
        {
            Boolean verif = false;
            switch (sExtension)
            {
                case ".jpg":
                case ".jpeg":
                case ".png":
                case ".gif":
                case ".bmp":
                    verif = true;
                    break;
                default:
                    verif = false;
                    break;
            }
            return verif;
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Extension = string.Empty;
                string Nombre = string.Empty;

                if (txtDescripcion.Text != "" && txtFecha.Text != "" && FileUpload.HasFile)
                {
                    Nombre = FileUpload.FileName;
                    Extension = Path.GetExtension(Nombre);

                    if (ValidarExtension(Extension))
                    {
                        Guardar();

                    }
                    else
                    {
                        string script = "swal('Error', ' El archivo no es de tipo imagen. ', 'error'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                }
                else
                {
                    string script = "swal('Error', ' No puede faltar nigún dato ', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }
        private void Guardar()
        {
            Resultado resultado = new Resultado();
            try
            {
                img.Fecha = Convert.ToDateTime(txtFecha.Text);
                img.Descripcion = txtDescripcion.Text;
                img.Tag = "INSERTAR";
                img.Imagen2 = FileUpload.FileBytes;

                resultado = new ImagenLogica().Acciones(img);

                if (resultado.TipoResultado == "OK")
                {
                    string script = "swal('Excelente', 'Éxito en el borrado', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    borrar();
                    panelMostrar.Visible = true;
                    panelRegistrar.Visible = false;
                    ListarRegistro();
                }
                else
                {
                    string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }


            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }
        private void ListarRegistro()
        {
            Resultado resultado = new Resultado();
            try
            {
                img.Tag = "LISTADO";
                resultado = new ImagenLogica().Acciones(img);
                if (resultado.TipoResultado == "OK")
                {
                    lista = new List<Imagen>();
                    lista = (List<Imagen>)resultado.ObjetoResultado;
                    gridListado.DataSource = lista;
                    gridListado.DataBind();
                    Session["IMAGEN"] = lista;
                }
                
            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }
        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            panelRegistrar.Visible = true;
            panelMostrar.Visible = false;
        }
        protected void gridListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                gridListado.PageIndex = e.NewPageIndex;
                gridListado.DataBind();
                ListarRegistro();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}