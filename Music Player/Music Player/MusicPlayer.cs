using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class MusicPlayer : Form
    {
        List<Artist> artists;
        List<Playlist> playlists;
        List<Song> songs;
        Song playing;
        public MusicPlayer()
        {
            InitializeComponent();
            artists = new List<Artist>();
            playlists = new List<Playlist>();
            songs = new List<Song>();
        }

        void Add(Artist artist)
        {
            artists.Add(artist);
        }

        void Add(Playlist playlist)
        {
            playlists.Add(playlist);
        }

        void Add(Song song)
        {
            songs.Add(song);
        }

        void Remove(Playlist playlist)
        {
            playlists.Remove(playlist);
        }

        void Play(Song song)
        {

        }

        void Play(Playlist playlist)
        {

        }

        Song Playing()
        {
            return playing;
        }

        void StopPlaying()
        {
            playing = null;
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            if(txtArtistName.Text.Count() > 0)
            {
                Add(new Artist(txtArtistName.Text));
                UpdateArtists();
                txtArtistName.ResetText();
            }
            else
            {
                MessageBox.Show("Vul alle waardes in");
            }
        }

        private void UpdateArtists()
        {
            comboArtists.DataSource = null;
            comboArtists.DataSource = artists;
        }

        private void UpdateSongs()
        {
            listSongs.DataSource = null;
            listSongs.DataSource = songs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSongName.Text.Count() > 0 && comboArtists.Items.Count > 0)
            {
                Add(new Song(txtSongName.Text, Convert.ToInt32(nmrSongYear.Value), artists[comboArtists.SelectedIndex]));
                UpdateSongs();
                txtSongName.ResetText();
            }
            else
            {
                MessageBox.Show("Vul alle waardes in");
            }
        }
    }
}
