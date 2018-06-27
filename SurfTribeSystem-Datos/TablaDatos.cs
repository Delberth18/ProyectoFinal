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
    public class TablaDatos
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
                if (tabla.Id == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Id;
                }
                param.ParameterName = "@ID";
                parametros.Add(param);

                param = new SqlParameter();
                if (tabla.Marca == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Marca;
                }
                param.ParameterName = "@MARCA";
                parametros.Add(param);


                param = new SqlParameter();
                if (tabla.Tamanio == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Tamanio;
                }
                param.ParameterName = "@TAMANIO";
                parametros.Add(param);

                param = new SqlParameter();
                if (tabla.Tipo == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Tipo;
                }
                param.ParameterName = "@TIPO";
                parametros.Add(param);
                

                param = new SqlParameter();
                if (tabla.Estado == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Estado;
                }
                param.ParameterName = "@ESTADO";
                parametros.Add(param);

                param = new SqlParameter();
                if (tabla.Id_Esciela == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Id_Esciela;
                }
                param.ParameterName = "@ID_ESCUELA";
                parametros.Add(param);

                param = new SqlParameter();
                if (tabla.Imagen == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Imagen;
                }
                param.ParameterName = "@IMAGEN";
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
                if (tabla.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Tag;
                }
                param.ParameterName = "@TAG";
                parametros.Add(param);

                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_TABLA", parametros);


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
                    if ((tabla.Tag == "POR_ID" || tabla.Tag == "POR_NIVEL_ESCUELA" || tabla.Tag == "LISTADO") && datos.Tables[1] != null && datos.Tables[1].Rows.Count != 0)
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {

                            lista.Add(new Tabla
                            {
                                Id = row["ID"] is DBNull ? null : row["ID"].ToString(),
                                Tipo = row["TIPO"] is DBNull ? null : row["TIPO"].ToString(),
                                Estado = row["ESTADO"] is DBNull ? null : row["ESTADO"].ToString(),
                                Id_Esciela = row["ID_ESCUELA"] is DBNull ? null : row["ID_ESCUELA"].ToString(),
                                Imagen = row["IMAGEN"] is DBNull ? null : row["IMAGEN"].ToString(),
                                Dificultad = row["DIFICULTAD"] is DBNull ? null : row["DIFICULTAD"].ToString(),
                                Tamanio = row["TAMANIO"] is DBNull ? null : row["TAMANIO"].ToString(),
                                Marca = row["MARCA"] is DBNull ? null : row["MARCA"].ToString(),
                                NombreEscuela= row["NOMBRE"] is DBNull ? null : row["NOMBRE"].ToString()
                            });

                        }
                    }
                    else if (tabla.Tag == "INSER_ACTUA")
                    {
                        resultado.TipoResultado = "OK";
                    }
                    else
                    {
                        resultado.TipoResultado = "ERROR";
                        resultado.Mensaje = "No existe ningún elemento";
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
