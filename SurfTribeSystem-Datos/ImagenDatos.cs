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
    public class ImagenLogica
    {
        public Resultado Acciones(Imagen img)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

                param = new SqlParameter();
                param.Value = img.Codigo;
                param.ParameterName = "@CODIGO";
                parametros.Add(param);



                param = new SqlParameter();
                if (img.Descripcion == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = img.Descripcion;
                }
                param.ParameterName = "@DESCRIPCION";
                parametros.Add(param);

                param = new SqlParameter();
                if (img.Imagen2 == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = img.Imagen2;
                }
                param.ParameterName = "@IMAGEN";
                parametros.Add(param);



                param = new SqlParameter();
                if (img.Fecha == DateTime.MinValue)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = img.Fecha;
                }
                param.ParameterName = "@FECHA";
                parametros.Add(param);

                param = new SqlParameter();
                if (img.Pertenece == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = img.Pertenece;
                }
                param.ParameterName = "@PERTENECE";
                parametros.Add(param);
                

                param = new SqlParameter();
                if (img.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = img.Tag;
                }
                param.ParameterName = "@TAG";
                parametros.Add(param);

                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_IMAGEN", parametros);


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
                    List<Imagen> lista = new List<Imagen>();
                    if (img.Tag == "LISTADO" && datos.Tables[1] != null && datos.Tables[1].Rows.Count != 0)
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            lista.Add(new Imagen
                            {
                                Codigo = row["CODIGO"] is DBNull ? 0 : Convert.ToInt32(row["PREGUNTA"].ToString()),
                                Descripcion = row["DESCRIPCION"] is DBNull ? null : row["DESCRIPCION"].ToString(),
                                Fecha = row["DESCRIPCION"] is DBNull ? Convert.ToDateTime(null) : Convert.ToDateTime(row["DESCRIPCION"].ToString()),
                                Imagen1 = row["IMAGEN"] is DBNull ? null : row,
                                Pertenece = row["PERTENECE"] is DBNull ? null : row["PERTENECE"].ToString(),

                            });
                        }
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
