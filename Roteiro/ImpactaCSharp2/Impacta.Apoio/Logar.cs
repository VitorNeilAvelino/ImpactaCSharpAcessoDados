using System;
using System.Net;
using System.Net.Mail;

namespace Impacta.Apoio
{
    public static class Logar
    {
        public static void PorEmail(Exception ex)
        {
            var mensagem = new MailMessage("avelino.vitor@gmail.com", "vitoravelino@ig.com.br", ex.Message, ex.StackTrace);
            mensagem.IsBodyHtml = true;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("avelino.vitor@gmail.com", "senha", "")
            };

            try
            {
                smtp.Send(mensagem);
            }
            catch
            {
            }
        }
    }
}