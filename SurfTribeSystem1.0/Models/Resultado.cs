using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfTribeSystem1._0.Models
{
    public class Resultado
    {
        string tipoResultado;
        string mensaje;
        string codigoMensaje;
        object objetoResultado;

        public string TipoResultado { get => tipoResultado; set => tipoResultado = value; }
        public object ObjetoResultado { get => objetoResultado; set => objetoResultado = value; }
        public string CodigoMensaje { get => codigoMensaje; set => codigoMensaje = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}