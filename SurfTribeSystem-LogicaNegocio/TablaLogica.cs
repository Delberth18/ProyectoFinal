using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class TablaLogica
    {
        public Resultado Acciones(Tabla tabla)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.TablaDatos().Acciones(tabla);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Resultado Estados()
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.TablaDatos().Estados();

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Resultado Marcas()
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.TablaDatos().Marcas();

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Resultado Tipos()
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.TablaDatos().Tipos();

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Resultado Dificultad()
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.TablaDatos().Dificultad();

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Resultado Reporte(string idEscuela, string marca, string tipo, string estado, string dificultad)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SurfTribeSystem_Datos.TablaDatos().Reporte(idEscuela, marca, tipo,estado, dificultad);

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
