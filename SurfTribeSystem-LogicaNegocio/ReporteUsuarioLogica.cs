using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class ReporteUsuarioLogica
    {

        public Resultado Acciones(Usuario usuario)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new ReporteUsuarioDatos().Acciones(usuario);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
