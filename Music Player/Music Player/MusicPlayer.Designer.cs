namespace Music_Player
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listSongs = new System.Windows.Forms.ListBox();
            this.lblPlayingtext = new System.Windows.Forms.Label();
            this.lblPlaying = new System.Windows.Forms.Label();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.lblArtistname = new System.Windows.Forms.Label();
            this.groupAddArtist = new System.Windows.Forms.GroupBox();
            this.groupAddSong = new System.Windows.Forms.GroupBox();
            this.nmrSongYear = new System.Windows.Forms.NumericUpDown();
            this.comboArtists = new System.Windows.Forms.ComboBox();
            this.lblSongArtist = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.lblNummer = new System.Windows.Forms.Label();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnAddToPlaylist = new System.Windows.Forms.Button();
            this.groupPlaylist = new System.Windows.Forms.GroupBox();
            this.txtPlayListname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.btnPlaySong = new System.Windows.Forms.Button();
            this.listPlaylists = new System.Windows.Forms.ListBox();
            this.btnPlayPlaylist = new System.Windows.Forms.Button();
            this.listPlaylistSongs = new System.Windows.Forms.ListBox();
            this.btnPlayfromPlaylist = new System.Windows.Forms.Button();
            this.groupAddArtist.SuspendLayout();
            this.groupAddSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSongYear)).BeginInit();
            this.groupPlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // listSongs
            // 
            this.listSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSongs.FormattingEnabled = true;
            this.listSongs.ItemHeight = 16;
            this.listSongs.Location = new System.Drawing.Point(17, 50);
            this.listSongs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(235, 338);
            this.listSongs.TabIndex = 0;
            // 
            // lblPlayingtext
            // 
            this.lblPlayingtext.AutoSize = true;
            this.lblPlayingtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayingtext.Location = new System.Drawing.Point(12, 9);
            this.lblPlayingtext.Name = "lblPlayingtext";
            this.lblPlayingtext.Size = new System.Drawing.Size(82, 25);
            this.lblPlayingtext.TabIndex = 1;
            this.lblPlayingtext.Text = "Playing:";
            // 
            // lblPlaying
            // 
            this.lblPlaying.AutoSize = true;
            this.lblPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaying.Location = new System.Drawing.Point(92, 9);
            this.lblPlaying.Name = "lblPlaying";
            this.lblPlaying.Size = new System.Drawing.Size(217, 25);
            this.lblPlaying.TabIndex = 2;
            this.lblPlaying.Text = "No song/playlist playing";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(152, 78);
            this.btnAddArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(171, 36);
            this.btnAddArtist.TabIndex = 3;
            this.btnAddArtist.Text = "Voeg artiest toe";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // txtArtistName
            // 
            this.txtArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtistName.Location = new System.Drawing.Point(152, 37);
            this.txtArtistName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(171, 30);
            this.txtArtistName.TabIndex = 4;
            // 
            // lblArtistname
            // 
            this.lblArtistname.AutoSize = true;
            this.lblArtistname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistname.Location = new System.Drawing.Point(24, 39);
            this.lblArtistname.Name = "lblArtistname";
            this.lblArtistname.Size = new System.Drawing.Size(122, 25);
            this.lblArtistname.TabIndex = 5;
            this.lblArtistname.Text = "Artiestnaam:";
            // 
            // groupAddArtist
            // 
            this.groupAddArtist.Controls.Add(this.txtArtistName);
            this.groupAddArtist.Controls.Add(this.lblArtistname);
            this.groupAddArtist.Controls.Add(this.btnAddArtist);
            this.groupAddArtist.Location = new System.Drawing.Point(784, 359);
            this.groupAddArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupAddArtist.Name = "groupAddArtist";
            this.groupAddArtist.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupAddArtist.Size = new System.Drawing.Size(365, 139);
            this.groupAddArtist.TabIndex = 6;
            this.groupAddArtist.TabStop = false;
            this.groupAddArtist.Text = "Artiest toevoegen";
            // 
            // groupAddSong
            // 
            this.groupAddSong.Controls.Add(this.nmrSongYear);
            this.groupAddSong.Controls.Add(this.comboArtists);
            this.groupAddSong.Controls.Add(this.lblSongArtist);
            this.groupAddSong.Controls.Add(this.lblYear);
            this.groupAddSong.Controls.Add(this.txtSongName);
            this.groupAddSong.Controls.Add(this.lblNummer);
            this.groupAddSong.Controls.Add(this.btnAddSong);
            this.groupAddSong.Location = new System.Drawing.Point(784, 162);
            this.groupAddSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupAddSong.Name = "groupAddSong";
            this.groupAddSong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupAddSong.Size = new System.Drawing.Size(365, 192);
            this.groupAddSong.TabIndex = 7;
            this.groupAddSong.TabStop = false;
            this.groupAddSong.Text = "Liedje toevoegen";
            // 
            // nmrSongYear
            // 
            this.nmrSongYear.Location = new System.Drawing.Point(117, 70);
            this.nmrSongYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrSongYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nmrSongYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nmrSongYear.Name = "nmrSongYear";
            this.nmrSongYear.Size = new System.Drawing.Size(205, 22);
            this.nmrSongYear.TabIndex = 11;
            this.nmrSongYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // comboArtists
            // 
            this.comboArtists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboArtists.FormattingEnabled = true;
            this.comboArtists.Location = new System.Drawing.Point(117, 101);
            this.comboArtists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboArtists.Name = "comboArtists";
            this.comboArtists.Size = new System.Drawing.Size(205, 24);
            this.comboArtists.TabIndex = 8;
            // 
            // lblSongArtist
            // 
            this.lblSongArtist.AutoSize = true;
            this.lblSongArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongArtist.Location = new System.Drawing.Point(39, 100);
            this.lblSongArtist.Name = "lblSongArtist";
            this.lblSongArtist.Size = new System.Drawing.Size(73, 25);
            this.lblSongArtist.TabIndex = 10;
            this.lblSongArtist.Text = "Artiest:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(55, 70);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(57, 25);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Jaar:";
            // 
            // txtSongName
            // 
            this.txtSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongName.Location = new System.Drawing.Point(117, 37);
            this.txtSongName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(205, 30);
            this.txtSongName.TabIndex = 4;
            // 
            // lblNummer
            // 
            this.lblNummer.AutoSize = true;
            this.lblNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNummer.Location = new System.Drawing.Point(20, 39);
            this.lblNummer.Name = "lblNummer";
            this.lblNummer.Size = new System.Drawing.Size(92, 25);
            this.lblNummer.TabIndex = 5;
            this.lblNummer.Text = "Nummer:";
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(117, 130);
            this.btnAddSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(205, 36);
            this.btnAddSong.TabIndex = 3;
            this.btnAddSong.Text = "Voeg nummer toe";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddToPlaylist
            // 
            this.btnAddToPlaylist.Location = new System.Drawing.Point(17, 394);
            this.btnAddToPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToPlaylist.Name = "btnAddToPlaylist";
            this.btnAddToPlaylist.Size = new System.Drawing.Size(235, 32);
            this.btnAddToPlaylist.TabIndex = 8;
            this.btnAddToPlaylist.Text = "Toevoegen aan playlist";
            this.btnAddToPlaylist.UseVisualStyleBackColor = true;
            this.btnAddToPlaylist.Click += new System.EventHandler(this.btnAddToPlaylist_Click);
            // 
            // groupPlaylist
            // 
            this.groupPlaylist.Controls.Add(this.txtPlayListname);
            this.groupPlaylist.Controls.Add(this.label1);
            this.groupPlaylist.Controls.Add(this.btnAddPlaylist);
            this.groupPlaylist.Location = new System.Drawing.Point(784, 11);
            this.groupPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPlaylist.Name = "groupPlaylist";
            this.groupPlaylist.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPlaylist.Size = new System.Drawing.Size(365, 139);
            this.groupPlaylist.TabIndex = 7;
            this.groupPlaylist.TabStop = false;
            this.groupPlaylist.Text = "Afspeellijst toevoegen";
            // 
            // txtPlayListname
            // 
            this.txtPlayListname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayListname.Location = new System.Drawing.Point(117, 36);
            this.txtPlayListname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayListname.Name = "txtPlayListname";
            this.txtPlayListname.Size = new System.Drawing.Size(205, 30);
            this.txtPlayListname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naam:";
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.Location = new System.Drawing.Point(117, 73);
            this.btnAddPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(207, 36);
            this.btnAddPlaylist.TabIndex = 3;
            this.btnAddPlaylist.Text = "Maak afspeellijst";
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.Location = new System.Drawing.Point(17, 430);
            this.btnPlaySong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.Size = new System.Drawing.Size(235, 32);
            this.btnPlaySong.TabIndex = 10;
            this.btnPlaySong.Text = "Nummer afspelen";
            this.btnPlaySong.UseVisualStyleBackColor = true;
            this.btnPlaySong.Click += new System.EventHandler(this.btnPlaySong_Click);
            // 
            // listPlaylists
            // 
            this.listPlaylists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPlaylists.FormattingEnabled = true;
            this.listPlaylists.ItemHeight = 16;
            this.listPlaylists.Location = new System.Drawing.Point(259, 50);
            this.listPlaylists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPlaylists.Name = "listPlaylists";
            this.listPlaylists.Size = new System.Drawing.Size(235, 338);
            this.listPlaylists.TabIndex = 11;
            this.listPlaylists.SelectedIndexChanged += new System.EventHandler(this.listPlaylists_SelectedIndexChanged);
            // 
            // btnPlayPlaylist
            // 
            this.btnPlayPlaylist.Enabled = false;
            this.btnPlayPlaylist.Location = new System.Drawing.Point(259, 394);
            this.btnPlayPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayPlaylist.Name = "btnPlayPlaylist";
            this.btnPlayPlaylist.Size = new System.Drawing.Size(233, 32);
            this.btnPlayPlaylist.TabIndex = 12;
            this.btnPlayPlaylist.Text = "Afspeellijst afspelen";
            this.btnPlayPlaylist.UseVisualStyleBackColor = true;
            this.btnPlayPlaylist.Click += new System.EventHandler(this.btnPlayPlaylist_Click);
            // 
            // listPlaylistSongs
            // 
            this.listPlaylistSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPlaylistSongs.FormattingEnabled = true;
            this.listPlaylistSongs.ItemHeight = 16;
            this.listPlaylistSongs.Location = new System.Drawing.Point(500, 50);
            this.listPlaylistSongs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPlaylistSongs.Name = "listPlaylistSongs";
            this.listPlaylistSongs.Size = new System.Drawing.Size(235, 338);
            this.listPlaylistSongs.TabIndex = 13;
            // 
            // btnPlayfromPlaylist
            // 
            this.btnPlayfromPlaylist.Location = new System.Drawing.Point(500, 392);
            this.btnPlayfromPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayfromPlaylist.Name = "btnPlayfromPlaylist";
            this.btnPlayfromPlaylist.Size = new System.Drawing.Size(235, 32);
            this.btnPlayfromPlaylist.TabIndex = 14;
            this.btnPlayfromPlaylist.Text = "Nummer afspelen";
            this.btnPlayfromPlaylist.UseVisualStyleBackColor = true;
            this.btnPlayfromPlaylist.Click += new System.EventHandler(this.btnPlayfromPlaylist_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 514);
            this.Controls.Add(this.btnPlayfromPlaylist);
            this.Controls.Add(this.listPlaylistSongs);
            this.Controls.Add(this.btnPlayPlaylist);
            this.Controls.Add(this.listPlaylists);
            this.Controls.Add(this.btnPlaySong);
            this.Controls.Add(this.groupPlaylist);
            this.Controls.Add(this.btnAddToPlaylist);
            this.Controls.Add(this.groupAddSong);
            this.Controls.Add(this.groupAddArtist);
            this.Controls.Add(this.lblPlaying);
            this.Controls.Add(this.lblPlayingtext);
            this.Controls.Add(this.listSongs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MusicPlayer";
            this.Text = "Music Player";
            this.groupAddArtist.ResumeLayout(false);
            this.groupAddArtist.PerformLayout();
            this.groupAddSong.ResumeLayout(false);
            this.groupAddSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSongYear)).EndInit();
            this.groupPlaylist.ResumeLayout(false);
            this.groupPlaylist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSongs;
        private System.Windows.Forms.Label lblPlayingtext;
        private System.Windows.Forms.Label lblPlaying;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label lblArtistname;
        private System.Windows.Forms.GroupBox groupAddArtist;
        private System.Windows.Forms.GroupBox groupAddSong;
        private System.Windows.Forms.Label lblSongArtist;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label lblNummer;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnAddToPlaylist;
        private System.Windows.Forms.ComboBox comboArtists;
        private System.Windows.Forms.NumericUpDown nmrSongYear;
        private System.Windows.Forms.GroupBox groupPlaylist;
        private System.Windows.Forms.TextBox txtPlayListname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.Button btnPlaySong;
        private System.Windows.Forms.ListBox listPlaylists;
        private System.Windows.Forms.Button btnPlayPlaylist;
        private System.Windows.Forms.ListBox listPlaylistSongs;
        private System.Windows.Forms.Button btnPlayfromPlaylist;
    }
}

