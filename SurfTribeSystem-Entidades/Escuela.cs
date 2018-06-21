using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Entidades
{
    public class Escuela
    {
        string nombre;
        string ubicacion;
        string telefono;
        string telefono2;
        string anio_fundacion;
        string playa_concurrida;
        string correo;
        string zona;

        string tag;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Telefono2 { get => telefono2; set => telefono2 = value; }
        public string Anio_fundacion { get => anio_fundacion; set => anio_fundacion = value; }
        public string Playa_concurrida { get => playa_concurrida; set => playa_concurrida = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Zona { get => zona; set => zona = value; }
        public string Tag { get => tag; set => tag = value; }
    }
}
