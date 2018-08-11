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
    public class EventoDatos
    {
        public Resultado Acciones(Evento evento)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

                param = new SqlParameter();
                param.ParameterName = "@TITULO";
                if (evento.Titulo == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = evento.Titulo;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DESCRIPCION";
                if (evento.Descripcion == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = evento.Descripcion;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@IMAGEN";
                if (evento.Imagen == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = evento.Imagen;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TAG";
                if (evento.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = evento.Tag;
                }
                parametros.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@ID";
                param.Value = evento.Id;
                parametros.Add(param);

                #endregion

                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_EVENTO", parametros);


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
                    List<Evento> eventos = new List<Evento>();

                    if (evento.Tag == "LISTADO")
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            eventos.Add(new Evento
                            {
                                Id = row["ID"] is DBNull ? 0 : Convert.ToInt32(row["ID"]),
                                Titulo = row["TITULO"] is DBNull ? null : row["TITULO"].ToString(),
                                Imagen = row["IMAGEN"] is DBNull ? null : row["IMAGEN"].ToString(),
                                Descripcion = row["DESCRIPCION"] is DBNull ? null : row["DESCRIPCION"].ToString()
                            });
                        }
                        resultado.ObjetoResultado = eventos;
                    }
                    else if (evento.Tag == "UNICO")
                    {
                        resultado.ObjetoResultado = new Evento
                        {
                            Id = datos.Tables[1].Rows[0]["ID"] is DBNull ? 0 : Convert.ToInt32(datos.Tables[1].Rows[0]["ID"]),
                            Titulo = datos.Tables[1].Rows[0]["TITULO"] is DBNull ? null : datos.Tables[1].Rows[0]["TITULO"].ToString(),
                            Imagen = datos.Tables[1].Rows[0]["IMAGEN"] is DBNull ? null : datos.Tables[1].Rows[0]["IMAGEN"].ToString(),
                            Descripcion = datos.Tables[1].Rows[0]["DESCRIPCION"] is DBNull ? null : datos.Tables[1].Rows[0]["DESCRIPCION"].ToString()
                        };
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
