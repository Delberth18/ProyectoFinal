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
    public class ReporteUsuarioDatos
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
                param.ParameterName = "@TIPO_USUARIO";
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
                param.ParameterName = "@FILTRO";
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
                param.ParameterName = "@ESCUELA";
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
                            Nombre = row["NOMBRE"] is DBNull ? null : row["NOMBRE"].ToString(),
                            Apellidos = row["APELLIDOS"] is DBNull ? null : row["APELLIDOS"].ToString(),
                            Telefono = row["TELEFONO"] is DBNull ? null : row["TELEFONO"].ToString(),
                            Nc= row["NC"] is DBNull ? null : row["NC"].ToString(),

                            Correo = row["CORREO"] is DBNull ? null : row["CORREO"].ToString()
                            
                             
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
