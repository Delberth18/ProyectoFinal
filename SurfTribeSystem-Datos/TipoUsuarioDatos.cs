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
    public class TipoUsuarioDatos
    {
        public Resultado Acciones(TipoUsuario tipoU)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

                param = new SqlParameter();
                param.ParameterName = "@DESCRIPCION";
                if (tipoU.Descripcion == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tipoU.Descripcion;
                }
                parametros.Add(param);
                
                param = new SqlParameter();
                param.ParameterName = "@ID";
                if (tipoU.Id == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tipoU.Id;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TAG";
                if (tipoU.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tipoU.Tag;
                }
                parametros.Add(param);
                #endregion

                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_TIPO_USUARIO", parametros);


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
                    List<TipoUsuario> tipos = new List<TipoUsuario>();

                    if (tipoU.Tag == "LISTADO")
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            tipos.Add(new TipoUsuario
                            {
                                Descripcion = row["DESCRIPCION"] is DBNull ? null : row["DESCRIPCION"].ToString(),
                                Id = row["ID_TIPOUSUARIO"] is DBNull ? null : row["ID_TIPOUSUARIO"].ToString()
                            });
                        }
                    }
                    resultado.ObjetoResultado = tipos;

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
