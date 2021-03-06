﻿using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SurfTribeSystem1._0
{
    public partial class registroTabla : System.Web.UI.Page
    {
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
                ListarEstados();
                ListarRegistro();
            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.MasterPageFile = "~/Site2.master";
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
            Tabla tabla = new Tabla();
            Resultado resultado = new Resultado();

            string Extension = string.Empty;
            string Nombre = string.Empty;


            if (FileUpload.HasFile == false)
            {
                string script = "swal('Error', ' No puede faltar la imagen ', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                return;
            }

            Nombre = FileUpload.FileName;
            Extension = Path.GetExtension(Nombre);

            if (ValidarExtension(Extension))
            {
                tabla.Marca = txtMarca.Text;
                tabla.Tamanio = txtPies.Text + "-" + txtPulgadas.Text;
                tabla.Tipo = txtTipo.Text;
                tabla.Estado = estado.SelectedValue;
                tabla.Id_Escuela = usu.IdEscuela;

                if (Convert.ToInt32(txtPies.Text) >= 9)
                {
                    tabla.Tipo_precio = "LONG";
                }
                else
                {
                    tabla.Tipo_precio = "SHORT";
                }

                string base64ImageRepresentation = Convert.ToBase64String(FileUpload.FileBytes);

                tabla.Imagen = base64ImageRepresentation;
                tabla.Dificultad = dificultad.SelectedValue;
                tabla.Tag = "INSER_ACTUA";

            }
            else
            {
                string script = "swal('Error', ' El archivo no es de tipo imagen. ', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                return;
            }



            try
            {
                if (Validar())
                {
                    resultado = new TablaLogica().Acciones(tabla);

                    if (resultado.TipoResultado == "OK")
                    {
                        //string script = "swal('Excelente', 'Éxito en la insersión', 'success'); ";
                        //ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

                        //Limpiar();
                        //ListarRegistro();

                        Session["RegistroTabla"] = "OK";
                        Response.Redirect("mantTablas.aspx");
                    }
                    else
                    {
                        string script = "swal('Lo sentimos, ha ocurrido un error', '" + resultado.Mensaje + "', 'error'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                }
            }
            catch (Exception)
            {
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected bool Validar()
        {
            if (txtMarca.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe ingresar la marca', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtMarca.Focus();
                return false;
            }

            if (txtTipo.Text.Trim() == "")
            {
                string script = "swal('Error', ' Debe ingresar el tipo', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                txtTipo.Focus();
                return false;
            }
            return true;
        }

        protected void Limpiar()
        {
            txtMarca.Text = "";
            txtTipo.Text = "";
        }

        private void ListarEstados()
        {
            Resultado resultado = new Resultado();
            resultado = new TablaLogica().Estados();

            List<Estado> lista = (List<Estado>)resultado.ObjetoResultado;

            estado.DataSource = lista;
            estado.DataTextField = "Descripcion";
            estado.DataValueField = "Descripcion";
            estado.DataBind();
        }

        private void ListarRegistro()
        {
            Resultado resultado = new Resultado();
            try
            {
                List<Tabla> lista = new List<Tabla>();
                Tabla tab = new Tabla();
                tab.Tag = "LISTADO";
                tab.Id_Escuela = usu.IdEscuela;
                resultado = new TablaLogica().Acciones(tab);
                if (resultado.TipoResultado == "OK")
                {
                    lista = new List<Tabla>();
                    lista = (List<Tabla>)resultado.ObjetoResultado;
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

    }
}