using System;
using System.Drawing;

namespace курсач.Films.Film
{
    public class FilmC
    {
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Country { get; set; }
        public string Producer { get; set; }
        public DateTime ReleaseData { get; set; }
        public int Duration { get; set; }
        public string Translation { get; set;}
        public string TrailerURL { get; set; }
        public TypeOfFilm TypeF { get; set; }
        public string Description { get; set; }
        public bool IsNew { get; set; }
        public Bitmap Poster { get; set; }
        public string Jenres { get; set; }
    }

    public enum TypeOfFilm
    {
        Film, Series
    }
}
