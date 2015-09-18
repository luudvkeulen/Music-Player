using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    public class Playlist
    {
        public List<Song> Songs { get; set; }
        string Name { get; set; }
        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }

        public void Add(Song song)
        {
            Songs.Add(song);
        }

        public void Add(List<Song> songs)
        {
            Songs.AddRange(songs);
        }

        public void Remove(Song song)
        {
            Songs.Remove(song);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
