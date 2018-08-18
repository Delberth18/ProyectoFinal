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
    public class ReservaDatos
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
                param.ParameterName = "@IDSESION";
                if (reserva.IdSesion == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = reserva.IdSesion;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@IDUSUARIO";
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
                param.ParameterName = "@TAG";
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
                    .EjecutarProcedimientoDS("SPR_RESERVA_SESION", parametros);


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

                    if (reserva.Tag == "LISTADO_PENDIENTE")
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            reservas.Add(new Reserva
                            {
                                IdSesion = row["ID_SESION"] is DBNull ? null : row["ID_SESION"].ToString(),
                                IdUsuario = row["ID_USUARIO"] is DBNull ? null : row["ID_USUARIO"].ToString(),
                                Fecha = row["FECHA"] is DBNull ?"" :row["FECHA"].ToString(),
                                NombreIns = row["NOMBRE_INS"] is DBNull ? null : row["NOMBRE_INS"].ToString(),
                                Precio = row["PRECIO"] is DBNull ? null : row["PRECIO"].ToString(),
                                NombreUsu = row["NOMBRE_USU"] is DBNull ? null : row["NOMBRE_USU"].ToString(),
                                Correo= row["CORREO"] is DBNull ? null : row["CORREO"].ToString()
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
