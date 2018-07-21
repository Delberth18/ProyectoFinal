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
    public class AlquilerTablaDatos
    {
        public Resultado Acciones(Tabla tabla)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

                param = new SqlParameter();
                if (tabla.Id_Escuela == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Id_Escuela;
                }
                param.ParameterName = "@ID_ESCUELA";
                parametros.Add(param);

               

                param = new SqlParameter();
                if (tabla.Dificultad == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Dificultad;
                }
                param.ParameterName = "@DIFICULTAD";
                parametros.Add(param);

              
                param = new SqlParameter();
                DateTime fecha = DateTime.Now;
                param.Value =  fecha ;
                param.ParameterName = "@FECHA";
                parametros.Add(param);

                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_TABLA_DISPONIBLE", parametros);

                

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
                    List<Tabla> lista = new List<Tabla>();
                   
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {

                            lista.Add(new Tabla
                            {
                                Id = row["ID"] is DBNull ? null : row["ID"].ToString(),
                                Tipo = row["TIPO"] is DBNull ? null : row["TIPO"].ToString(),
                                Estado = row["ESTADO"] is DBNull ? null : row["ESTADO"].ToString(),
                                Id_Escuela = row["ID_ESCUELA"] is DBNull ? null : row["ID_ESCUELA"].ToString(),
                                Imagen = row["IMAGEN"] is DBNull ? null : row["IMAGEN"].ToString(),
                                Dificultad = row["DIFICULTAD"] is DBNull ? null : row["DIFICULTAD"].ToString(),
                                Tamanio = row["TAMANIO"] is DBNull ? null : row["TAMANIO"].ToString(),
                                Marca = row["MARCA"] is DBNull ? null : row["MARCA"].ToString(),
                                Tipo_precio = row["TIPO_PRECIO"] is DBNull ? null : row["TIPO_PRECIO"].ToString(),
                                Costo = row["PRECIO"] is DBNull ? 0 : Convert.ToInt32(row["PRECIO"])

                            });

                        }
                    
                    resultado.ObjetoResultado = lista;

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
