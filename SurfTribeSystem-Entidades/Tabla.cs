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
        string estado;
        string id_Esciela;
        string imagen;
        string id;
        string dificultad;
        string tag;
        string nombreEscuela;
        string tipo_precio;
        double costo;
        string id_usuario;
        DateTime fecha;

        public string Tamanio { get => tamanio; set => tamanio = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Id_Escuela { get => id_Esciela; set => id_Esciela = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Id { get => id; set => id = value; }
        public string Dificultad { get => dificultad; set => dificultad = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Tag { get => tag; set => tag = value; }
        public string NombreEscuela { get => nombreEscuela; set => nombreEscuela = value; }
        public double Costo { get => costo; set => costo = value; }
        public string Tipo_precio { get => tipo_precio; set => tipo_precio = value; }
        public string Id_usuario { get => id_usuario; set => id_usuario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
