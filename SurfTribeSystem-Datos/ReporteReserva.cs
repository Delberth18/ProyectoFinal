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

                    if (reserva.Tag == "ALQUILER" || reserva.Tag == "SINALQUILER")
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            reservas.Add(new Reserva
                            {
                                Dificultad= row["DIFICULTAD"] is DBNull ? null : row["DIFICULTAD"].ToString(),
                                Fecha = row["FECHA"] is DBNull ? "" : row["FECHA"].ToString(),
                                Horainicio = row["HORA_INICIO"] is DBNull ? null : row["HORA_INICIO"].ToString(),
                                IdEscuela = row["ID_ESCUELA"] is DBNull ? null : row["ID_SESION"].ToString(),
                                NombreUsu = row["NC"] is DBNull ? null : row["NC"].ToString(),
                                Precio = row["PRECIO"] is DBNull ? null : row["PRECIO"].ToString(),
                                NombreIns = row["ins"] is DBNull ? null : row["ins"].ToString(),
                                Estado = row["ESTADO"] is DBNull ? null : row["ESTADO"].ToString(),
                              
                               
                               
                                
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
