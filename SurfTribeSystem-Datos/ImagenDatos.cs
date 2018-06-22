using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Datos
{
    public class ImagenLogica
    {
        public Resultado Acciones(Imagen img)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

                param = new SqlParameter();
                param.Value = img.Codigo;
                param.ParameterName = "@CODIGO";
                parametros.Add(param);



                param = new SqlParameter();
                if (img.Descripcion == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = img.Descripcion;
                }
                param.ParameterName = "@DESCRIPCION";
                parametros.Add(param);

                param = new SqlParameter();
                if (img.Imgs == null)
                {
                    param.Value = 0;
                }
                else
                {
                    param.Value = img.Imgs;
                }
                param.ParameterName = "@IMAGEN";
                parametros.Add(param);



                param = new SqlParameter();
                if (img.Pertenece == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = img.Pertenece;
                }
                param.ParameterName = "@PERTENECE";
                parametros.Add(param);

                param = new SqlParameter();
                if (img.Titulo == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = img.Titulo;
                }
                param.ParameterName = "@TITULO";
                parametros.Add(param);

                param = new SqlParameter();
                if (img.Leyenda == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = img.Leyenda;
                }
                param.ParameterName = "@LEYENDA";
                parametros.Add(param);

                param = new SqlParameter();
                if (img.Dueño == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = img.Dueño;
                }
                param.ParameterName = "@DUEÑO";
                parametros.Add(param);

                param = new SqlParameter();
                param.Value = img.Aprobado;
                param.ParameterName = "@APROBADO";
                parametros.Add(param);


                param = new SqlParameter();
                if (img.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = img.Tag;
                }
                param.ParameterName = "@TAG";
                parametros.Add(param);

                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_IMAGEN", parametros);


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
                    List<Imagen> lista = new List<Imagen>();
                    if ((img.Tag == "LISTADO" || img.Tag == "LISTADOESPECIFICO" || img.Tag == "LISTADOESCUELA" )&& datos.Tables[1] != null && datos.Tables[1].Rows.Count != 0)
                    {
                        int cant = 1;
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                            string imageBase64 = "data:image/gif;base64," + row["IMAGEN"].ToString();
                            string base64 = imageBase64.Substring(imageBase64.IndexOf(',') + 1);
                            base64 = base64.Trim('\0');
                            byte[] bytes = Convert.FromBase64String(base64);
                            Image image;
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                image = Image.FromStream(ms);
                            }


                            lista.Add(new Imagen
                            {
                                Codigo = row["CODIGO"] is DBNull ? 0 : Convert.ToInt32(row["CODIGO"].ToString()),
                                Descripcion = row["DESCRIPCION"] is DBNull ? null : row["DESCRIPCION"].ToString(),
                                Imgs = row["IMAGEN"] is DBNull ? null : row["IMAGEN"].ToString(),
                                Imagen1 = image,
                                Pertenece = row["PERTENECE"] is DBNull ? null : row["PERTENECE"].ToString(),
                                Titulo = row["TITULO"] is DBNull ? null : row["TITULO"].ToString(),
                                Leyenda = row["LEYENDA"] is DBNull ? null : row["LEYENDA"].ToString(),
                                Dueño = row["DUEÑO"] is DBNull ? null : row["DUEÑO"].ToString(),
                                Aprobado = row["APROBADO"] is DBNull ? false : Convert.ToBoolean(row["APROBADO"].ToString()),
                                Num = cant.ToString()
                            });
                            cant++;

                        }
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
