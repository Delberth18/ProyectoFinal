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
        string HraInicio;
        string HraFinal;
        string id;
        string idEscuela;
        string tag;
        bool activa;
        string id_instructor;
        string nombre;
        string apellidos;
        string mes;
        string dia;

        public string Dificultad { get => dificultad; set => dificultad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Habilitadas { get => habilitadas; set => habilitadas = value; }
        public int Reservadas { get => reservadas; set => reservadas = value; }
        public string HraInicio1 { get => HraInicio; set => HraInicio = value; }
        public string HraFinal1 { get => HraFinal; set => HraFinal = value; }
        public string Id { get => id; set => id = value; }
        public string IdEscuela { get => idEscuela; set => idEscuela = value; }
        public string Tag { get => tag; set => tag = value; }
        public bool Activa { get => activa; set => activa = value; }
        public string Id_instructor { get => id_instructor; set => id_instructor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Mes { get => mes; set => mes = value; }
        public string Dia { get => dia; set => dia = value; }
    }
}
