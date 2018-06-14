using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Entidades
{
    public class Imagen
    {
        int codigo;
        string descripcion;
        DateTime fecha;
        DataRow imagen;
        byte[] imagen2;
        string pertenece;
        string tag;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DataRow Imagen1 { get => imagen; set => imagen = value; }
        public string Pertenece { get => pertenece; set => pertenece = value; }
        public string Tag { get => tag; set => tag = value; }
        public byte[] Imagen2 { get => imagen2; set => imagen2 = value; }
    }
}
