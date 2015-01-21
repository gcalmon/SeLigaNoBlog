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
            var usuario = new Usuario();
            usuario.Nome = "Andre G. Calmon";
            usuario.Email = "gcalmon@gmail.com";

            IBlog blog = new BlogKentBack();

            var artigo = blog.ObterArtigo();

            var servicoEmail = new Gmail();

            servicoEmail.EnviarEmail(usuario, artigo);
        }
    }
}
