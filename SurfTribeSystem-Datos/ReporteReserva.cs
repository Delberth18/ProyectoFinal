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
   public class ReporteReserva
    {
        public Resultado Acciones(Reserva reserva)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

              
                param = new SqlParameter();
                param.ParameterName = "@ID_USUARIO";
                if (reserva.IdUsuario == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = reserva.IdUsuario;
                }
                parametros.Add(param);
                //
                param = new SqlParameter();
                param.ParameterName = "@ID_ESCUELA";
                if (reserva.IdEscuela == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = reserva.IdEscuela;
                }
                parametros.Add(param);
                //
                param = new SqlParameter();
                param.ParameterName = "@MES";
                if (reserva.Dificultad == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = reserva.Dificultad;
                }
                parametros.Add(param);
                //
                param = new SqlParameter();
                param.ParameterName = "@ANNO";
                if (reserva.Marca == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = reserva.Marca;
                }
                parametros.Add(param);
                //
                param = new SqlParameter();
                param.ParameterName = "@TIPO_CONSULTA";
                if (reserva.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = reserva.Tag;
                }
                parametros.Add(param);
                #endregion

                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_REPORTE_RESERVA", parametros);


                if (datos.Tables[0].Rows[0]["RESULTADO"].ToString() == "ERROR")
                {
                    resultado.TipoResultado = "ERROR";
                    resultado.CodigoMensaje = datos.Tables[0].Rows[0]["CODIGO"].ToString();
                    resultado.Mensaje = datos.Tables[0].Rows[0]["MENSAJE"].ToString();
                    resultado.ObjetoResultado = null;
                }
                else
                {
                    resultado.TipoResultado = "OK";
                    List<Reserva> reservas = new List<Reserva>();

                    if (reserva.Tag == "SINALQUILER"|| reserva.Tag == "SINALQUILERFILTRO")
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            reservas.Add(new Reserva
                            {
                                Dificultad = row["DIFICULTAD"] is DBNull ? null : row["DIFICULTAD"].ToString(),
                                Fecha = row["FECHA"] is DBNull ? "" :Convert.ToDateTime( row["FECHA"].ToString()).ToShortDateString(),
                                Horainicio = row["HORA_INICIO"] is DBNull ? null : row["HORA_INICIO"].ToString(),
                                IdEscuela = row["ID_ESCUELA"] is DBNull ? null : row["ID_ESCUELA"].ToString(),
                                NombreUsu = row["NC"] is DBNull ? null : row["NC"].ToString(),
                                Precio = row["PRECIO"] is DBNull ? null : row["PRECIO"].ToString(),
                                PrecioCl = row["PRECIO"] is DBNull ? 0 : Convert.ToDouble(row["PRECIO"]),
                                NombreIns = row["ins"] is DBNull ? null : row["ins"].ToString(),
                                Estado = row["ESTADO"] is DBNull ? null : row["ESTADO"].ToString(),
                                Marca = "NO alquilada",
                                Precioreserva = 0,
                                PrecioTotal = row["PRECIO"] is DBNull ? 0 : Convert.ToDouble(row["PRECIO"])



                            });
                        }
                    }
                    if (reserva.Tag == "ALQUILER"|| reserva.Tag == "ALQUILERFILTRO")
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            reservas.Add(new Reserva
                            {
                                Dificultad = row["DIFICULTAD"] is DBNull ? null : row["DIFICULTAD"].ToString(),
                                Fecha = row["FECHA"] is DBNull ? "" : Convert.ToDateTime(row["FECHA"].ToString()).ToShortDateString(),
                                Horainicio = row["HORA_INICIO"] is DBNull ? null : row["HORA_INICIO"].ToString(),
                                IdEscuela = row["ID_ESCUELA"] is DBNull ? null : row["ID_ESCUELA"].ToString(),
                                NombreUsu = row["NC"] is DBNull ? null : row["NC"].ToString(),
                                Precio = row["PRECIO"] is DBNull ? null : row["PRECIO"].ToString(),
                                PrecioCl= row["PRECIO"] is DBNull ? 0 : Convert.ToDouble(row["PRECIO"]),
                                NombreIns = row["ins"] is DBNull ? null : row["ins"].ToString(),
                                Estado = row["ESTADO"] is DBNull ? null : row["ESTADO"].ToString(),
                                Marca= row["MARCA"] is DBNull ? null : row["MARCA"].ToString(),
                                Precioreserva = row["COSTO"] is DBNull ? 0 : Convert.ToDouble(row["COSTO"]),
                                PrecioTotal = row["total"] is DBNull ? 0 : Convert.ToDouble(row["total"])
                                


                            });
                        }
                    }


                    resultado.ObjetoResultado = reservas;

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
