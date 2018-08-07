using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
   public  class ReporteReservaLogica
    {
        public Resultado Acciones(Reserva reserva)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new ReporteReserva().Acciones(reserva);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
