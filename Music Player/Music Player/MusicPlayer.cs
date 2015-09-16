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
        Song playingsong;
        Playlist playingplaylist;
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
            playingsong = song;
        }

        void Play(Playlist playlist)
        {
            playingplaylist = playlist;
        }

        Song Playing()
        {
            return playingsong;
        }

        void StopPlaying()
        {
            playingsong = null;
            playingplaylist = null;
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

        private void UpdatePlayList()
        {
            comboPlaylists.DataSource = listPlaylists.DataSource = null;
            comboPlaylists.DataSource = listPlaylists.DataSource = playlists;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSongName.Text.Count() > 0 && comboArtists.Items.Count > 0)
            {
                Add(new Song(txtSongName.Text, Convert.ToInt32(nmrSongYear.Value), artists[comboArtists.SelectedIndex]));
                UpdateSongs();
                txtSongName.ResetText();
                nmrSongYear.Value = 1900;
            }
            else
            {
                MessageBox.Show("Vul alle waardes in");
            }
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            if (txtPlayListname.Text.Count() > 0)
            {
                Add(new Playlist(txtPlayListname.Text));
                UpdatePlayList();
                txtPlayListname.ResetText();
            }
            else
            {
                MessageBox.Show("De afspeellijst kan geen lege naam hebben");
            }
        }

        private void btnAddToPlaylist_Click(object sender, EventArgs e)
        {
            if(listSongs.SelectedIndex > -1 && comboPlaylists.SelectedIndex > -1)
            {

            }
            else
            {
                MessageBox.Show("Selecteer eerst een nummer/afspeellijst");
            }
        }

        private void btnPlayPlaylist_Click(object sender, EventArgs e)
        {
            if (listPlaylists.SelectedIndex > -1)
            {
                Play(playlists[listPlaylists.SelectedIndex]);
            }
        }

        private void btnPlaySong_Click(object sender, EventArgs e)
        {
            if(listSongs.SelectedIndex > -1)
            {
                Play(songs[listSongs.SelectedIndex]);
            }
        }
    }
}
