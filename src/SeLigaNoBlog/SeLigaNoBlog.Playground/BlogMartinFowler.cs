using System;
using System.Linq;
using TNX.RssReader;

namespace SeLigaNoBlog.Playground
{
    class BlogMartinFowler : Blog
    {
        public BlogMartinFowler()
            : base("http://martinfowler.com/feed.atom")
        {
        }

        public override bool EhArtigo(Artigo artigo)
        {
            return artigo.Url.Contains("articles");
        }

    }
}
