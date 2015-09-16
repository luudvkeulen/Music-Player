using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    class Playlist
    {
        string Name { get; set; }
        public Playlist(string name)
        {
            Name = name;
        }

        public void Add(Song song)
        {

        }

        public void Add(List<Song> songs)
        {

        }

        public void Remove(Song song)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
