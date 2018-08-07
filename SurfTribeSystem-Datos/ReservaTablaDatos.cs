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
    public class ReservaTablaDatos
    {

        public Resultado Acciones(Tabla tabla)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();
            DateTime Compara = new DateTime();

            try
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();

                #region parametros

                param = new SqlParameter();
                if (tabla.Id == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Id;
                }
                param.ParameterName = "@ID_TABLA";//idtabla
                parametros.Add(param);



                param = new SqlParameter();
                if (tabla.Id_usuario == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Id_usuario;
                }
                param.ParameterName = "@IDUSUARIO";//idUsuario
                parametros.Add(param);


                param = new SqlParameter();
                if (tabla.Fecha == Compara)
                {
                    param.Value = DateTime.Now;
                }
                else
                {
                    param.Value = tabla.Fecha;
                }
                param.ParameterName = "@FECHA";//fecha
                parametros.Add(param);

                param = new SqlParameter();
                if (tabla.Costo == 0)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Costo;
                }
                param.ParameterName = "@COSTO";//costo
                parametros.Add(param);

                param = new SqlParameter();
                if (tabla.Tag == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = tabla.Tag;
                }
                param.ParameterName = "@TAG";//tag
                parametros.Add(param);

                #endregion


                datos = new Conexion()
                    .EjecutarProcedimientoDS("SPR_RESERVA_TABLA", parametros);


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

                    List<Tabla> lista = new List<Tabla>();


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
