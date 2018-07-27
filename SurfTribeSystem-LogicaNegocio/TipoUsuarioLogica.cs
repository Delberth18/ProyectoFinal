using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class TipoUsuarioLogica
    {
        public Resultado Acciones(TipoUsuario tipo)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.TipoUsuarioDatos().Acciones(tipo);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
