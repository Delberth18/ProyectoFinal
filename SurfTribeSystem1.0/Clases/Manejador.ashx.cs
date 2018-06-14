using SurfTribeSystem_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SurfTribeSystem1._0.Clases
{
  
        public class Manejador : IHttpHandler, System.Web.SessionState.IRequiresSessionState
        {
            public void ProcessRequest(HttpContext context)
            {
                if (context.Session["Registro"] != null)
                {
                int codigo = Convert.ToInt32(string.Format("codigo={0}", context.Request.QueryString["codigo"]));
                    List<Imagen> lista = (List<Imagen>)context.Session["IMAGEN"];
                    Imagen img = lista.Find(e => e.Codigo == codigo);
                    byte[] imagen = (byte[])img.Imagen1["IMAGEN"];
                    context.Response.ContentType = "image/jpg";
                    context.Response.OutputStream.Write(imagen, 0, imagen.Length);
                }
            }
            public bool IsReusable
            {
                get
                {
                    return false;
                }
            }
        }
    }

