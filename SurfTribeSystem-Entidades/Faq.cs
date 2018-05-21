using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Entidades
{
    public class Faq
    {
        string pregunta;
        string respuesta;
        string tag;

        public string Pregunta { get => pregunta; set => pregunta = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public string Tag { get => tag; set => tag = value; }
    }
}
