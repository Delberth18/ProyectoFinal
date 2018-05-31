using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class PrecioLogica
    {

        public Resultado Acciones(Precio precio)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new PrecioDatos().Acciones(precio);

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
