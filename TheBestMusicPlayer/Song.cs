using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestMusicPlayer
{
    public class Song
    {
        public string title { get; set; }
        public string album { get; set; }
        public string artist { get; set; }
        public double duration { get; set; }
        public int track { get; set; }
        public int trackCount { get; set; }
        public string path { get; set; }
    }
}
