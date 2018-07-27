using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Entidades
{
    public class TipoUsuario
    {
        string id;
        string descripcion;
        string tag;

        public string Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Tag { get => tag; set => tag = value; }
    }
}
