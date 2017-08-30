using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Linq;

namespace Music_loud
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player;
        Dictionary<string, song> library;
        List<song> playlist;
        TimeSpan duration;
        bool ascending_title; //true ascending, false descending
        bool ascending_length; //true ascending, false descending
        string path_selected_song;

        public Form1()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            library = new Dictionary<string, song>();
            playlist = new List<song>();
            duration = TimeSpan.Zero;
            ascending_title = true;
            ascending_length = true;
            path_selected_song = "";
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if (listBox_library.SelectedIndex >= 0 || listBox_playlist.SelectedIndex >= 0)
            {
                player.URL = path_selected_song;
                player.controls.play();
            }
            else
            {
                MessageBox.Show("Choose a song");
            }
        }

        private void button_browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    text_path.Text = openFileDialog1.FileName;
                    TagLib.File tagFile = TagLib.File.Create(openFileDialog1.FileName);

                    text_artist.Text = tagFile.Tag.Performers[0];
                    text_title.Text = tagFile.Tag.Title;
                    text_album.Text = tagFile.Tag.Album;
                    text_length.Text = tagFile.Properties.Duration.ToString(@"mm\:ss");
                    duration = tagFile.Properties.Duration;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button_add_library_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_title.Text))
            {
                MessageBox.Show("Please enter the title of the song");
            }
            else
            {
                library.Add(text_title.Text, new song(text_title.Text, duration, text_artist.Text, text_album.Text,text_path.Text));
                listBox_library.Items.Add(text_title.Text);
            }
            
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_search.Text))
            {
                MessageBox.Show("Enter name of the song");
            }
            else if (library.ContainsKey(text_search.Text))
            {
                listBox_library.SelectedItem = text_search.Text;
            }
            else
            {
                MessageBox.Show("Song not found");
            }
        }

        private void button_playlist_Click(object sender, EventArgs e)
        {
            listBox_playlist.Items.Clear();
            playlist = new List<song>();
        }

        private void button_add_playlist_Click(object sender, EventArgs e)
        {
            if (listBox_library.SelectedIndex >= 0)
            {
                song song1 = library[listBox_library.SelectedItem.ToString()];
                playlist.Add(song1);
                listBox_playlist.Items.Add(song1.Length.ToString(@"mm\:ss") + (char)9 + song1.Title);
            }
            else
            {
                MessageBox.Show("Choose a song");
            }
        }

        private void button_order_name_Click(object sender, EventArgs e)
        {
            if (playlist.Count > 1)
            {
                listBox_playlist.Items.Clear();
                if (ascending_title)
                {
                    List<song> SortedList = playlist.OrderBy(x => x.Title).ToList();
                    foreach (song song1 in SortedList)
                    {
                        listBox_playlist.Items.Add(song1.Length.ToString(@"mm\:ss") + (char)9 + song1.Title);
                    }
                    playlist = SortedList;
                    button_order_name.Text = "Title (Z-A)";
                    ascending_title = false;
                }
                else
                {
                    List<song> SortedList = playlist.OrderByDescending(x => x.Title).ToList();
                    foreach (song song1 in SortedList)
                    {
                        listBox_playlist.Items.Add(song1.Length.ToString(@"mm\:ss") + (char)9 + song1.Title);
                    }
                    playlist = SortedList;
                    button_order_name.Text = "Title (A-Z)";
                    ascending_title = true;
                }
            }
        }

        private void button_order_length_Click(object sender, EventArgs e)
        {
            if (playlist.Count > 1)
            {
                listBox_playlist.Items.Clear();
                if (ascending_length)
                {
                    List<song> SortedList = playlist.OrderBy(x => x.Length).ToList();
                    foreach (song song1 in SortedList)
                    {
                        listBox_playlist.Items.Add(song1.Length.ToString(@"mm\:ss") + (char)9 + song1.Title);
                    }
                    playlist = SortedList;
                    button_order_length.Text = "Length Desc.";
                    ascending_length = false;
                }
                else
                {
                    List<song> SortedList = playlist.OrderByDescending(x => x.Length).ToList();
                    foreach (song song1 in SortedList)
                    {
                        listBox_playlist.Items.Add(song1.Length.ToString(@"mm\:ss") + (char)9 + song1.Title);
                    }
                    playlist = SortedList;
                    button_order_length.Text = "Length Asc.";
                    ascending_length = true;
                }
            }
        }

        private void listBox_playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox_playlist.SelectedIndex;
            if (listBox_playlist.SelectedIndex >= 0)
            {
                string title = listBox_playlist.SelectedItem.ToString().Split((char)9)[1];
                foreach (song song1 in playlist)
                {
                    if (song1.Title.Equals(title))
                    {
                        path_selected_song = song1.Path;
                        break;
                    }
                }
            }
            listBox_library.SelectedIndex = -1;
            listBox_playlist.SelectedIndex = index;
        }

        private void listBox_library_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox_library.SelectedIndex;
            if (listBox_library.SelectedIndex >= 0)
            {
                path_selected_song = library[listBox_library.SelectedItem.ToString()].Path;
            }
            listBox_playlist.SelectedIndex = -1;
            listBox_library.SelectedIndex = index;
        }
    }
}
