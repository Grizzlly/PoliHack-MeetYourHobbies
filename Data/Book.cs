using System;
using System.Collections.Generic;

#nullable disable

namespace PoliHack.Data
{
    public partial class Book
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public string Imagine { get; set; }
    }
}
