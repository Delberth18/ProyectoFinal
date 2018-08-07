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

        //necesario para reportes
        string dificultad;
        string horainicio;
        string idEscuela;
        string estado;
        string marca;
        int precioTotal;


        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string IdSesion { get => idSesion; set => idSesion = value; }
        public string Tag { get => tag; set => tag = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string NombreIns { get => nombreIns; set => nombreIns = value; }
        public string Precio { get => precio; set => precio = value; }
        public string NombreUsu { get => nombreUsu; set => nombreUsu = value; }
        public string Dificultad { get => dificultad; set => dificultad = value; }
        public string Horainicio { get => horainicio; set => horainicio = value; }
        public string IdEscuela { get => idEscuela; set => idEscuela = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Marca { get => marca; set => marca = value; }
        public int PrecioTotal { get => precioTotal; set => precioTotal = value; }
    }
}
