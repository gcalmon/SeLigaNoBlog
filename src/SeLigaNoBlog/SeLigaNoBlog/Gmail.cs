using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace SeLigaNoBlog
{
    public class Gmail
    {
        public void EnviarEmail(Usuario usuario, Artigo artigo)
        {

            var smtp = Smtp.ObterPorConfig();

            var smtpClient = new SmtpClient(smtp.Servidor, smtp.Porta)
            {
                Credentials = new NetworkCredential(smtp.Login, smtp.Senha),
                EnableSsl = true
            };

            var mail = new MailMessage()
            {
                From = new MailAddress(smtp.Email, smtp.Nome),
                Subject = "Recomendação de Artigo",
                Body = artigo.Url
            };

            mail.To.Add(new MailAddress(usuario.Email, usuario.Nome));

            smtpClient.Send(mail);
        }
    }
}
