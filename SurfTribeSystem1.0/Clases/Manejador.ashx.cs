using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace SurfTribeSystem1._0.Clases
{
    /// <summary>
    /// Summary description for Manejador
    /// </summary>
    public class Manejador : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.QueryString["id"] == null) return;
            string connStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;";
            int cod = Convert.ToInt32(context.Request.QueryString["id"]);
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT imagen FROM IMAGEN WHERE CODIGO = @autoId", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@CODIGO", cod));
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        reader.Read();
                        context.Response.BinaryWrite((Byte[])reader[reader.GetOrdinal("FileContent")]);
                        reader.Close();
                    }
                }
            }
        }
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}