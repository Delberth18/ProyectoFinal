using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class EscuelaLogica
    {
        public Resultado Acciones(Escuela escuela)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.EscuelaDatos().Acciones(escuela);

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
