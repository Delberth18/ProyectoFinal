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
    public class UsuarioDatos
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
                if (usuario.Correo == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Correo;
                }
                param.ParameterName = "@CORREO";
                parametros.Add(param);



                param = new SqlParameter();
                if (usuario.Clave == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Clave;
                }
                param.ParameterName = "@CLAVE";
                parametros.Add(param);

                param = new SqlParameter();
                if (usuario.Nombre == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Nombre;
                }
                param.ParameterName = "@NOMBRE";
                parametros.Add(param);



                param = new SqlParameter();
                if (usuario.Apellidos == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Apellidos;
                }
                param.ParameterName = "@APELLIDOS";
                parametros.Add(param);

                param = new SqlParameter();
                if (usuario.Telefono == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = usuario.Telefono;
                }
                param.ParameterName = "@TELEFONO";
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
                param.ParameterName = "@TIPO_USU";
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
                param.ParameterName = "@TAG";
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
                param.ParameterName = "@ID_ESCUELA";
                parametros.Add(param);


                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_USUARIO", parametros);


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
                    List<string> lista = new List<string>();
                    if (usuario.Tag=="CORREOS")
                    {
                        foreach (DataRow row in datos.Tables[1].Rows)
                        {
                             lista.Add(row["CORREO"].ToString());
                        }
                        resultado.ObjetoResultado = lista;
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
