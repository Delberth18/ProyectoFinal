using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
   public class ReservaSesionLogica
    {


        public Resultado Acciones(Sesion sesion)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new ReservaSesionDatos().Acciones(sesion);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
