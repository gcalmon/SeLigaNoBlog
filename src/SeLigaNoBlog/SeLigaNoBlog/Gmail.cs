using System.Net;
using System.Net.Mail;

namespace SeLigaNoBlog
{
    public class Gmail
    {
        public void EnviarEmail(Usuario usuario, Artigo artigo)
        {
            var smtp = new SmtpClient("smtp.gmail.com", 465);
            smtp.Credentials = new NetworkCredential("username", "senha");
            
            var mail = new MailMessage();
            mail.From = new MailAddress("recomendador@gmail.com", "Recomendador");
            mail.Subject = "Recomendação de Artigo";
            mail.To.Add(new MailAddress(usuario.Email, usuario.Nome));
            mail.Body = artigo.Url;
                        
            smtp.Send(mail);
        }
    }
}
