using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spotifaille
{
    class Song
    {
        private String titre;
        private String artiste;
        private String duree;
        private String songPath;
        private String imgPath;

        public string Titre { get => titre; set => titre = value; }
        public string Artiste { get => artiste; set => artiste = value; }
        public string Duree { get => duree; set => duree = value; }
        public string SongPath { get => songPath; set => songPath = value; }
        public string ImgPath { get => imgPath; set => imgPath = value; }
    }
}
