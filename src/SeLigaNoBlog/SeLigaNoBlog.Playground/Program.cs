using System;

namespace SeLigaNoBlog.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicio do código!
            /*
             * Despacho!
             * 
             * Eu, enquanto usuário, quero receber, todo dia, pela manhã,
             * um artigo técnico do Blog do Martin Fowler em meu email.
             * 
             * Planejamento
             * 
             * Obter os posts do Blog
             *      TNX.RssReader
             * Separar os Artigos
             *      Onde contiver a palavra articles
             * Entregar um artigo aleatório
             *      Random
             * Enviar o link para o e-mail do usuário
             *      Smtp.Send(mail)
             * 
             * Desafios
             *
             * Como pegar os posts
             *      - RSS http://martinfowler.com/feed.atom
             * Como enviar o e-mail
             * 
             * 
             */

            var usuario = new Usuario();
            usuario.Nome = "Andre G. Calmon";
            usuario.Email = "gcalmon@gmail.com";

            IBlog blog = new BlogKentBack();
            
            var artigo = blog.ObterArtigo();

            var servicoEmail = new Gmail();

            servicoEmail.EnviarEmail(usuario, artigo);

           Console.ReadLine();

        }
    }
}
