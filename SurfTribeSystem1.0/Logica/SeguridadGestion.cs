using SurfTribeSystem1._0.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SurfTribeSystem1._0.Logica
{
    public class SeguridadGestion
    {
        public Resultado ValidarUsuario(Credencial credencial)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

                param = new SqlParameter();
                if (credencial.CodigoTurno == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = credencial.CodigoTurno;
                }
                param.ParameterName = "@IDTURNO";
                parametros.Add(param);

                param = new SqlParameter();
                if (credencial.CodigoModulo == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = credencial.CodigoModulo;
                }
                param.ParameterName = "@IDMODULO";
                parametros.Add(param);

                param = new SqlParameter();
                if (credencial.ClaveUsuario == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = credencial.ClaveUsuario;
                }
                param.ParameterName = "@CLAVE";
                parametros.Add(param);

                param = new SqlParameter();
                if (credencial.CodigoAlmacen == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = credencial.CodigoAlmacen;
                }
                param.ParameterName = "@IDALMACEN";
                parametros.Add(param);

                param = new SqlParameter();
                if (credencial.CodigoUsuario == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = credencial.CodigoUsuario;
                }
                param.ParameterName = "@IDUSUARIO";
                parametros.Add(param);

                param = new SqlParameter();
                if (credencial.CodigoRecurso == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = credencial.CodigoRecurso;
                }
                param.ParameterName = "@IDRECURSO";
                parametros.Add(param);
                #endregion


                datos = new Conexion.Conexion()
                    .EjecutarProcedimientoDS("SPR_USUARIO_AUTENTICACION", parametros);


                if (datos.Tables[0].Rows[0]["RESULTADO"].ToString() == "ERROR")
                {
                    resultado.TipoResultado = "ERROR";
                    resultado.CodigoMensaje = datos.Tables[0].Rows[0]["CODIGO_MSJ"].ToString();
                    resultado.Mensaje = datos.Tables[0].Rows[0]["MENSAJE"].ToString();
                    resultado.ObjetoResultado = null;
                }
                else
                {
                    resultado.TipoResultado = "OK";

                    //aqui es para devolvre datos en lista o objetos
                    //resultado.ObjetoResultado = new SesionAutenticacion()
                    //{
                    //    CodigoAlmacen = datos.Tables[1].Rows[0]["CodigoAlmacen"] is DBNull ? null : datos.Tables[1].Rows[0]["CodigoAlmacen"].ToString(),
                    //    CodigoRecurso = datos.Tables[1].Rows[0]["CodigoRecurso"] is DBNull ? null : datos.Tables[1].Rows[0]["CodigoRecurso"].ToString(),
                    //    CodigoTurno = datos.Tables[1].Rows[0]["CodigoTurno"] is DBNull ? null : datos.Tables[1].Rows[0]["CodigoTurno"].ToString(),
                    //    CodigoUsuario = datos.Tables[1].Rows[0]["CodigoUsuario"] is DBNull ? null : datos.Tables[1].Rows[0]["CodigoUsuario"].ToString(),
                    //    NombreUsuario = datos.Tables[1].Rows[0]["NombreUsuario"] is DBNull ? null : datos.Tables[1].Rows[0]["NombreUsuario"].ToString(),
                    //    NombreCompania = datos.Tables[1].Rows[0]["NombreCompania"] is DBNull ? null : datos.Tables[1].Rows[0]["NombreCompania"].ToString()

                    //};

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