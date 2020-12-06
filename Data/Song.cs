using System;
using System.Collections.Generic;

#nullable disable

namespace PoliHack.Data
{
    public partial class Song
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Titlu { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Imagine { get; set; }
        public string LinkSpotify { get; set; }
        public string LinkApplemusic { get; set; }
        public string LinkYoutube { get; set; }
        public string LinkTidal { get; set; }
    }
}
