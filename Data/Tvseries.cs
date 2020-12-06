using System;
using System.Collections.Generic;

#nullable disable

namespace PoliHack.Data
{
    public partial class Tvseries
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Titlu { get; set; }
        public string Imagine { get; set; }
        public string LinkNetflix { get; set; }
        public string LinkImdb { get; set; }
        public string LinkRt { get; set; }
        public string LinkAmazon { get; set; }
        public string Descriere { get; set; }
    }
}
