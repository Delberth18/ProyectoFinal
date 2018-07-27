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
    public class ReservaSesionDatos
    {

        public Resultado Acciones(Sesion sesion)
        {

            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();
            

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros
                
                param = new SqlParameter();
                if (sesion.Id == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = sesion.Id;
                }
                param.ParameterName = "@IDSESION";//IdSeSion
                parametros.Add(param);

                param = new SqlParameter();
                if (sesion.IdUsuario == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = sesion.IdUsuario;
                }
                param.ParameterName = "@IDUSUARIO";//IdUsuario
                parametros.Add(param);

                param = new SqlParameter();
                if (sesion.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = sesion.Tag;
                }
                param.ParameterName = "@TAG";
                parametros.Add(param);

                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_RESERVA_SESION", parametros);


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

                        List<Sesion> lista = new List<Sesion>();
                    

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
