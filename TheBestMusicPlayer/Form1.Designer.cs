namespace TheBestMusicPlayer
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.NavagationBar = new System.Windows.Forms.ToolStrip();
            this.NavBar_Title = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NavBar_ButtonMain = new System.Windows.Forms.ToolStripButton();
            this.NavBar_ButtonMusic = new System.Windows.Forms.ToolStripButton();
            this.NavBar_ButtonPlaylists = new System.Windows.Forms.ToolStripButton();
            this.NavBar_ButtonStats = new System.Windows.Forms.ToolStripButton();
            this.CurrentTrack = new System.Windows.Forms.Panel();
            this.CurrentTrack_CoverImage = new System.Windows.Forms.PictureBox();
            this.CurrentTrack_RepeatButton = new System.Windows.Forms.PictureBox();
            this.CurrentTrack_NextButton = new System.Windows.Forms.PictureBox();
            this.CurrentTrack_PreviousButton = new System.Windows.Forms.PictureBox();
            this.CurrentTrack_PlayButton = new System.Windows.Forms.PictureBox();
            this.CurrentTrack_TrackPosition = new System.Windows.Forms.Label();
            this.CurrentTrack_TrackLength = new System.Windows.Forms.Label();
            this.CurrentTrack_Artist = new System.Windows.Forms.Label();
            this.CurrentTrack_TrackTitle = new System.Windows.Forms.Label();
            this.CurrentTrack_TimeBar = new System.Windows.Forms.ProgressBar();
            this.MusicPage = new System.Windows.Forms.Panel();
            this.MainPage = new System.Windows.Forms.Panel();
            this.MusicPage_TrackList = new System.Windows.Forms.ListView();
            this.track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusicPage_Navigation = new System.Windows.Forms.Panel();
            this.NavagationBar.SuspendLayout();
            this.CurrentTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTrack_CoverImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTrack_RepeatButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTrack_NextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTrack_PreviousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTrack_PlayButton)).BeginInit();
            this.MusicPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavagationBar
            // 
            this.NavagationBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NavagationBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.NavagationBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NavBar_Title,
            this.toolStripSeparator1,
            this.NavBar_ButtonMain,
            this.NavBar_ButtonMusic,
            this.NavBar_ButtonPlaylists,
            this.NavBar_ButtonStats});
            this.NavagationBar.Location = new System.Drawing.Point(0, 0);
            this.NavagationBar.Name = "NavagationBar";
            this.NavagationBar.Size = new System.Drawing.Size(800, 25);
            this.NavagationBar.TabIndex = 0;
            // 
            // NavBar_Title
            // 
            this.NavBar_Title.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBar_Title.Name = "NavBar_Title";
            this.NavBar_Title.Size = new System.Drawing.Size(135, 22);
            this.NavBar_Title.Text = "The Best Music Player!";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // NavBar_ButtonMain
            // 
            this.NavBar_ButtonMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavBar_ButtonMain.Image = ((System.Drawing.Image)(resources.GetObject("NavBar_ButtonMain.Image")));
            this.NavBar_ButtonMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavBar_ButtonMain.Name = "NavBar_ButtonMain";
            this.NavBar_ButtonMain.Size = new System.Drawing.Size(23, 22);
            this.NavBar_ButtonMain.Text = "toolStripButton1";
            this.NavBar_ButtonMain.Click += new System.EventHandler(this.NavBar_ButtonMain_Click);
            // 
            // NavBar_ButtonMusic
            // 
            this.NavBar_ButtonMusic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavBar_ButtonMusic.Image = ((System.Drawing.Image)(resources.GetObject("NavBar_ButtonMusic.Image")));
            this.NavBar_ButtonMusic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavBar_ButtonMusic.Name = "NavBar_ButtonMusic";
            this.NavBar_ButtonMusic.Size = new System.Drawing.Size(23, 22);
            this.NavBar_ButtonMusic.Text = "toolStripButton2";
            this.NavBar_ButtonMusic.Click += new System.EventHandler(this.NavBar_ButtonMusic_Click);
            // 
            // NavBar_ButtonPlaylists
            // 
            this.NavBar_ButtonPlaylists.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavBar_ButtonPlaylists.Image = ((System.Drawing.Image)(resources.GetObject("NavBar_ButtonPlaylists.Image")));
            this.NavBar_ButtonPlaylists.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavBar_ButtonPlaylists.Name = "NavBar_ButtonPlaylists";
            this.NavBar_ButtonPlaylists.Size = new System.Drawing.Size(23, 22);
            this.NavBar_ButtonPlaylists.Text = "toolStripButton3";
            // 
            // NavBar_ButtonStats
            // 
            this.NavBar_ButtonStats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavBar_ButtonStats.Image = ((System.Drawing.Image)(resources.GetObject("NavBar_ButtonStats.Image")));
            this.NavBar_ButtonStats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavBar_ButtonStats.Name = "NavBar_ButtonStats";
            this.NavBar_ButtonStats.Size = new System.Drawing.Size(23, 22);
            this.NavBar_ButtonStats.Text = "toolStripButton4";
            // 
            // CurrentTrack
            // 
            this.CurrentTrack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CurrentTrack.Controls.Add(this.CurrentTrack_CoverImage);
            this.CurrentTrack.Controls.Add(this.CurrentTrack_RepeatButton);
            this.CurrentTrack.Controls.Add(this.CurrentTrack_NextButton);
            this.CurrentTrack.Controls.Add(this.CurrentTrack_PreviousButton);
            this.CurrentTrack.Controls.Add(this.CurrentTrack_PlayButton);
            this.CurrentTrack.Controls.Add(this.CurrentTrack_TrackPosition);
            this.CurrentTrack.Controls.Add(this.CurrentTrack_TrackLength);
            this.CurrentTrack.Controls.Add(this.CurrentTrack_Artist);
            this.CurrentTrack.Controls.Add(this.CurrentTrack_TrackTitle);
            this.CurrentTrack.Controls.Add(this.CurrentTrack_TimeBar);
            this.CurrentTrack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CurrentTrack.Location = new System.Drawing.Point(0, 394);
            this.CurrentTrack.Name = "CurrentTrack";
            this.CurrentTrack.Size = new System.Drawing.Size(800, 56);
            this.CurrentTrack.TabIndex = 2;
            // 
            // CurrentTrack_CoverImage
            // 
            this.CurrentTrack_CoverImage.Location = new System.Drawing.Point(7, 3);
            this.CurrentTrack_CoverImage.Name = "CurrentTrack_CoverImage";
            this.CurrentTrack_CoverImage.Size = new System.Drawing.Size(50, 50);
            this.CurrentTrack_CoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentTrack_CoverImage.TabIndex = 14;
            this.CurrentTrack_CoverImage.TabStop = false;
            // 
            // CurrentTrack_RepeatButton
            // 
            this.CurrentTrack_RepeatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CurrentTrack_RepeatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentTrack_RepeatButton.Image = ((System.Drawing.Image)(resources.GetObject("CurrentTrack_RepeatButton.Image")));
            this.CurrentTrack_RepeatButton.Location = new System.Drawing.Point(565, 17);
            this.CurrentTrack_RepeatButton.Name = "CurrentTrack_RepeatButton";
            this.CurrentTrack_RepeatButton.Size = new System.Drawing.Size(16, 16);
            this.CurrentTrack_RepeatButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentTrack_RepeatButton.TabIndex = 13;
            this.CurrentTrack_RepeatButton.TabStop = false;
            this.CurrentTrack_RepeatButton.Click += new System.EventHandler(this.CurrentTrack_RepeatButton_Click);
            // 
            // CurrentTrack_NextButton
            // 
            this.CurrentTrack_NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CurrentTrack_NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentTrack_NextButton.Image = ((System.Drawing.Image)(resources.GetObject("CurrentTrack_NextButton.Image")));
            this.CurrentTrack_NextButton.Location = new System.Drawing.Point(543, 17);
            this.CurrentTrack_NextButton.Name = "CurrentTrack_NextButton";
            this.CurrentTrack_NextButton.Size = new System.Drawing.Size(16, 16);
            this.CurrentTrack_NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentTrack_NextButton.TabIndex = 12;
            this.CurrentTrack_NextButton.TabStop = false;
            this.CurrentTrack_NextButton.Click += new System.EventHandler(this.CurrentTrack_NextButton_Click);
            // 
            // CurrentTrack_PreviousButton
            // 
            this.CurrentTrack_PreviousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CurrentTrack_PreviousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentTrack_PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("CurrentTrack_PreviousButton.Image")));
            this.CurrentTrack_PreviousButton.Location = new System.Drawing.Point(258, 17);
            this.CurrentTrack_PreviousButton.Name = "CurrentTrack_PreviousButton";
            this.CurrentTrack_PreviousButton.Size = new System.Drawing.Size(16, 16);
            this.CurrentTrack_PreviousButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentTrack_PreviousButton.TabIndex = 11;
            this.CurrentTrack_PreviousButton.TabStop = false;
            this.CurrentTrack_PreviousButton.Click += new System.EventHandler(this.CurrentTrack_PreviousButton_Click);
            // 
            // CurrentTrack_PlayButton
            // 
            this.CurrentTrack_PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CurrentTrack_PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentTrack_PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("CurrentTrack_PlayButton.Image")));
            this.CurrentTrack_PlayButton.Location = new System.Drawing.Point(236, 17);
            this.CurrentTrack_PlayButton.Name = "CurrentTrack_PlayButton";
            this.CurrentTrack_PlayButton.Size = new System.Drawing.Size(16, 16);
            this.CurrentTrack_PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentTrack_PlayButton.TabIndex = 5;
            this.CurrentTrack_PlayButton.TabStop = false;
            this.CurrentTrack_PlayButton.Click += new System.EventHandler(this.CurrentTrack_PlayButton_Click);
            // 
            // CurrentTrack_TrackPosition
            // 
            this.CurrentTrack_TrackPosition.AutoSize = true;
            this.CurrentTrack_TrackPosition.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTrack_TrackPosition.Location = new System.Drawing.Point(63, 37);
            this.CurrentTrack_TrackPosition.Name = "CurrentTrack_TrackPosition";
            this.CurrentTrack_TrackPosition.Size = new System.Drawing.Size(25, 16);
            this.CurrentTrack_TrackPosition.TabIndex = 10;
            this.CurrentTrack_TrackPosition.Text = "0/0";
            // 
            // CurrentTrack_TrackLength
            // 
            this.CurrentTrack_TrackLength.AutoSize = true;
            this.CurrentTrack_TrackLength.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTrack_TrackLength.Location = new System.Drawing.Point(277, 36);
            this.CurrentTrack_TrackLength.Name = "CurrentTrack_TrackLength";
            this.CurrentTrack_TrackLength.Size = new System.Drawing.Size(69, 16);
            this.CurrentTrack_TrackLength.TabIndex = 9;
            this.CurrentTrack_TrackLength.Text = "00:00/02:30";
            // 
            // CurrentTrack_Artist
            // 
            this.CurrentTrack_Artist.AutoSize = true;
            this.CurrentTrack_Artist.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTrack_Artist.Location = new System.Drawing.Point(63, 23);
            this.CurrentTrack_Artist.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentTrack_Artist.Name = "CurrentTrack_Artist";
            this.CurrentTrack_Artist.Size = new System.Drawing.Size(72, 18);
            this.CurrentTrack_Artist.TabIndex = 3;
            this.CurrentTrack_Artist.Text = "Artist Name";
            // 
            // CurrentTrack_TrackTitle
            // 
            this.CurrentTrack_TrackTitle.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTrack_TrackTitle.Location = new System.Drawing.Point(62, 3);
            this.CurrentTrack_TrackTitle.MaximumSize = new System.Drawing.Size(190, 20);
            this.CurrentTrack_TrackTitle.Name = "CurrentTrack_TrackTitle";
            this.CurrentTrack_TrackTitle.Size = new System.Drawing.Size(190, 20);
            this.CurrentTrack_TrackTitle.TabIndex = 2;
            this.CurrentTrack_TrackTitle.Text = "Select A Song";
            // 
            // CurrentTrack_TimeBar
            // 
            this.CurrentTrack_TimeBar.AccessibleName = "TimeBar";
            this.CurrentTrack_TimeBar.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.CurrentTrack_TimeBar.Location = new System.Drawing.Point(280, 17);
            this.CurrentTrack_TimeBar.MarqueeAnimationSpeed = 0;
            this.CurrentTrack_TimeBar.Name = "CurrentTrack_TimeBar";
            this.CurrentTrack_TimeBar.Size = new System.Drawing.Size(256, 16);
            this.CurrentTrack_TimeBar.Step = 1;
            this.CurrentTrack_TimeBar.TabIndex = 0;
            // 
            // MusicPage
            // 
            this.MusicPage.Controls.Add(this.MainPage);
            this.MusicPage.Controls.Add(this.MusicPage_TrackList);
            this.MusicPage.Controls.Add(this.MusicPage_Navigation);
            this.MusicPage.Location = new System.Drawing.Point(0, 28);
            this.MusicPage.Name = "MusicPage";
            this.MusicPage.Size = new System.Drawing.Size(800, 360);
            this.MusicPage.TabIndex = 1;
            // 
            // MainPage
            // 
            this.MainPage.Location = new System.Drawing.Point(643, 208);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(800, 360);
            this.MainPage.TabIndex = 1;
            // 
            // MusicPage_TrackList
            // 
            this.MusicPage_TrackList.BackColor = System.Drawing.SystemColors.Control;
            this.MusicPage_TrackList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.track,
            this.name,
            this.album,
            this.artist,
            this.path});
            this.MusicPage_TrackList.FullRowSelect = true;
            this.MusicPage_TrackList.GridLines = true;
            this.MusicPage_TrackList.HideSelection = false;
            this.MusicPage_TrackList.Location = new System.Drawing.Point(135, 0);
            this.MusicPage_TrackList.MultiSelect = false;
            this.MusicPage_TrackList.Name = "MusicPage_TrackList";
            this.MusicPage_TrackList.Size = new System.Drawing.Size(665, 360);
            this.MusicPage_TrackList.TabIndex = 4;
            this.MusicPage_TrackList.UseCompatibleStateImageBehavior = false;
            this.MusicPage_TrackList.View = System.Windows.Forms.View.Details;
            this.MusicPage_TrackList.DoubleClick += new System.EventHandler(this.MusicPage_TrackList_DoubleClick);
            // 
            // track
            // 
            this.track.Text = "#";
            this.track.Width = 25;
            // 
            // name
            // 
            this.name.Text = "Song";
            this.name.Width = 37;
            // 
            // album
            // 
            this.album.Text = "Album";
            this.album.Width = 41;
            // 
            // artist
            // 
            this.artist.Text = "Artist";
            this.artist.Width = 35;
            // 
            // path
            // 
            this.path.Text = "Path";
            this.path.Width = 0;
            // 
            // MusicPage_Navigation
            // 
            this.MusicPage_Navigation.Location = new System.Drawing.Point(0, 0);
            this.MusicPage_Navigation.Name = "MusicPage_Navigation";
            this.MusicPage_Navigation.Size = new System.Drawing.Size(129, 360);
            this.MusicPage_Navigation.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentTrack);
            this.Controls.Add(this.MusicPage);
            this.Controls.Add(this.NavagationBar);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.NavagationBar.ResumeLayout(false);
            this.NavagationBar.PerformLayout();
            this.CurrentTrack.ResumeLayout(false);
            this.CurrentTrack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTrack_CoverImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTrack_RepeatButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTrack_NextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTrack_PreviousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTrack_PlayButton)).EndInit();
            this.MusicPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip NavagationBar;
        private System.Windows.Forms.ToolStripLabel NavBar_Title;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton NavBar_ButtonMain;
        private System.Windows.Forms.ToolStripButton NavBar_ButtonMusic;
        private System.Windows.Forms.ToolStripButton NavBar_ButtonPlaylists;
        private System.Windows.Forms.ToolStripButton NavBar_ButtonStats;
        private System.Windows.Forms.Panel CurrentTrack;
        private System.Windows.Forms.Label CurrentTrack_Artist;
        private System.Windows.Forms.Label CurrentTrack_TrackTitle;
        private System.Windows.Forms.Label CurrentTrack_TrackLength;
        private System.Windows.Forms.Label CurrentTrack_TrackPosition;
        private System.Windows.Forms.Panel MusicPage;
        private System.Windows.Forms.Panel MainPage;
        private System.Windows.Forms.Panel MusicPage_Navigation;
        private System.Windows.Forms.PictureBox CurrentTrack_PlayButton;
        private System.Windows.Forms.PictureBox CurrentTrack_PreviousButton;
        private System.Windows.Forms.PictureBox CurrentTrack_NextButton;
        public System.Windows.Forms.ProgressBar CurrentTrack_TimeBar;
        private System.Windows.Forms.PictureBox CurrentTrack_RepeatButton;
        private System.Windows.Forms.PictureBox CurrentTrack_CoverImage;
        private System.Windows.Forms.ColumnHeader track;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader album;
        private System.Windows.Forms.ColumnHeader artist;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.ListView MusicPage_TrackList;
    }
}

