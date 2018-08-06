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
    public class unsuscribeDatos
    {
        public Resultado Acciones(string correo, string comentario = null)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

                param = new SqlParameter();
                param.ParameterName = "@COMENTARIO";
                if (comentario == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = comentario;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@CORREO";
                if (correo == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = correo;
                }
                parametros.Add(param);
                
                #endregion

                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_DESINSCRIBIR", parametros);


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
