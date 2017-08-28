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

namespace Music_loud
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player;
        public Form1()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            player.URL = "test.mp3";
            player.controls.stop();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            player.controls.play();
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
