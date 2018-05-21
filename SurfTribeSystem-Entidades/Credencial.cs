using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfTribeSystem_Entidades
{
    public class Credencial
    {
        string correoUsuario;
        string claveUsuario;
        public string CorreoUsuario { get => correoUsuario; set => correoUsuario = value; }
        public string ClaveUsuario { get => claveUsuario; set => claveUsuario = value; }
    }
}