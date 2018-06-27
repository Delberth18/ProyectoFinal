using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Entidades
{
    public class Tabla
    {
        string marca;
        string tamanio;
        string tipo;
        int cantidad_Habilitadas;
        string estado;
        int cantidad_Reservadas;
        string id_Esciela;
        string imagen;
        string id;
        string dificultad;
        string tag;
        string nombreEscuela;

        public string Tamanio { get => tamanio; set => tamanio = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Cantidad_Habilitadas { get => cantidad_Habilitadas; set => cantidad_Habilitadas = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Cantidad_Reservadas { get => cantidad_Reservadas; set => cantidad_Reservadas = value; }
        public string Id_Esciela { get => id_Esciela; set => id_Esciela = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Id { get => id; set => id = value; }
        public string Dificultad { get => dificultad; set => dificultad = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Tag { get => tag; set => tag = value; }
        public string NombreEscuela { get => nombreEscuela; set => nombreEscuela = value; }
    }
}
