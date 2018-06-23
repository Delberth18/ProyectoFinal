using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class ImagenLogica
    {

        public Resultado Acciones(Imagen img)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new ImagenDatos().Acciones(img);

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
