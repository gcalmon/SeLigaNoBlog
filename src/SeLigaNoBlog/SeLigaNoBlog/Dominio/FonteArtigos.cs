using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLigaNoBlog
{
    public class FonteArtigos
    {
        public string Url { get; set; }

        public string TermoFiltragem { get; set; }

        public FonteArtigos(String url)
        {
            this.Url = url;
        }

        public FonteArtigos(String url, String termofiltragem)
            : this(url)
        {
            this.TermoFiltragem = termofiltragem;
        }

    }
}
