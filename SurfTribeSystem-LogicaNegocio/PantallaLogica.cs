using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class PantallaLogica
    {
        public Resultado Acciones(Pantalla pantalla)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.PantallaDatos().Acciones(pantalla);

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
