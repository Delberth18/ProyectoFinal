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
    public partial class registroPrecios : System.Web.UI.Page
    {
        Precio precio = new Precio();
        List<Precio> precios = new List<Precio>();
        Usuario usu = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["InicioSesion"] != null)
            {
                usu = (Usuario)Session["InicioSesion"];

                if(usu.Tipo_usu!="ADM"){
                    Response.Redirect("defaultSinLogeoUN.aspx");
                }
            }
            else
            {
                Response.Redirect("defaultSinLogeoUN.aspx");
            }
                if (!IsPostBack)
            {
                ObtenerListado();
            }
            
        }

        private void ObtenerListado()
        {
            Resultado resultado = new Resultado();
            try
            {
                precio.Tag = "LISTADO";
                precio.IdEscuela = usu.IdEscuela;
                resultado = new PrecioLogica().Acciones(precio);
                if (resultado.TipoResultado == "OK")
                {
                    precios = (List<Precio>)resultado.ObjetoResultado;

                    foreach (Precio pre in precios)
                    {
                        switch (pre.Tipo)
                        {
                            case "PRINCIPIANTE":
                                txtCostoPrincipiante.Text = pre.PrecioD.ToString();
                                txtDscPrincipiante.Text = pre.Descripcion;
                                break;

                            case "INTERMEDIO":
                                txtCostoIntermedio.Text = pre.PrecioD.ToString();
                                txtDscIntermedio.Text = pre.Descripcion;
                                break;

                            case "AVANZADO":
                                txtCostoAvanzado.Text = pre.PrecioD.ToString();
                                txtDscAvanzado.Text = pre.Descripcion;
                                break;

                            case "SHORT":
                                txtCostoShortBoard.Text = pre.PrecioD.ToString();
                                txtDscShortBoard.Text = pre.Descripcion;
                                break;

                            case "LONG":
                                txtCostoLongBoard.Text = pre.PrecioD.ToString();
                                txtDscLongBoard.Text = pre.Descripcion;
                                break;
                        }
                    }

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

        protected void GuardarPrincipiante(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            Precio preG = new Precio();
            try
            {
                preG.PrecioD = Convert.ToDouble(txtCostoPrincipiante.Text);
                preG.Descripcion = txtDscPrincipiante.Text;
                preG.Tipo = "PRINCIPIANTE";
                preG.IdEscuela = usu.IdEscuela;
                preG.Tag = "INSER_ACTUA";
                resultado = new PrecioLogica().Acciones(preG);

                if (resultado.TipoResultado == "OK")
                {
                    ObtenerListado();
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
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void GuardarIntermedio(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            Precio preG = new Precio();
            try
            {
                preG.PrecioD = Convert.ToDouble(txtCostoIntermedio.Text);
                preG.Descripcion = txtDscIntermedio.Text;
                preG.Tipo = "INTERMEDIO";
                preG.IdEscuela = usu.IdEscuela;
                preG.Tag = "INSER_ACTUA";
                resultado = new PrecioLogica().Acciones(preG);

                if (resultado.TipoResultado == "OK")
                {
                    ObtenerListado();
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
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void GuardarAvanzado(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            Precio preG = new Precio();
            try
            {
                preG.PrecioD = Convert.ToDouble(txtCostoAvanzado.Text);
                preG.Descripcion = txtDscAvanzado.Text;
                preG.Tipo = "AVANZADO";
                preG.IdEscuela = usu.IdEscuela;
                preG.Tag = "INSER_ACTUA";
                resultado = new PrecioLogica().Acciones(preG);

                if (resultado.TipoResultado == "OK")
                {
                    ObtenerListado();
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
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void GuardarShort(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            Precio preG = new Precio();
            try
            {
                preG.PrecioD = Convert.ToDouble(txtCostoShortBoard.Text);
                preG.Descripcion = txtDscShortBoard.Text;
                preG.Tipo = "SHORT";
                preG.IdEscuela = usu.IdEscuela;
                preG.Tag = "INSER_ACTUA";
                resultado = new PrecioLogica().Acciones(preG);

                if (resultado.TipoResultado == "OK")
                {
                    ObtenerListado();
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
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        protected void GuardarLong(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            Precio preG = new Precio();
            try
            {
                preG.PrecioD = Convert.ToDouble(txtCostoLongBoard.Text);
                preG.Descripcion = txtDscPrincipiante.Text;
                preG.Tipo = "LONG";
                preG.IdEscuela = usu.IdEscuela;
                preG.Tag = "INSER_ACTUA";
                resultado = new PrecioLogica().Acciones(preG);

                if (resultado.TipoResultado == "OK")
                {
                    ObtenerListado();
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
                string script = "swal('Error', 'Lo sentimos por lo sucedido', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }
    }
}