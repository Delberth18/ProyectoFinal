﻿using SurfTribeSystem_Datos;
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
        public Resultado Acciones(Faq faq)
        {
            Resultado resultado = new Resultado();
            try
            {
                resultado = new FaqDatos().Acciones(faq);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
