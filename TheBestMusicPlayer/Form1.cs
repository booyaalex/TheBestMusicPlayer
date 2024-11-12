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

namespace TheBestMusicPlayer
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        bool playing = false;
        int mode = 0; //0: Normal; 1: Shuffle; 2: Repeat;
        int currentId = -1;
        Song[] songs = new Song[0];
        int[] queue = new int[0];
        System.Timers.Timer timer1 = new System.Timers.Timer();
        int timeCount = 0;
        System.Timers.Timer timer2 = new System.Timers.Timer();
        Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
            this.Text = "The Best Music Player";
            MakeMusicList();
            GetFiles();
        }
        private void GetFiles()
        {
            try
            {
                string username = Environment.ExpandEnvironmentVariables(@"C:\Users\%USERNAME%\");
                string[] dirs = Directory.GetFiles(username + @"Music", "*.mp3", SearchOption.AllDirectories);
                Console.WriteLine("Music files present: {0}", dirs.Length);
                int count = 0;
                songs = new Song[dirs.Length];
                queue = new int[dirs.Length];
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);

                    TagLib.File tagFile = TagLib.File.Create(dir);
                    string artist = tagFile.Tag.FirstPerformer;
                    string album = tagFile.Tag.Album;
                    string title = tagFile.Tag.Title;
                    double duration = tagFile.Properties.Duration.TotalSeconds;
                    int track = (int)tagFile.Tag.Track;
                    int trackCount = (int)tagFile.Tag.TrackCount;

                    string[] row = { title, album, artist, dir };
                    MusicPage_TrackList.Items.Add(track.ToString()).SubItems.AddRange(row);
                    MusicPage_TrackList.Items[count].Tag = count;
                    Console.WriteLine(MusicPage_TrackList.Items[count].Tag);

                    songs[count] = new Song(title, album, artist, duration, track, trackCount, dir);
                    queue[count] = count;

                    count++;
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
        private void MakeMusicList()
        {
            Console.WriteLine("Hello");
            MusicPage_TrackList.Columns.Clear();
            MusicPage_TrackList.Columns.Add("#", -1, HorizontalAlignment.Center);
            MusicPage_TrackList.Columns.Add("Name", -1);
            MusicPage_TrackList.Columns.Add("Album", -1);
            MusicPage_TrackList.Columns.Add("Artist", -1);
            MusicPage_TrackList.Columns.Add("Path", 0);
        }

        private void PlaySong(int id)
        {
            timer2.Stop();
            timer1.Stop();
            timeCount = 0;

            //Play Audio File
            wplayer.URL = songs[id].path;
            wplayer.controls.play();
            if(currentId == -1)
            {
                currentId = id;
            }
            playing = true;

            CurrentTrack_PlayButton.Image = Properties.Resources.Pause;

            //Update Player
            CurrentTrack_TrackTitle.Text = songs[id].title;
            CurrentTrack_Artist.Text = songs[id].artist;
            CurrentTrack_TrackPosition.Text = songs[id].track + "/" + songs[id].trackCount;

            TagLib.File tagFile = TagLib.File.Create(songs[id].path);
            MemoryStream ms = new MemoryStream(tagFile.Tag.Pictures[0].Data.Data);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
            CurrentTrack_CoverImage.Image = image;

            //TimeBar Stuff
            TimeSpan time = TimeSpan.FromSeconds(songs[id].duration);
            CurrentTrack_TrackLength.Text = "00:00/" + time.ToString(@"mm\:ss");
            CurrentTrack_TimeBar.Value = 0;

            timer1 = new System.Timers.Timer(time.TotalSeconds);
            timer1.Elapsed += delegate { SecondsTimer(id); };
            timer1.Interval = 1000;
            timer1.Enabled = true;

            timer2 = new System.Timers.Timer(time.TotalSeconds);
            timer2.Elapsed += delegate { BarTimer(); };
            timer2.Interval = time.TotalMilliseconds / 100;
            timer2.Enabled = true;
        }
        private void NextSong()
        {
            if (mode == 2)
            {
                PlaySong(currentId);
            } else
            {
                if ((currentId + 1) >= songs.Length)
                {
                    currentId = 0;
                    PlaySong(queue[currentId]);
                }
                else
                {
                    currentId++;
                    PlaySong(queue[currentId]);
                }
            }

        }
        private void PreviousSong()
        {
            if (mode == 2)
            {
                PlaySong(currentId);
            }
            else
            {
                if ((currentId - 1) <= -1)
                {
                    currentId = songs.Length - 1;
                    PlaySong(queue[currentId]);
                }
                else
                {
                    currentId--;
                    PlaySong(queue[currentId]);
                }
            }
        }
        private void SecondsTimer(int id)
        {
            CurrentTrack_TimeBar.Invoke((MethodInvoker) delegate
            {
                TimeSpan time = TimeSpan.FromSeconds(songs[id].duration);
                CurrentTrack_TrackLength.Text = wplayer.controls.currentPositionString + "/" + time.ToString(@"mm\:ss");
                timeCount++;
                if (timeCount >= Math.Floor(time.TotalSeconds))
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer1.Stop();
                    timer2.Stop();
                    NextSong();
                }
            });
            
        }
        private void BarTimer()
        {
            CurrentTrack_TimeBar.Invoke((MethodInvoker)delegate
            {
                CurrentTrack_TimeBar.Value += 1;
            });

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
                currentId = (int)MusicPage_TrackList.SelectedItems[0].Tag;
                PlaySong(currentId);
            }
        }

        private void CurrentTrack_PlayButton_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                playing = false;
                wplayer.controls.pause();
                CurrentTrack_PlayButton.Image = Properties.Resources.Play;
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            else if (!playing)
            {
                playing = true;
                wplayer.controls.play();
                CurrentTrack_PlayButton.Image = Properties.Resources.Pause;
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
        }

        private void CurrentTrack_NextButton_Click(object sender, EventArgs e)
        {
            NextSong();
        }

        private void CurrentTrack_PreviousButton_Click(object sender, EventArgs e)
        {
            PreviousSong();
        }

        private void CurrentTrack_RepeatButton_Click(object sender, EventArgs e)
        {
            
            if (mode == 0)
            {
                mode = 1;
                CurrentTrack_RepeatButton.Image = Properties.Resources.Shuffle;
                queue.Shuffle();
            }
            else if (mode == 1)
            {
                mode = 2;
                CurrentTrack_RepeatButton.Image = Properties.Resources.Repeat;
            }
            else if (mode == 2)
            {
                mode = 0;
                CurrentTrack_RepeatButton.Image = Properties.Resources.Circle;
                for (int i = 0; i < queue.Count(); i++)
                {
                    queue[i] = i;
                }
            }
            Console.WriteLine(mode);
        }
    }
    public class Song
    {
        public String title;
        public String album;
        public String artist;
        public double duration;
        public int track;
        public int trackCount;
        public String path;
        public Song(String title, String album, String artist, Double duration, Int32 track, Int32 trackCount, String path)
        {
            this.title = title;
            this.album = album;
            this.artist = artist;
            this.duration = duration;
            this.track = track;
            this.trackCount = trackCount;
            this.path = path;
        }
    }
}
