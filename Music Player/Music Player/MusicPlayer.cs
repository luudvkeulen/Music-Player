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
        Song Playingsong
        {
            get { return playingsong; }
            set
            {
                playingsong = value;
                OnSongChanged();
            }
        }

        private void OnSongChanged()
        {
           Song song = Playing();
            if (song != null)
            {
                lblPlaying.Text = song.ToString();
            }
            else
            {
                lblPlaying.Text = "No song/playlist playing";
            }
        }

        Playlist playingplaylist;
        public MusicPlayer()
        {
            InitializeComponent();
            artists = new List<Artist>();
            playlists = new List<Playlist>();
            songs = new List<Song>();
            TestData();
        }

        //public event System.EventHandler SongChanged;

        void TestData()
        {
            //Testdata
            artists.Add(new Artist("Peter"));
            artists.Add(new Artist("Jan"));
            artists.Add(new Artist("Jaap"));
            songs.Add(new Song("Baby", 2011, artists[0]));
            songs.Add(new Song("Yeah", 1957, artists[0]));
            songs.Add(new Song("I got swag", 1989, artists[1]));
            songs.Add(new Song("You know i love you", 2005, artists[1]));
            songs.Add(new Song("Let her go", 1924, artists[1]));
            songs.Add(new Song("On the other side", 1979, artists[2]));
            songs.Add(new Song("I cry everytime", 1994, artists[2]));
            playlists.Add(new Playlist("Cool songs"));
            playlists.Add(new Playlist("Chillll"));
            playlists.Add(new Playlist("HAKKEN"));
            playlists[0].Songs.Add(songs[0]);
            playlists[0].Songs.Add(songs[2]);
            playlists[1].Songs.Add(songs[1]);
            playlists[1].Songs.Add(songs[3]);
            playlists[2].Songs.Add(songs[4]);
            playlists[2].Songs.Add(songs[5]);
            UpdateArtists();
            UpdatePlayList();
            UpdateSongs();
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
            //playingsong = song;
            Playingsong = song;
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
            Playingsong = null;
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
            listPlaylists.DataSource = null;
            listPlaylists.DataSource = playlists;
        }

        private void UpdatePlayListSongs(Playlist playlist)
        {
            listPlaylistSongs.Items.Clear();
            listPlaylistSongs.Items.AddRange(playlist.Songs.ToArray());
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
            if(listSongs.SelectedIndex > -1 && listPlaylists.SelectedIndex > -1)
            {
                Playlist playlist = (Playlist)listPlaylists.SelectedItem;
                /*if (listSongs.SelectedItems.Count > 1)
                {
                    List<Song> songs = new List<Song>();
                    foreach(Object obj in listSongs.SelectedItems)
                    {
                        Song song = obj as Song;
                        songs.Add(song);
                    }
                    playlist.Add(songs);
                    MessageBox.Show("Nummers toegoevoegd aan " + playlist.ToString());
                }
                else
                {*/
                    playlist.Add((Song)listSongs.SelectedItem);
                    MessageBox.Show("Nummer toegoevoegd aan " + playlist.ToString());
                UpdatePlayListSongs(playlist);
                //}
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
            else
            {
                MessageBox.Show("Selecteer eerst een lied");
            }
        }

        private void listPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            Playlist playlist = (Playlist)listPlaylists.SelectedItem;
            listPlaylistSongs.Items.Clear();
            listPlaylistSongs.Items.AddRange(playlist.Songs.ToArray());
        }

        private void btnPlayfromPlaylist_Click(object sender, EventArgs e)
        {
            if(listPlaylistSongs.SelectedIndex > -1)
            {
                Play((Song)listPlaylistSongs.SelectedItem);
            }
        }

        private void btnStopPlaying_Click(object sender, EventArgs e)
        {
            StopPlaying();
        }
    }
}
