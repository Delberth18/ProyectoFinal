using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SurfTribeSystem_Entidades
{
    public class Imagen
    {
        int codigo;
        string descripcion;
        Image imagen;
        string imgs;
        string pertenece;
        string titulo;
        string leyenda;
        string dueño;
        bool aprobado;
        string tag;
        string num;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Image Imagen1 { get => imagen; set => imagen = value; }
        public string Pertenece { get => pertenece; set => pertenece = value; }
        public string Tag { get => tag; set => tag = value; }
        public string Imgs { get => imgs; set => imgs = value; }
        public string Num { get => num; set => num = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Leyenda { get => leyenda; set => leyenda = value; }
        public string Dueño { get => dueño; set => dueño = value; }
        public bool Aprobado { get => aprobado; set => aprobado = value; }
    }
}
