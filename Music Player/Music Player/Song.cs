using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    public class Song
    {
        string Name { get; set; }
        int Year { get; set; }
        Artist Artist { get; set; }
        public Song(string name, int year, Artist artist)
        {
            Name = name;
            Year = year;
            Artist = artist;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
