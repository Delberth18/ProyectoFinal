using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaDeNegocios;
using SurfTribeSystem_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class defaultSinLogeo : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            ListarRegistro();
        }

        protected void ingresoButton_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            try
            {
                

                Credencial credencial = new Credencial()
                {
                    ClaveUsuario = claveText.Text,
                    CorreoUsuario = correoText.Text
                };
                resultado = new SeguridadLogica().ValidarUsuario(credencial);

                if (resultado.TipoResultado=="OK")
                {
                    Response.Redirect("defaultConLogeoUN.aspx");
                }
                else
                {
                    Response.Write("< script > alert('Error: " +resultado.Mensaje+ " \n Lo sentimos') </ script >");
                }
            }
            catch (Exception ex)
            {

                Response.Write("< script > alert('Error: "+ ex+" \n Lo sentimos') </ script >");
            }
            
        }

        private void ListarRegistro()
        {
            Resultado resultado = new Resultado();
            Imagen img = new Imagen();
            List<Imagen> lista = new List<Imagen>();
            try
            {
                img.Tag = "LISTADOESPECIFICO";
                img.Pertenece = "PaginaPrincipal";
                resultado = new ImagenLogica().Acciones(img);
                if (resultado.TipoResultado == "OK")
                {
                    lista = new List<Imagen>();
                    lista = (List<Imagen>)resultado.ObjetoResultado;
                    galeria.DataSource = lista;
                    galeria.DataBind();

                    //imagenesList.DataSource = lista;
                    //imagenesList.DataBind();
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