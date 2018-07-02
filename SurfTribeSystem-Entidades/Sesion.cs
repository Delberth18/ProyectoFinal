using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Entidades
{
   public class Sesion
    {
        string dificultad;
        DateTime fecha;
        int habilitadas;
        int reservadas;
        DateTime HraInicio;
        DateTime HraFinal;
        string id;
        string idEscuela;
        string tag;
        bool activa;

        public string Dificultad { get => dificultad; set => dificultad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Habilitadas { get => habilitadas; set => habilitadas = value; }
        public int Reservadas { get => reservadas; set => reservadas = value; }
        public DateTime HraInicio1 { get => HraInicio; set => HraInicio = value; }
        public DateTime HraFinal1 { get => HraFinal; set => HraFinal = value; }
        public string Id { get => id; set => id = value; }
        public string IdEscuela { get => idEscuela; set => idEscuela = value; }
        public string Tag { get => tag; set => tag = value; }
        public bool Activa { get => activa; set => activa = value; }
    }
}
