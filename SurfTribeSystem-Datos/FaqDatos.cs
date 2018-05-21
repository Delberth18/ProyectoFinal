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
    public class FaqDatos
    {
        public Resultado Acciones(Faq faq)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros
                param.ParameterName = "@PREGUNTA";
                if (faq.Pregunta==null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = faq.Pregunta;
                }
                parametros.Add(param);
                
                param.ParameterName = "@RESPUESTA";
                if (faq.Respuesta == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = faq.Respuesta;
                }
                parametros.Add(param);
                
                param.ParameterName = "@TAG";
                if (faq.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = faq.Tag;
                }
                parametros.Add(param);
                #endregion

                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_FAQ", parametros);


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
                    List<Faq> faqs = new List<Faq>();

                    if (faq.Tag == "LISTADO" && datos.Tables[1]!=null && datos.Tables[1].Rows.Count!=0)
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            faqs.Add(new Faq {
                                Pregunta = row["PREGUNTA"] is DBNull ? null : row["PREGUNTA"].ToString(),
                                Respuesta = row["RESPUESTA"] is DBNull ? null : row["RESPUESTA"].ToString()
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
