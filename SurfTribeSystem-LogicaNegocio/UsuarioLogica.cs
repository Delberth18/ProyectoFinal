﻿using SurfTribeSystem_Datos;
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
    public class UsuarioLogica
    {

        public Resultado Acciones(Usuario usuario)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new UsuarioDatos().Acciones(usuario);

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
