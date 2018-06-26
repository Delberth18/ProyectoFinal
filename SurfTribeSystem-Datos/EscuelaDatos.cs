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
    public class EscuelaDatos
    {
        public Resultado Acciones(Escuela escuela)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

                param = new SqlParameter();
                if (escuela.Id == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela.Id;
                }
                param.ParameterName = "@ID";
                parametros.Add(param);

                param = new SqlParameter();
                if (escuela.Nombre == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela.Nombre;
                }
                param.ParameterName = "@NOMBRE";
                parametros.Add(param);


                param = new SqlParameter();
                if (escuela.Ubicacion == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela.Ubicacion;
                }
                param.ParameterName = "@UBICACION";
                parametros.Add(param);

                param = new SqlParameter();
                if (escuela.Telefono == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela.Telefono;
                }
                param.ParameterName = "@TELEFONO";
                parametros.Add(param);

                param = new SqlParameter();
                if (escuela.Telefono2 == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela.Telefono2;
                }
                param.ParameterName = "@TELEFONO2";
                parametros.Add(param);

                param = new SqlParameter();
                if (escuela.Anio_fundacion == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela.Anio_fundacion;
                }
                param.ParameterName = "@ANIO_FUNDACION";
                parametros.Add(param);

                param = new SqlParameter();
                if (escuela.Playa_concurrida == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela.Playa_concurrida;
                }
                param.ParameterName = "@PLAYA_CONCURRIDA";
                parametros.Add(param);

                param = new SqlParameter();
                if (escuela.Correo == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela.Correo;
                }
                param.ParameterName = "@CORREO";
                parametros.Add(param);

                param = new SqlParameter();
                if (escuela.Zona == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela.Zona;
                }
                param.ParameterName = "@ZONA";
                parametros.Add(param);

                param = new SqlParameter();
                if (escuela.Descripcion == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela.Descripcion;
                }
                param.ParameterName = "@DESCRIPCION";
                parametros.Add(param);

                param = new SqlParameter();
                    param.Value = escuela.Activa;
                param.ParameterName = "@ACTIVA";
                parametros.Add(param);

                param = new SqlParameter();
                if (escuela.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela.Tag;
                }
                param.ParameterName = "@TAG";
                parametros.Add(param);

                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_ESCUELA", parametros);


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
                    List<Escuela> lista = new List<Escuela>();
                    if ((escuela.Tag == "LIMON" || escuela.Tag == "PUNTARENAS" || escuela.Tag == "GUANACASTE" ) && datos.Tables[1] != null && datos.Tables[1].Rows.Count != 0)
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            
                            lista.Add(new Escuela
                            {
                                Nombre = row["NOMBRE"] is DBNull ? null : row["NOMBRE"].ToString(),
                                Ubicacion = row["UBICACION"] is DBNull ? null : row["UBICACION"].ToString(),
                                Telefono = row["TELEFONO"] is DBNull ? null : row["TELEFONO"].ToString(),
                                Telefono2 = row["TELEFONO2"] is DBNull ? null : row["TELEFONO2"].ToString(),
                                Anio_fundacion = row["ANIO_FUNDACION"] is DBNull ? null : row["ANIO_FUNDACION"].ToString(),
                                Playa_concurrida = row["PLAYA_CONCURRIDA"] is DBNull ? null : row["PLAYA_CONCURRIDA"].ToString(),
                                Correo = row["CORREO"] is DBNull ? null : row["CORREO"].ToString(),
                                Descripcion = row["DESCRIPCION"] is DBNull ? null : row["DESCRIPCION"].ToString(),
                                Zona = row["ZONA"] is DBNull ? null : row["ZONA"].ToString(),
                                Imgs = row["IMAGEN"] is DBNull ? null : row["IMAGEN"].ToString()
                            });

                        }
                    }
                    else if (escuela.Tag == "LISTADO_POR_NOMBRE" && datos.Tables[1] != null && datos.Tables[1].Rows.Count != 0)
                    {

                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            
                            lista.Add(new Escuela
                            {
                                Nombre = row["NOMBRE"] is DBNull ? null : row["NOMBRE"].ToString(),
                                Ubicacion = row["UBICACION"] is DBNull ? null : row["UBICACION"].ToString(),
                                Telefono = row["TELEFONO"] is DBNull ? null : row["TELEFONO"].ToString(),
                                Telefono2 = row["TELEFONO2"] is DBNull ? null : row["TELEFONO2"].ToString(),
                                Anio_fundacion = row["ANIO_FUNDACION"] is DBNull ? null : row["ANIO_FUNDACION"].ToString(),
                                Playa_concurrida = row["PLAYA_CONCURRIDA"] is DBNull ? null : row["PLAYA_CONCURRIDA"].ToString(),
                                Correo = row["CORREO"] is DBNull ? null : row["CORREO"].ToString(),
                                Descripcion = row["DESCRIPCION"] is DBNull ? null : row["DESCRIPCION"].ToString(),
                                Zona = row["ZONA"] is DBNull ? null : row["ZONA"].ToString()
                            });

                        }
                    }
                    else if (escuela.Tag == "LISTADO_SENCILLO_IMAGEN" && datos.Tables[1] != null && datos.Tables[1].Rows.Count != 0)
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {


                            lista.Add(new Escuela
                            {
                                Nombre = row["NOMBRE"] is DBNull ? null : row["NOMBRE"].ToString(),
                                Ubicacion = row["UBICACION"] is DBNull ? null : row["UBICACION"].ToString(),
                                Telefono = row["TELEFONO"] is DBNull ? null : row["TELEFONO"].ToString(),
                                Telefono2 = row["TELEFONO2"] is DBNull ? null : row["TELEFONO2"].ToString(),
                                Imgs= row["IMAGEN"] is DBNull ? null : row["IMAGEN"].ToString(),
                                Anio_fundacion = row["ANIO_FUNDACION"] is DBNull ? null : row["ANIO_FUNDACION"].ToString(),
                                Playa_concurrida = row["PLAYA_CONCURRIDA"] is DBNull ? null : row["PLAYA_CONCURRIDA"].ToString(),
                                Correo = row["CORREO"] is DBNull ? null : row["CORREO"].ToString(),
                                Descripcion = row["DESCRIPCION"] is DBNull ? null : row["DESCRIPCION"].ToString(),
                                Zona = row["ZONA"] is DBNull ? null : row["ZONA"].ToString()
                            });

                        }
                    }
                    else if (escuela.Tag== "INSER_ACTUA" || escuela.Tag=="VALIDA")
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
