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
    }
}
