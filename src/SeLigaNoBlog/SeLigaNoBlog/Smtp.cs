using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLigaNoBlog
{
    public class Smtp
    {
        public string Login { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public static Smtp ObterPorConfig()
        {
            return new Smtp()
            {
                Login = ConfigurationManager.AppSettings["loginSmtp"],
                Senha = ConfigurationManager.AppSettings["senhaSmtp"],
                Nome = ConfigurationManager.AppSettings["nomeSmtp"],
            };
        }
    }
}
