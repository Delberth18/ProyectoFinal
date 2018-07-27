
using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaNegocio;
using SurfTribeSystem1._0.Clases;
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
        Usuario usu = new Usuario();

        string pert = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null)
            {
                usu = (Usuario)Session["InicioSesion"];

                if (usu.Tipo_usu != "ADMG")
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
                ListarRegistro();
                ListarPertenencia();
            }
            
        }
        private void borrar()
        {
            //txtDescripcion.Text = "";
           // txtFecha.Text = "";
        }
        private Boolean ValidarExtension(string sExtension)
        {
            Boolean verif = false;
            switch (sExtension)
            {
                case ".jpg":
                case ".JPG":
                case ".jpeg":
                case ".JPEG":
                case ".png":
                case ".PNG":
                case ".gif":
                case ".GIF":
                case ".bmp":
                case ".BMP":
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

                if (FileUpload.HasFile)
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
                    string script = "swal('Error', ' No puede faltar la imagen ', 'error'); ";
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
                img.Tag = "INSERTAR";
                img.Aprobado = true;
                img.Titulo = txtTitulo.Text;
                img.Leyenda = txtLeyenda.Text;
                img.Pertenece = pertenece.SelectedValue;
                img.Dueño = duenos.SelectedValue.ToUpper();

                string base64ImageRepresentation = Convert.ToBase64String(FileUpload.FileBytes);
                img.Imgs = base64ImageRepresentation;

                resultado = new ImagenLogica().Acciones(img);

                if (resultado.TipoResultado == "OK")
                {
                    ListarRegistro();
                    string script = "swal('Excelente', 'Éxito en la insersión', 'success'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    
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
                    imagenesList.DataSource = lista;
                    imagenesList.DataBind();
                    
                }
                
            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        private void ListarPertenencia()
        {
            Resultado resultado = new Resultado();
            try
            {
                List<string> lista1 = new List<string>();
                List<string> lista2 = new List<string>(); 
                List<object> lista3 = new List<object>();
                resultado = new ImagenLogica().ObtenerPertenencia();
                if (resultado.TipoResultado == "OK")
                {
                    lista3= (List<object>)resultado.ObjetoResultado;
                    lista1 = (List<string>)lista3[0];
                    lista2 = (List<string>)lista3[1];

                    foreach (string item in lista1)
                    {
                        pertenece.Items.Add(item);
                    }

                    foreach (string item in lista2)
                    {
                        duenos.Items.Add(item);
                    }
                }

            }
            catch (Exception ex)
            {
                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void imgClick(object sender, EventArgs e)
        {
            string script = "swal({ title: 'Are you sure?', text: 'Once deleted, you will not be able to recover this imaginary file!',  icon: 'warning', buttons: true, dangerMode: true, }); ";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
        }

        protected void pertenece_Click(object sender, EventArgs e)
        {
            pert = pertenece.SelectedValue;
           // pertenece.SelectedValue = pert;
        }

        
    }
}