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
    public partial class reservaSesion : System.Web.UI.Page
    {
        Usuario usure = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            usure= (Usuario)Session["InicioSesion"];
            if (!IsPostBack) {

                CargarDatos();
                txtCupos.Text = "0";
            }

        }

        public void CargarDatos()
        {
            ddlHi.Items.Add("Seleccione Hora Inicio");
            ddlHi.Items.Add("6:00 AM");
            ddlHi.Items.Add("7:00 AM");
            ddlHi.Items.Add("8:00 AM");
            ddlHi.Items.Add("9:00 AM");
            ddlHi.Items.Add("10:00 AM");
            ddlHi.Items.Add("11:00 AM");
            ddlHi.Items.Add("12:00 MD");
            ddlHi.Items.Add("1:00 PM");
            ddlHi.Items.Add("2:00 PM");

            ddlHf.Items.Add("Seleccione Hora Final");
            ddlHf.Items.Add("7:00 AM");
            ddlHf.Items.Add("8:00 AM");
            ddlHf.Items.Add("9:00 AM");
            ddlHf.Items.Add("10:00 AM");
            ddlHf.Items.Add("11:00 AM");
            ddlHf.Items.Add("12:00 MD");
            ddlHf.Items.Add("1:00 PM");
            ddlHf.Items.Add("2:00 PM");


            ddlDificultad.Items.Add("Seleccione Dificultad");
            ddlDificultad.Items.Add("Principiante");
            ddlDificultad.Items.Add("Intermedio");
            ddlDificultad.Items.Add("Avanzado");

            List<string> fechas = new List<string>();
            fechas.Add("Seleccione una fecha");
            DateTime fecha = new DateTime();

            for (int i = 1; i < 8; i++)
            {
                fecha = DateTime.Now.AddDays(i + 4);
                fechas.Add(fecha.ToString("dd/MM/yyyy"));

            }
            ddlfecha.DataSource = fechas;
            ddlfecha.DataBind();

            Resultado resultado = new Resultado();
            try
            {

                Usuario usu = new Usuario();
                List<Usuario> usuarios = new List<Usuario>(); 

                usu.Tag = "TODOS_TIPO_USUARIO";
                usu.IdEscuela = usure.IdEscuela;
                usu.Tipo_usu = "INS";

                resultado = new ReporteUsuarioLogica().Acciones(usu);

                if (resultado.TipoResultado == "OK")
                {
                    usuarios = (List<Usuario>)resultado.ObjetoResultado;
                    usuarios.Add(new Usuario { Nc = "Seleccione un Instructor(a)", Correo= "Seleccione un Instructor(a)" });

                    ddlIns.DataSource = usuarios;
                    foreach (Usuario  usuaddl in usuarios)
                    {

                       string nombre = usuaddl.Nombre + " " + usuaddl.Apellidos;

                        ddlIns.SelectedValue = "Seleccione un Instructor(a)";
                        ddlIns.DataTextField = "Nc";
                        ddlIns.DataValueField = "Correo";
                        

                    }
                    ddlIns.DataBind();
                   
                }
                else
                {
                    string script = "swal('Error', '', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {

                string script = "swal('Error', '" + ex + "', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            Sesion sesion = new Sesion();
            sesion.Habilitadas = Convert.ToInt32(txtCupos.Text);//Cupos
            sesion.HraInicio1 = ddlHi.SelectedItem.ToString();//Hora de Inicio
            sesion.HraFinal1 = ddlHf.SelectedItem.ToString();//Hora de finalizacion
            sesion.Dificultad = ddlDificultad.SelectedItem.ToString();//Dificultad
            sesion.IdEscuela = usure.IdEscuela;//IdEscuela
            sesion.Activa = true;
            sesion.Id_instructor = ddlIns.SelectedValue;
            try
            {
                sesion.Fecha = Convert.ToDateTime(ddlfecha.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                string script = "swal('Error', 'Debe elegir una fecha', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

            }


            if (sesion.Habilitadas <= 0)
            {

                string script = "swal('Error', 'Los cupos deben de ser mayores a 0', 'error'); ";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
            else {

                if (sesion.HraInicio1 == "Seleccione Hora Inicio")
                {

                    string script = "swal('Error', 'Selecciona una hora de inicio', 'error'); ";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
                else {

                    if (sesion.HraFinal1 == "Seleccione Hora Final")
                    {

                        string script = "swal('Error', 'Selecciona una hora de finalización', 'error'); ";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                    else {

                        if (sesion.Dificultad == "Seleccione Dificultad")
                        {

                            string script = "swal('Error', 'Selecciona una dificultad', 'error'); ";
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        }
                        else {


                            if (sesion.Id_instructor == "Seleccione un Instructor(a)")
                            {

                                string script = "swal('Error', 'Selecciona un Instructor(a)', 'error'); ";
                                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                            }
                            else {

                                int mes= sesion.Fecha.Month;



                            }



                        }



                    }


                }


            }



            
        }
    }
}