using Medallion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestMusicPlayer
{
    public class Control
    {
        public Song[] songs = new Song[0];
        public int[] queue = new int[0];
        public int mode = 0; //0: Normal; 1: Shuffle; 2: Repeat;
        int currentId = -1;
        public Song currentSong = new Song();
        Random rng = new Random();

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        bool playing = false;


        public Control() {}
        public Song[] GetFiles()
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
                    Console.WriteLine(tagFile.Tag.Track);
                    Song song = new Song()
                    {
                        artist = tagFile.Tag.FirstPerformer,
                        album = tagFile.Tag.Album,
                        title = tagFile.Tag.Title,
                        duration = tagFile.Properties.Duration.TotalSeconds,
                        track = (int)tagFile.Tag.Track,
                        trackCount = (int)tagFile.Tag.TrackCount,
                        path = dir,
                    };
                    songs[count] = song;
                    queue[count] = count;

                    count++;
                }
                return songs;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public SongData PlaySong(Song song)
        {

            //Play Audio File
            wplayer.URL = song.path;
            wplayer.controls.play();
            playing = true;


            //Image
            TagLib.File tagFile = TagLib.File.Create(song.path);
            MemoryStream ms = new MemoryStream(tagFile.Tag.Pictures[0].Data.Data);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);


            TimeSpan time = TimeSpan.FromSeconds(song.duration);


            return new SongData()
            {
                image = image,
                time = time,
            };
        }
        public void NextSong()
        {
            mainForm form = new mainForm();
            Console.WriteLine(songs);
            if ((currentId + 1) >= songs.Length)
                {
                    currentId = 0;
                    form.PlaySong(songs[currentId]);
                }
                else
                {
                    currentId++;
                    form.PlaySong(songs[0]);
                }
        }
        public void PreviousSong()
        {
            mainForm form = new mainForm();
            if (mode == 2)
            {
                form.PlaySong(currentSong);
            }
            else
            {
                if ((currentId - 1) <= -1)
                {
                    currentId = songs.Length - 1;
                    form.PlaySong(songs[0]);
                }
                else
                {
                    currentId--;
                    form.PlaySong(songs[0]);
                }
            }
        }
        public System.Drawing.Bitmap TogglePlay()
        {
            if (playing)
            {
                playing = false;
                wplayer.controls.pause();
                return Properties.Resources.Play;
            }
            else
            {
                playing = true;
                wplayer.controls.play();
                return Properties.Resources.Pause;
            }
        }
        public System.Drawing.Bitmap ChangeMode()
        {
            if (mode == 0)
            {
                mode = 1;
                queue.Shuffle();
                return Properties.Resources.Shuffle;
                
            }
            else if (mode == 1)
            {
                mode = 2;
                return Properties.Resources.Repeat;
            }
            else if (mode == 2)
            {
                mode = 0;
                for (int i = 0; i < queue.Count(); i++)
                {
                    queue[i] = i;
                }
                return Properties.Resources.Circle;
            }
            else
            {
                return Properties.Resources.Circle;
            }
        }
    }
    public class SongData
    {
        public System.Drawing.Image image { get; set; }
        public TimeSpan time { get; set; }
    }

}
