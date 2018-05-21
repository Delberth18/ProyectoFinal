
using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SurfTribeSystem_LogicaDeNegocios
{
    public class SeguridadDatos
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
                if (credencial.CorreoUsuario == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = credencial.CorreoUsuario;
                }
                param.ParameterName = "@IDUSUARIO";
                parametros.Add(param);
               
                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_USUARIO_AUTENTICACION", parametros);


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