
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
    public class PantallaDatos
    {
        public Resultado Acciones(Pantalla pantalla)
        {
            Resultado resultado = new Resultado();
            DataSet datos = new DataSet();

            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter param = new SqlParameter();

            #region parametros

            param = new SqlParameter();
            if (pantalla.Tag == null)
            {
                param.Value = DBNull.Value;
            }
            else
            {
                param.Value = pantalla.Tag;
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
                List<Pantalla> lista = new List<Pantalla>();
                if (pantalla.Tag == "LISTADO" && datos.Tables[1] != null && datos.Tables[1].Rows.Count != 0)
                {
                    foreach (DataRow row in datos.Tables[1].Rows)
                    {
                        

                        lista.Add(new Pantalla
                        {
                            Nombre = row["NOMBRE"] is DBNull ? "" : row["NOMBRE"].ToString()
                        });

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
