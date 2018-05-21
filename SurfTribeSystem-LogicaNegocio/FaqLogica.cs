using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class FaqLogica
    {
        public Resultado ValidarUsuario(Faq faq)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new FaqDatos().Acciones(faq);

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
