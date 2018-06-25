
using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SurfTribeSystem_LogicaDeNegocios
{
    public class SeguridadLogica
    {
        public Resultado ValidarUsuario(Credencial credencial)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new SeguridadDatos().ValidarUsuario(credencial);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}