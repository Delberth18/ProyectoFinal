using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class ReservaLogica
    {
        public Resultado Acciones(Reserva reserva)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.ReservaDatos().Acciones(reserva);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
