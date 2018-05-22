using SurfTribeSystem_Entidades;
using SurfTribeSystem_LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurfTribeSystem1._0
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void ingresarButton_Click(object sender, EventArgs e)
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

                if (resultado.TipoResultado == "OK")
                {
                    Response.Redirect("defaultConLogeoUN.aspx");
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