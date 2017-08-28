using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_loud
{
    class song
    {
        private string title;
        private TimeSpan lenght;
        private string artist;
        private string album;
        private string path;


        public song(string title, TimeSpan lenght, string artist, string album)
        {
            this.title = title;
            this.lenght = lenght;
            this.artist = artist;
            this.album = album;
        }

        public string Title { get => title; set => title = value; }
        public TimeSpan Lenght { get => lenght; set => lenght = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Album { get => album; set => album = value; }
        public string Path { get => path; set => path = value; }
    }
}
