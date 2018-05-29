using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class ComentariosListado : System.Web.UI.Page
    {
        Comentario comentario = new Comentario();
        List<Comentario> comentarios = new List<Comentario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ObtenerListado();
        }

        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                comentario.Tag = "LISTADO_APROBADO";
                resultado = new ComentarioLogica().ListadoAprobado(comentario);
                if (resultado.TipoResultado == "OK")
                {
                    comentarios = (List<Comentario>)resultado.ObjetoResultado;
                    preguntasLst.DataSource = comentarios;
                    preguntasLst.DataBind();
                }
                else
                {
                    Response.Write("< script > alert('Error: " + resultado.Mensaje + " \n Lo sentimos') </ script >");
                }
            }
            catch (Exception ex)
            {

                Response.Write("< script > alert('Error: " + ex + " \n Lo sentimos') </ script >");
            }
        }

    }
}