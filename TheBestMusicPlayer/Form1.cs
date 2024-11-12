using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using static System.Net.WebRequestMethods;
using System.Timers;
using static System.Random;
using Medallion;
using TagLib;
using TagLib.Aac;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace TheBestMusicPlayer
{
    public partial class mainForm : Form
    {
        Control control = new Control();

        public mainForm()
        {
            InitializeComponent();
            this.Text = "The Best Music Player";
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            var control = new Control();
            DisplaySongs(control.GetFiles());
        }

        public void DisplaySongs(Song[] songs)
        {
            for (int i = 0; i < songs.Length; i++)
            {
                Song song = songs[i];

                string[] row = { song.title, song.album, song.artist, song.path };
                MusicPage_TrackList.Items.Add(song.track.ToString()).SubItems.AddRange(row);
                MusicPage_TrackList.Items[i].Tag = songs[i];
            }
        }

        public void PlaySong(Song song)
        {
            SongData songData = control.PlaySong(song);
            

            //Update Player
            CurrentTrack_TrackTitle.Text = song.title;
            CurrentTrack_Artist.Text = song.artist;
            CurrentTrack_TrackPosition.Text = song.track + "/" + song.trackCount;
            
            CurrentTrack_CoverImage.Image = songData.image;

            CurrentTrack_PlayButton.Image = Properties.Resources.Pause;

            CurrentTrack_TrackLength.Text = "00:00/" + songData.time.ToString(@"mm\:ss");
            CurrentTrack_TimeBar.Value = 0;
        }
       
        private void NavBar_ButtonMain_Click(object sender, EventArgs e)
        {
            MainPage.Visible = true;
            MusicPage.Visible = false;
        }

        private void NavBar_ButtonMusic_Click(object sender, EventArgs e)
        {
            MainPage.Visible = false;
            MusicPage.Visible = true;
        }

        private void MusicPage_TrackList_DoubleClick(object sender, EventArgs e)
        {
            if (MusicPage_TrackList.SelectedItems.Count > 0)
            {
                control.currentSong = (Song)MusicPage_TrackList.SelectedItems[0].Tag;
                PlaySong(control.currentSong);
            }
        }

        private void CurrentTrack_PlayButton_Click(object sender, EventArgs e)
        {
            CurrentTrack_PlayButton.Image = control.TogglePlay();
        }

        private void CurrentTrack_NextButton_Click(object sender, EventArgs e)
        {
            control.NextSong();
        }

        private void CurrentTrack_PreviousButton_Click(object sender, EventArgs e)
        {
            control.PreviousSong();
        }

        private void CurrentTrack_RepeatButton_Click(object sender, EventArgs e)
        {
            CurrentTrack_RepeatButton.Image = control.ChangeMode();
        }
    }
}
