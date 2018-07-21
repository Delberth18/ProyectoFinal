using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
   public class AlquilerTablaLogica
    {
        public Resultado Acciones(Tabla tabla)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.AlquilerTablaDatos().Acciones(tabla);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
