using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfTribeSystem1._0.Models
{
    public class Credencial
    {
        string codigoTurno;
        string codigoAlmacen;
        string codigoUsuario;
        string claveUsuario;
        string codigoRecurso;
        string codigoModulo;



        public string CodigoTurno { get => codigoTurno; set => codigoTurno = value; }
        public string CodigoAlmacen { get => codigoAlmacen; set => codigoAlmacen = value; }
        public string CodigoUsuario { get => codigoUsuario; set => codigoUsuario = value; }
        public string ClaveUsuario { get => claveUsuario; set => claveUsuario = value; }
        public string CodigoRecurso { get => codigoRecurso; set => codigoRecurso = value; }
        public string CodigoModulo { get => codigoModulo; set => codigoModulo = value; }
    }
}