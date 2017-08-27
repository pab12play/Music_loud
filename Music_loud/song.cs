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
        private int lenght;
        private string author;
        private string album;
        private string path;


        public song(string title, int lenght, string author, string album)
        {
            this.title = title;
            this.lenght = lenght;
            this.author = author;
            this.album = album;
        }

        public string Title { get => title; set => title = value; }
        public int Lenght { get => lenght; set => lenght = value; }
        public string Author { get => author; set => author = value; }
        public string Album { get => album; set => album = value; }
        public string Path { get => path; set => path = value; }
    }
}
