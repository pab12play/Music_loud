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
        private TimeSpan length;
        private string artist;
        private string album;
        private string path;


        public song(string title, TimeSpan length, string artist, string album,string path)
        {
            this.title = title;
            this.length = length;
            this.artist = artist;
            this.album = album;
            this.path = path;
        }

        public string Title { get => title; set => title = value; }
        public TimeSpan Length { get => length; set => length = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Album { get => album; set => album = value; }
        public string Path { get => path; set => path = value; }
    }
}
