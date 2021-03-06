﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    public class Artist
    {
        string Name { get; set; }
        List<Song> Songs;
        public Artist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }

        public void Add(Song song)
        {
            Songs.Add(song);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
