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
    public class ComentarioDatos
    {

        public Resultado Acciones(Comentario comentario)
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
                if (comentario.Comentariol == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = comentario.Comentariol;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@ID_USUARIO";
                if (comentario.Id_Usuario == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = comentario.Id_Usuario;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TAG";
                if (comentario.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = comentario.Tag;
                }
                parametros.Add(param);
                #endregion

                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_COMENTARIOS", parametros);


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
                    List<Comentario> comentarios = new List<Comentario>();

                    if (comentario.Tag == "LISTADO_APROBADO" && datos.Tables[1] != null && datos.Tables[1].Rows.Count != 0)
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            comentarios.Add(new Comentario
                            {
                                Comentariol = row["COMENTARIO"] is DBNull ? null : row["COMENTARIO"].ToString(),
                                Nombre = row["NOMBRE"] is DBNull ? null : row["NOMBRE"].ToString()
                            });
                        }
                    }
                    resultado.ObjetoResultado = comentarios;

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
