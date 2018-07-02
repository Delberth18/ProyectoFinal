using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Datos
{
    public class SesionDatos
    {
        public Resultado Acciones(Sesion sesion) {

            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();
            DateTime Compara = new DateTime();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

                param = new SqlParameter();
                if (sesion.Dificultad == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = sesion.Dificultad;
                }
                param.ParameterName = "@DIFICULTAD"; //Dificultad
                parametros.Add(param);


                param = new SqlParameter();
                if (sesion.IdEscuela == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = sesion.IdEscuela;
                }
                param.ParameterName = "@ID_ESCUELA"; //IdEscuela
                parametros.Add(param);


                //param = new SqlParameter();
                //if (sesion.Activa.ToString() == null)
                //{
                  //  param.Value = DBNull.Value;
                //}
                //else
                //{
                  //  param.Value = sesion.Activa;
                //}
                //param.ParameterName = "@ACTIVA";// activa
                //parametros.Add(param);

               
                param = new SqlParameter();
                if (sesion.Fecha== Compara)
                {
                    param.Value = DateTime.Now;
                }
                else
                {
                    param.Value = sesion.Fecha;
                }
                param.ParameterName = "@FECHA";//fecha
                parametros.Add(param);


                param = new SqlParameter();
                if (sesion.HraInicio1== Compara)
                {
                    param.Value = DateTime.Now;
                }
                else
                {
                    param.Value = sesion.HraInicio1;
                }
                param.ParameterName = "@HORA_INICIO"; //hora de inicio
                parametros.Add(param);

                param = new SqlParameter();
                if (sesion.HraFinal1== Compara)
                {
                    param.Value = DateTime.Now;
                }
                else
                {
                    param.Value = sesion.HraFinal1;
                }
                param.ParameterName = "@HORA_FINAL";//hora final
                parametros.Add(param);

                param = new SqlParameter();
                if (sesion.Reservadas.ToString()== null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value =  sesion.Reservadas;
                }
                param.ParameterName = "@RESERVADAS";//Reservadas
                parametros.Add(param);

                param = new SqlParameter();
                if (sesion.Habilitadas.ToString() == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = sesion.Habilitadas;
                }
                param.ParameterName = "@HABILITADAS"; //habilitadas
                parametros.Add(param);


                param = new SqlParameter();
                if (sesion.Id == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = sesion.Id;
                }
                param.ParameterName = "@ID";//id
                parametros.Add(param);


                param = new SqlParameter();
                if (sesion.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = sesion.Tag;
                }
                param.ParameterName = "@TAG";
                parametros.Add(param);

                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_SESION", parametros);


                if (datos.Tables[0].Rows[0]["RESULTADO"].ToString() == "ERROR")
                {
                    resultado.TipoResultado = "ERROR";
                    resultado.CodigoMensaje = datos.Tables[0].Rows[0]["CODIGO"].ToString();
                    resultado.Mensaje = datos.Tables[0].Rows[0]["MENSAJE"].ToString();
                    resultado.ObjetoResultado = null;
                }
                else
                {
                    if (datos.Tables[1] != null && datos.Tables[1].Rows.Count != 0)
                    {
                        resultado.TipoResultado = "OK";

                        List<Sesion> lista = new List<Sesion>();

                        foreach (DataRow row in datos.Tables[1].Rows)
                        {


                            lista.Add(new Sesion
                            {
                                Id = row["ID"] is DBNull ? null : row["ID"].ToString(),
                                Dificultad = row["DIFICULTAD"] is DBNull ? null : row["DIFICULTAD"].ToString(),
                                Fecha =  row["FECHA"] is DBNull ? DateTime.MinValue : Convert.ToDateTime(row["FECHA"]), 
                                Habilitadas= row["HABILITADAS"] is DBNull ? 0 : Convert.ToInt32(row["HABILITADAS"]),
                                Reservadas = row["RESERVADAS"] is DBNull ? 0 : Convert.ToInt32(row["RESERVADAS"]),
                                HraInicio1 = row["HORA_INICIO"] is DBNull ? DateTime.MinValue : Convert.ToDateTime(row["HORA_INICIO"]),
                                HraFinal1 = row["HORA_FINAL"] is DBNull ? DateTime.MinValue : Convert.ToDateTime(row["HORA_FINAL"]),
                                IdEscuela = row["ID_ESCUELA"] is DBNull ? null : row["ID_ESCUELA"].ToString()
                                


                            });
                        }

                        resultado.ObjetoResultado = lista;
                    }

                }


                return resultado;


            }
            catch (Exception ex)
            {
                throw ex;
            }


        }




    }
}
