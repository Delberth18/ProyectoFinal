﻿using SurfTribeSystem_Datos;
using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_LogicaNegocio
{
    public class ComentarioLogica
    {

        public Resultado ListadoAprobado(Comentario comentario)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new ComentarioDatos().Acciones(comentario);

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}