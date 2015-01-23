using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNX.RssReader;

namespace SeLigaNoBlog
{
    public class Feed : IArtigos
    {
        public FonteArtigos Fonte { get; set; }

        public Feed(FonteArtigos fonte)
        {
            Fonte = fonte;
        }

                
        public Artigo ObterArtigo()
        {
            // Obtendo os posts do blog
            var feed = RssHelper.ReadFeed(this.Fonte.Url);

            //Selecionando um artigo
            var articles = feed.Items
                                     .Select(i => new Artigo(i.Title, i.Link))
                                     .Where(a => a.Url.Contains(this.Fonte.TermoFiltragem));

            // Obtendo artigo aleatório
            var random = new Random();
            var randomNumber = random.Next(0, articles.Count());
            var article = articles.ToArray()[randomNumber];

            return article;
        }
    }
}
