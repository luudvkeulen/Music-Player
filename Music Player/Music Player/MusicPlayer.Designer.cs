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
            this.lblPlaying = new System.Windows.Forms.Label();
            this.lblSongplaying = new System.Windows.Forms.Label();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.lblArtistname = new System.Windows.Forms.Label();
            this.groupAddArtist = new System.Windows.Forms.GroupBox();
            this.groupAddSong = new System.Windows.Forms.GroupBox();
            this.lblSongArtist = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.lblNummer = new System.Windows.Forms.Label();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnAddToPlaylist = new System.Windows.Forms.Button();
            this.comboPlaylists = new System.Windows.Forms.ComboBox();
            this.comboArtists = new System.Windows.Forms.ComboBox();
            this.nmrSongYear = new System.Windows.Forms.NumericUpDown();
            this.groupAddArtist.SuspendLayout();
            this.groupAddSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSongYear)).BeginInit();
            this.SuspendLayout();
            // 
            // listSongs
            // 
            this.listSongs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSongs.FormattingEnabled = true;
            this.listSongs.ItemHeight = 16;
            this.listSongs.Location = new System.Drawing.Point(17, 50);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(235, 306);
            this.listSongs.TabIndex = 0;
            // 
            // lblPlaying
            // 
            this.lblPlaying.AutoSize = true;
            this.lblPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaying.Location = new System.Drawing.Point(12, 9);
            this.lblPlaying.Name = "lblPlaying";
            this.lblPlaying.Size = new System.Drawing.Size(82, 25);
            this.lblPlaying.TabIndex = 1;
            this.lblPlaying.Text = "Playing:";
            // 
            // lblSongplaying
            // 
            this.lblSongplaying.AutoSize = true;
            this.lblSongplaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongplaying.Location = new System.Drawing.Point(100, 9);
            this.lblSongplaying.Name = "lblSongplaying";
            this.lblSongplaying.Size = new System.Drawing.Size(152, 25);
            this.lblSongplaying.TabIndex = 2;
            this.lblSongplaying.Text = "No song playing";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(152, 78);
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
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(171, 30);
            this.txtArtistName.TabIndex = 4;
            // 
            // lblArtistname
            // 
            this.lblArtistname.AutoSize = true;
            this.lblArtistname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistname.Location = new System.Drawing.Point(24, 40);
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
            this.groupAddArtist.Location = new System.Drawing.Point(258, 12);
            this.groupAddArtist.Name = "groupAddArtist";
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
            this.groupAddSong.Location = new System.Drawing.Point(258, 157);
            this.groupAddSong.Name = "groupAddSong";
            this.groupAddSong.Size = new System.Drawing.Size(365, 192);
            this.groupAddSong.TabIndex = 7;
            this.groupAddSong.TabStop = false;
            this.groupAddSong.Text = "Liedje toevoegen";
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
            this.txtSongName.Location = new System.Drawing.Point(118, 37);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(205, 30);
            this.txtSongName.TabIndex = 4;
            // 
            // lblNummer
            // 
            this.lblNummer.AutoSize = true;
            this.lblNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNummer.Location = new System.Drawing.Point(20, 40);
            this.lblNummer.Name = "lblNummer";
            this.lblNummer.Size = new System.Drawing.Size(92, 25);
            this.lblNummer.TabIndex = 5;
            this.lblNummer.Text = "Nummer:";
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(118, 131);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(205, 36);
            this.btnAddSong.TabIndex = 3;
            this.btnAddSong.Text = "Voeg nummer toe";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddToPlaylist
            // 
            this.btnAddToPlaylist.Location = new System.Drawing.Point(17, 392);
            this.btnAddToPlaylist.Name = "btnAddToPlaylist";
            this.btnAddToPlaylist.Size = new System.Drawing.Size(233, 32);
            this.btnAddToPlaylist.TabIndex = 8;
            this.btnAddToPlaylist.Text = "Toevoegen aan playlist";
            this.btnAddToPlaylist.UseVisualStyleBackColor = true;
            // 
            // comboPlaylists
            // 
            this.comboPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlaylists.FormattingEnabled = true;
            this.comboPlaylists.Location = new System.Drawing.Point(17, 362);
            this.comboPlaylists.Name = "comboPlaylists";
            this.comboPlaylists.Size = new System.Drawing.Size(233, 24);
            this.comboPlaylists.TabIndex = 9;
            // 
            // comboArtists
            // 
            this.comboArtists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboArtists.FormattingEnabled = true;
            this.comboArtists.Location = new System.Drawing.Point(118, 101);
            this.comboArtists.Name = "comboArtists";
            this.comboArtists.Size = new System.Drawing.Size(205, 24);
            this.comboArtists.TabIndex = 8;
            // 
            // nmrSongYear
            // 
            this.nmrSongYear.Location = new System.Drawing.Point(118, 70);
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
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 471);
            this.Controls.Add(this.comboPlaylists);
            this.Controls.Add(this.btnAddToPlaylist);
            this.Controls.Add(this.groupAddSong);
            this.Controls.Add(this.groupAddArtist);
            this.Controls.Add(this.lblSongplaying);
            this.Controls.Add(this.lblPlaying);
            this.Controls.Add(this.listSongs);
            this.Name = "MusicPlayer";
            this.Text = "Music Player";
            this.groupAddArtist.ResumeLayout(false);
            this.groupAddArtist.PerformLayout();
            this.groupAddSong.ResumeLayout(false);
            this.groupAddSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSongYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSongs;
        private System.Windows.Forms.Label lblPlaying;
        private System.Windows.Forms.Label lblSongplaying;
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
    }
}

