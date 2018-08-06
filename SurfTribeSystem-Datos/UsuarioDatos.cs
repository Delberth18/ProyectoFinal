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
    public class UsuarioDatos
    {
        public Resultado Acciones(Usuario usuario)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

                param = new SqlParameter();
                if (usuario.Correo == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Correo;
                }
                param.ParameterName = "@CORREO";
                parametros.Add(param);



                param = new SqlParameter();
                if (usuario.Clave == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Clave;
                }
                param.ParameterName = "@CLAVE";
                parametros.Add(param);

                param = new SqlParameter();
                if (usuario.Clave_antigua == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Clave_antigua;
                }
                param.ParameterName = "@CLAVE_ANTIGUA";
                parametros.Add(param);

                param = new SqlParameter();
                if (usuario.Nombre == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Nombre;
                }
                param.ParameterName = "@NOMBRE";
                parametros.Add(param);



                param = new SqlParameter();
                if (usuario.Apellidos == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Apellidos;
                }
                param.ParameterName = "@APELLIDOS";
                parametros.Add(param);

                param = new SqlParameter();
                if (usuario.Telefono == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Telefono;
                }
                param.ParameterName = "@TELEFONO";
                parametros.Add(param);



                param = new SqlParameter();
                if (usuario.Pais == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Pais;
                }
                param.ParameterName = "@PAIS";
                parametros.Add(param);

                param = new SqlParameter();
                if (usuario.Tipo_usu == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Tipo_usu;
                }
                param.ParameterName = "@TIPO_USU";
                parametros.Add(param);

                param = new SqlParameter();
                if (usuario.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Tag;
                }
                param.ParameterName = "@TAG";
                parametros.Add(param);

                param = new SqlParameter();
                if (usuario.IdEscuela == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.IdEscuela;
                }
                param.ParameterName = "@ID_ESCUELA";
                parametros.Add(param);

                param = new SqlParameter();
                if (usuario.Estado == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Estado;
                }
                param.ParameterName = "@ESTADO";
                parametros.Add(param);


                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_USUARIO", parametros);


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
                    List<string> lista = new List<string>();
                    if (usuario.Tag == "CORREOS" || usuario.Tag == "CORREOS2")
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            lista.Add(row["CORREO"].ToString());
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

        public Resultado Reporte(string pais, string escuela, string estado)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros
                
                param = new SqlParameter();
                if (pais == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = pais;
                }
                param.ParameterName = "@PAIS";
                parametros.Add(param);

                param = new SqlParameter();
                if (escuela == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = escuela;
                }
                param.ParameterName = "@ESCUELA";
                parametros.Add(param);
                
                param = new SqlParameter();
                if (estado == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = estado;
                }
                param.ParameterName = "@ESTADO";
                parametros.Add(param);

                param = new SqlParameter();
                param.Value = "";
                param.ParameterName = "@FILTRO";
                parametros.Add(param);

                param = new SqlParameter();
                param.Value = "";
                param.ParameterName = "@TIPO_USUARIO";
                parametros.Add(param);

                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_REPORTE_USUARIO", parametros);


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
                    List<Usuario> lista = new List<Usuario>();

                    foreach (DataRow row in datos.Tables[1].Rows)
                    {
                        lista.Add(new Usuario
                        {
                            Nombre=row["NOMBRE"] is DBNull ? null : row["NOMBRE"].ToString(),
                            Apellidos= row["APELLIDOS"] is DBNull ? null : row["APELLIDOS"].ToString(),
                            Telefono= row["TELEFONO"] is DBNull ? null : row["TELEFONO"].ToString(),
                            Correo= row["CORREO"] is DBNull ? null : row["CORREO"].ToString(),
                            Tipo_usu_dsc= row["TIPO"] is DBNull ? null : row["TIPO"].ToString(),
                            Estado= row["ESTADO"] is DBNull ? null : row["ESTADO"].ToString(),
                            Escuela_dsc= row["ESCUELA"] is DBNull ? null : row["ESCUELA"].ToString()
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
