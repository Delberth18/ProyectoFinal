using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Entidades
{
    public class Evento
    {
        string titulo;
        string descripcion;
        string imagen;
        string tag;

        int id;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Tag { get => tag; set => tag = value; }
        public int Id { get => id; set => id = value; }
    }
}
