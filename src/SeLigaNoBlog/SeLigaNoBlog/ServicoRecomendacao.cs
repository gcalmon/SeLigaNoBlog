using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLigaNoBlog
{
    public class ServicoRecomendacao
    {
        public void Executar()
        {
            var smtp = Smtp.ObterPorConfig();
            
            var usuario = new Usuario("Andre G. Calmon", "gcalmon@gmail.com");
            
            IBlog blog = new BlogKentBack();

            var artigo = blog.ObterArtigo();

            var servicoEmail = new Gmail(smtp);
            
            var mensagem = new MensagemEmail(usuario, artigo);

            servicoEmail.EnviarEmail(mensagem);
        }
    }
}
