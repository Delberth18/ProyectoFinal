using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace SurfTribeSystem1._0.Clases
{
    public class Email
    {

        MailMessage m = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        public bool enviarCorreos(string from, string subject, string password, string to, string mensaje)
        {
            try
            {
                m.From = new MailAddress(from);
                m.To.Add(new MailAddress(to));
                m.Body = mensaje;
                m.Subject = subject;
                // m.IsBodyHtml = true;
                smtp.Host = "smtp.gmail.com"; // "smtp-mail.outlook.com";
                smtp.Port = 587;

                smtp.Credentials = new NetworkCredential(from, password);
                smtp.EnableSsl = true;
                smtp.Send(m);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("error" + e.StackTrace);
                return false;
            }
        }

    }
}