using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class SesionLogica
    {
        public Resultado Acciones(Sesion sesion)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SesionDatos().Acciones(sesion);

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Resultado datosParaReporte(string escuela,string tag )
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SesionDatos().datosParaReporte(escuela,tag);

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Resultado Reporte(string escuela, string dificultad, string horario, string instructor)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SesionDatos().Reporte(escuela, dificultad,horario,instructor);

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
