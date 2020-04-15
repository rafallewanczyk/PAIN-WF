using System;

namespace PAIN_WindowsForms
{
    public class Song
    {
        public String name { get; set; }
        public String author { get; set; }
        public int release_year { get; set; }
        public String genre { get; set; }

        public override String ToString()
        {
            return name + " " + author + " " + release_year + " " + genre;
        }

        public Song(string name, string author, int release_year, string genre)
        {
            this.name = name;
            this.author = author;
            this.release_year = release_year;
            this.genre = genre;
        }
    }
}
