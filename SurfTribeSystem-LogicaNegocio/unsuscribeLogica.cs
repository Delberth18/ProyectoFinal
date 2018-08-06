using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class unsuscribeLogica
    {
        public Resultado Acciones(string correo, string comentario=null)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new unsuscribeDatos().Acciones(correo, comentario);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
