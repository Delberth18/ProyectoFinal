using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Entidades
{
    public class Reserva
    {
        string idUsuario;
        string idSesion;
        string tag;

        string fecha;
        string nombreIns;
        string precio;
        string nombreUsu;

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string IdSesion { get => idSesion; set => idSesion = value; }
        public string Tag { get => tag; set => tag = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string NombreIns { get => nombreIns; set => nombreIns = value; }
        public string Precio { get => precio; set => precio = value; }
        public string NombreUsu { get => nombreUsu; set => nombreUsu = value; }
    }
}
