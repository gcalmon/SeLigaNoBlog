using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace SeLigaNoBlog
{
    public class Gmail
    {
        public const string HOST = "smtp.gmail.com";

        public const int PORT = 587;

        public Smtp Smtp { get; protected set; }

        public Gmail(Smtp smtp)
        {
            this.Smtp = smtp;
        }

        public void EnviarEmail(MensagemEmail email)
        {

            var smtpClient = this.ObterSmtpClient();

            var mail = email.ObterMailMessage();
            
            mail.From = new MailAddress(this.Smtp.Login, this.Smtp.Nome);
            
            smtpClient.Send(mail);
        }

        public SmtpClient ObterSmtpClient()
        {
            return new SmtpClient(HOST, PORT)
            {
                Credentials = new NetworkCredential(this.Smtp.Login, this.Smtp.Senha),
                EnableSsl = true,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
        }
    }
}
