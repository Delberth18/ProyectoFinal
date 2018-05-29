using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Entidades
{
    public class Comentario
    {

        string comentariol;
        string nombre;
        string id_Usuario;
        string tag;
        
        public string Tag { get => tag; set => tag = value; }
        public string Comentariol { get => comentariol; set => comentariol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Id_Usuario { get => id_Usuario; set => id_Usuario = value; }
    }
}
