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
    public class PrecioDatos
    {

        public Resultado Acciones(Precio precio)
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
                if (precio.Descripcion == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = precio.Descripcion;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@PRECIO";
                if (precio.PrecioD == 0)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = precio.PrecioD;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TIPO";
                if (precio.Tipo == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = precio.Tipo;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TAG";
                if (precio.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = precio.Tag;
                }
                parametros.Add(param);
                #endregion

                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_PRECIO", parametros);


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
                    List<Precio> precios = new List<Precio>();

                    if (precio.Tag == "LISTADO" && datos.Tables[1] != null && datos.Tables[1].Rows.Count != 0)
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            precios.Add(new Precio
                            {
                                Descripcion = row["DESCRIPCION"] is DBNull ? null : row["DESCRIPCION"].ToString(),
                                PrecioD = row["PRECIO"] is DBNull ? 0 : Convert.ToDouble(row["PRECIO"]),
                                Tipo = row["TIPO"] is DBNull ? null : row["TIPO"].ToString()
                            });
                        }
                    }
                    resultado.ObjetoResultado = precios;

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
