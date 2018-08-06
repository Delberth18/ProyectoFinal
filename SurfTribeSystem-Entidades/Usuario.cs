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
        string tipo_usu_dsc;
        string escuela_dsc;
        string tag;
        string idEscuela;
        string estado;
        string nc;
        string clave_antigua;

        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Tipo_usu { get => tipo_usu; set => tipo_usu = value; }
        public string Tag { get => tag; set => tag = value; }
        public string IdEscuela { get => idEscuela; set => idEscuela = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Nc { get => nc; set => nc = value; }
        public string Tipo_usu_dsc { get => tipo_usu_dsc; set => tipo_usu_dsc = value; }
        public string Escuela_dsc { get => escuela_dsc; set => escuela_dsc = value; }
        public string Clave_antigua { get => clave_antigua; set => clave_antigua = value; }
    }
}
