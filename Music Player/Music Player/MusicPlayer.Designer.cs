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
            this.comboPlaylists = new System.Windows.Forms.ComboBox();
            this.groupPlaylist = new System.Windows.Forms.GroupBox();
            this.txtPlayListname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.btnPlaySong = new System.Windows.Forms.Button();
            this.listPlaylists = new System.Windows.Forms.ListBox();
            this.btnPlayPlaylist = new System.Windows.Forms.Button();
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
            this.listSongs.Location = new System.Drawing.Point(13, 41);
            this.listSongs.Margin = new System.Windows.Forms.Padding(2);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(177, 275);
            this.listSongs.TabIndex = 0;
            // 
            // lblPlayingtext
            // 
            this.lblPlayingtext.AutoSize = true;
            this.lblPlayingtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayingtext.Location = new System.Drawing.Point(9, 7);
            this.lblPlayingtext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayingtext.Name = "lblPlayingtext";
            this.lblPlayingtext.Size = new System.Drawing.Size(63, 20);
            this.lblPlayingtext.TabIndex = 1;
            this.lblPlayingtext.Text = "Playing:";
            // 
            // lblPlaying
            // 
            this.lblPlaying.AutoSize = true;
            this.lblPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaying.Location = new System.Drawing.Point(69, 7);
            this.lblPlaying.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaying.Name = "lblPlaying";
            this.lblPlaying.Size = new System.Drawing.Size(172, 20);
            this.lblPlaying.TabIndex = 2;
            this.lblPlaying.Text = "No song/playlist playing";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(114, 63);
            this.btnAddArtist.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(128, 29);
            this.btnAddArtist.TabIndex = 3;
            this.btnAddArtist.Text = "Voeg artiest toe";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // txtArtistName
            // 
            this.txtArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtistName.Location = new System.Drawing.Point(114, 30);
            this.txtArtistName.Margin = new System.Windows.Forms.Padding(2);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(129, 26);
            this.txtArtistName.TabIndex = 4;
            // 
            // lblArtistname
            // 
            this.lblArtistname.AutoSize = true;
            this.lblArtistname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistname.Location = new System.Drawing.Point(18, 32);
            this.lblArtistname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtistname.Name = "lblArtistname";
            this.lblArtistname.Size = new System.Drawing.Size(99, 20);
            this.lblArtistname.TabIndex = 5;
            this.lblArtistname.Text = "Artiestnaam:";
            // 
            // groupAddArtist
            // 
            this.groupAddArtist.Controls.Add(this.txtArtistName);
            this.groupAddArtist.Controls.Add(this.lblArtistname);
            this.groupAddArtist.Controls.Add(this.btnAddArtist);
            this.groupAddArtist.Location = new System.Drawing.Point(472, 294);
            this.groupAddArtist.Margin = new System.Windows.Forms.Padding(2);
            this.groupAddArtist.Name = "groupAddArtist";
            this.groupAddArtist.Padding = new System.Windows.Forms.Padding(2);
            this.groupAddArtist.Size = new System.Drawing.Size(274, 113);
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
            this.groupAddSong.Location = new System.Drawing.Point(472, 134);
            this.groupAddSong.Margin = new System.Windows.Forms.Padding(2);
            this.groupAddSong.Name = "groupAddSong";
            this.groupAddSong.Padding = new System.Windows.Forms.Padding(2);
            this.groupAddSong.Size = new System.Drawing.Size(274, 156);
            this.groupAddSong.TabIndex = 7;
            this.groupAddSong.TabStop = false;
            this.groupAddSong.Text = "Liedje toevoegen";
            // 
            // nmrSongYear
            // 
            this.nmrSongYear.Location = new System.Drawing.Point(88, 57);
            this.nmrSongYear.Margin = new System.Windows.Forms.Padding(2);
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
            this.nmrSongYear.Size = new System.Drawing.Size(154, 20);
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
            this.comboArtists.Location = new System.Drawing.Point(88, 82);
            this.comboArtists.Margin = new System.Windows.Forms.Padding(2);
            this.comboArtists.Name = "comboArtists";
            this.comboArtists.Size = new System.Drawing.Size(155, 21);
            this.comboArtists.TabIndex = 8;
            // 
            // lblSongArtist
            // 
            this.lblSongArtist.AutoSize = true;
            this.lblSongArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongArtist.Location = new System.Drawing.Point(29, 81);
            this.lblSongArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSongArtist.Name = "lblSongArtist";
            this.lblSongArtist.Size = new System.Drawing.Size(59, 20);
            this.lblSongArtist.TabIndex = 10;
            this.lblSongArtist.Text = "Artiest:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(41, 57);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(44, 20);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Jaar:";
            // 
            // txtSongName
            // 
            this.txtSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongName.Location = new System.Drawing.Point(88, 30);
            this.txtSongName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(155, 26);
            this.txtSongName.TabIndex = 4;
            // 
            // lblNummer
            // 
            this.lblNummer.AutoSize = true;
            this.lblNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNummer.Location = new System.Drawing.Point(15, 32);
            this.lblNummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNummer.Name = "lblNummer";
            this.lblNummer.Size = new System.Drawing.Size(73, 20);
            this.lblNummer.TabIndex = 5;
            this.lblNummer.Text = "Nummer:";
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(88, 106);
            this.btnAddSong.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(154, 29);
            this.btnAddSong.TabIndex = 3;
            this.btnAddSong.Text = "Voeg nummer toe";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddToPlaylist
            // 
            this.btnAddToPlaylist.Location = new System.Drawing.Point(13, 351);
            this.btnAddToPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToPlaylist.Name = "btnAddToPlaylist";
            this.btnAddToPlaylist.Size = new System.Drawing.Size(175, 26);
            this.btnAddToPlaylist.TabIndex = 8;
            this.btnAddToPlaylist.Text = "Toevoegen aan playlist";
            this.btnAddToPlaylist.UseVisualStyleBackColor = true;
            this.btnAddToPlaylist.Click += new System.EventHandler(this.btnAddToPlaylist_Click);
            // 
            // comboPlaylists
            // 
            this.comboPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlaylists.FormattingEnabled = true;
            this.comboPlaylists.Location = new System.Drawing.Point(14, 324);
            this.comboPlaylists.Margin = new System.Windows.Forms.Padding(2);
            this.comboPlaylists.Name = "comboPlaylists";
            this.comboPlaylists.Size = new System.Drawing.Size(176, 21);
            this.comboPlaylists.TabIndex = 9;
            // 
            // groupPlaylist
            // 
            this.groupPlaylist.Controls.Add(this.txtPlayListname);
            this.groupPlaylist.Controls.Add(this.label1);
            this.groupPlaylist.Controls.Add(this.btnAddPlaylist);
            this.groupPlaylist.Location = new System.Drawing.Point(472, 11);
            this.groupPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.groupPlaylist.Name = "groupPlaylist";
            this.groupPlaylist.Padding = new System.Windows.Forms.Padding(2);
            this.groupPlaylist.Size = new System.Drawing.Size(274, 113);
            this.groupPlaylist.TabIndex = 7;
            this.groupPlaylist.TabStop = false;
            this.groupPlaylist.Text = "Afspeellijst toevoegen";
            // 
            // txtPlayListname
            // 
            this.txtPlayListname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayListname.Location = new System.Drawing.Point(88, 29);
            this.txtPlayListname.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayListname.Name = "txtPlayListname";
            this.txtPlayListname.Size = new System.Drawing.Size(155, 26);
            this.txtPlayListname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naam:";
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.Location = new System.Drawing.Point(88, 59);
            this.btnAddPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(155, 29);
            this.btnAddPlaylist.TabIndex = 3;
            this.btnAddPlaylist.Text = "Maak afspeellijst";
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.Location = new System.Drawing.Point(14, 381);
            this.btnPlaySong.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.Size = new System.Drawing.Size(175, 26);
            this.btnPlaySong.TabIndex = 10;
            this.btnPlaySong.Text = "Nummer afspelen";
            this.btnPlaySong.UseVisualStyleBackColor = true;
            this.btnPlaySong.Click += new System.EventHandler(this.btnPlaySong_Click);
            // 
            // listPlaylists
            // 
            this.listPlaylists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPlaylists.FormattingEnabled = true;
            this.listPlaylists.Location = new System.Drawing.Point(194, 41);
            this.listPlaylists.Margin = new System.Windows.Forms.Padding(2);
            this.listPlaylists.Name = "listPlaylists";
            this.listPlaylists.Size = new System.Drawing.Size(177, 275);
            this.listPlaylists.TabIndex = 11;
            // 
            // btnPlayPlaylist
            // 
            this.btnPlayPlaylist.Location = new System.Drawing.Point(194, 320);
            this.btnPlayPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayPlaylist.Name = "btnPlayPlaylist";
            this.btnPlayPlaylist.Size = new System.Drawing.Size(175, 26);
            this.btnPlayPlaylist.TabIndex = 12;
            this.btnPlayPlaylist.Text = "Afspeellijst afspelen";
            this.btnPlayPlaylist.UseVisualStyleBackColor = true;
            this.btnPlayPlaylist.Click += new System.EventHandler(this.btnPlayPlaylist_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 418);
            this.Controls.Add(this.btnPlayPlaylist);
            this.Controls.Add(this.listPlaylists);
            this.Controls.Add(this.btnPlaySong);
            this.Controls.Add(this.groupPlaylist);
            this.Controls.Add(this.comboPlaylists);
            this.Controls.Add(this.btnAddToPlaylist);
            this.Controls.Add(this.groupAddSong);
            this.Controls.Add(this.groupAddArtist);
            this.Controls.Add(this.lblPlaying);
            this.Controls.Add(this.lblPlayingtext);
            this.Controls.Add(this.listSongs);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ComboBox comboPlaylists;
        private System.Windows.Forms.ComboBox comboArtists;
        private System.Windows.Forms.NumericUpDown nmrSongYear;
        private System.Windows.Forms.GroupBox groupPlaylist;
        private System.Windows.Forms.TextBox txtPlayListname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.Button btnPlaySong;
        private System.Windows.Forms.ListBox listPlaylists;
        private System.Windows.Forms.Button btnPlayPlaylist;
    }
}

