using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfTribeSystem_Entidades
{
    public class Usuario
    {
        string correo;
        string clave;
        string nombre;
        string apellidos;
        string telefono;
        string pais;
        string tipo_usu;
        string tag;
        string idEscuela;

        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Tipo_usu { get => tipo_usu; set => tipo_usu = value; }
        public string Tag { get => tag; set => tag = value; }
        public string IdEscuela { get => idEscuela; set => idEscuela = value; }
    }
}
