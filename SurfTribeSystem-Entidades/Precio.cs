using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Entidades
{
    public class Precio
    {
        string tag;
        string descripcion;
        double precioD;
        string tipo;

        public string Tag { get => tag; set => tag = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double PrecioD { get => precioD; set => precioD = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
