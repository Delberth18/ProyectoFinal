using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class EventoLogica
    {
        public Resultado Acciones(Evento evento)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.EventoDatos().Acciones(evento);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
