﻿namespace Music_loud
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_play = new System.Windows.Forms.Button();
            this.button_browser = new System.Windows.Forms.Button();
            this.text_path = new System.Windows.Forms.TextBox();
            this.text_title = new System.Windows.Forms.TextBox();
            this.text_artist = new System.Windows.Forms.TextBox();
            this.text_album = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_length = new System.Windows.Forms.TextBox();
            this.button_add_database = new System.Windows.Forms.Button();
            this.listBox_database = new System.Windows.Forms.ListBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.text_search = new System.Windows.Forms.TextBox();
            this.listBox_playlist = new System.Windows.Forms.ListBox();
            this.button_playlist = new System.Windows.Forms.Button();
            this.button_add_playlist = new System.Windows.Forms.Button();
            this.button_name = new System.Windows.Forms.Button();
            this.button_length = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(414, 405);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 23);
            this.button_play.TabIndex = 0;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_browser
            // 
            this.button_browser.Location = new System.Drawing.Point(151, 193);
            this.button_browser.Name = "button_browser";
            this.button_browser.Size = new System.Drawing.Size(75, 23);
            this.button_browser.TabIndex = 1;
            this.button_browser.Text = "Browse";
            this.button_browser.UseVisualStyleBackColor = true;
            this.button_browser.Click += new System.EventHandler(this.button_browser_Click);
            // 
            // text_path
            // 
            this.text_path.Location = new System.Drawing.Point(34, 196);
            this.text_path.Name = "text_path";
            this.text_path.Size = new System.Drawing.Size(100, 20);
            this.text_path.TabIndex = 2;
            // 
            // text_title
            // 
            this.text_title.Location = new System.Drawing.Point(126, 32);
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(100, 20);
            this.text_title.TabIndex = 3;
            // 
            // text_artist
            // 
            this.text_artist.Location = new System.Drawing.Point(126, 67);
            this.text_artist.Name = "text_artist";
            this.text_artist.Size = new System.Drawing.Size(100, 20);
            this.text_artist.TabIndex = 4;
            // 
            // text_album
            // 
            this.text_album.Location = new System.Drawing.Point(126, 103);
            this.text_album.Name = "text_album";
            this.text_album.Size = new System.Drawing.Size(100, 20);
            this.text_album.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Length";
            // 
            // text_length
            // 
            this.text_length.Location = new System.Drawing.Point(126, 146);
            this.text_length.Name = "text_length";
            this.text_length.ReadOnly = true;
            this.text_length.Size = new System.Drawing.Size(100, 20);
            this.text_length.TabIndex = 10;
            // 
            // button_add_database
            // 
            this.button_add_database.Location = new System.Drawing.Point(287, 28);
            this.button_add_database.Name = "button_add_database";
            this.button_add_database.Size = new System.Drawing.Size(75, 23);
            this.button_add_database.TabIndex = 11;
            this.button_add_database.Text = "Add";
            this.button_add_database.UseVisualStyleBackColor = true;
            this.button_add_database.Click += new System.EventHandler(this.button_add_database_Click);
            // 
            // listBox_database
            // 
            this.listBox_database.FormattingEnabled = true;
            this.listBox_database.Location = new System.Drawing.Point(287, 64);
            this.listBox_database.Name = "listBox_database";
            this.listBox_database.ScrollAlwaysVisible = true;
            this.listBox_database.Size = new System.Drawing.Size(120, 95);
            this.listBox_database.TabIndex = 12;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(414, 361);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 13;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(433, 193);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 14;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(287, 193);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(100, 20);
            this.text_search.TabIndex = 15;
            // 
            // listBox_playlist
            // 
            this.listBox_playlist.FormattingEnabled = true;
            this.listBox_playlist.Location = new System.Drawing.Point(31, 333);
            this.listBox_playlist.Name = "listBox_playlist";
            this.listBox_playlist.ScrollAlwaysVisible = true;
            this.listBox_playlist.Size = new System.Drawing.Size(120, 95);
            this.listBox_playlist.TabIndex = 16;
            // 
            // button_playlist
            // 
            this.button_playlist.Location = new System.Drawing.Point(31, 269);
            this.button_playlist.Name = "button_playlist";
            this.button_playlist.Size = new System.Drawing.Size(75, 23);
            this.button_playlist.TabIndex = 17;
            this.button_playlist.Text = "New playlist";
            this.button_playlist.UseVisualStyleBackColor = true;
            // 
            // button_add_playlist
            // 
            this.button_add_playlist.Location = new System.Drawing.Point(389, 29);
            this.button_add_playlist.Name = "button_add_playlist";
            this.button_add_playlist.Size = new System.Drawing.Size(100, 23);
            this.button_add_playlist.TabIndex = 18;
            this.button_add_playlist.Text = "Add to playlist";
            this.button_add_playlist.UseVisualStyleBackColor = true;
            // 
            // button_name
            // 
            this.button_name.Location = new System.Drawing.Point(176, 333);
            this.button_name.Name = "button_name";
            this.button_name.Size = new System.Drawing.Size(75, 23);
            this.button_name.TabIndex = 19;
            this.button_name.Text = "Name (A-Z)";
            this.button_name.UseVisualStyleBackColor = true;
            // 
            // button_length
            // 
            this.button_length.Location = new System.Drawing.Point(176, 377);
            this.button_length.Name = "button_length";
            this.button_length.Size = new System.Drawing.Size(75, 23);
            this.button_length.TabIndex = 20;
            this.button_length.Text = "Length";
            this.button_length.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Order By";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 464);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_length);
            this.Controls.Add(this.button_name);
            this.Controls.Add(this.button_add_playlist);
            this.Controls.Add(this.button_playlist);
            this.Controls.Add(this.listBox_playlist);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.listBox_database);
            this.Controls.Add(this.button_add_database);
            this.Controls.Add(this.text_length);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_album);
            this.Controls.Add(this.text_artist);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.text_path);
            this.Controls.Add(this.button_browser);
            this.Controls.Add(this.button_play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_browser;
        private System.Windows.Forms.TextBox text_path;
        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.TextBox text_artist;
        private System.Windows.Forms.TextBox text_album;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_length;
        private System.Windows.Forms.Button button_add_database;
        private System.Windows.Forms.ListBox listBox_database;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.ListBox listBox_playlist;
        private System.Windows.Forms.Button button_playlist;
        private System.Windows.Forms.Button button_add_playlist;
        private System.Windows.Forms.Button button_name;
        private System.Windows.Forms.Button button_length;
        private System.Windows.Forms.Label label5;
    }
}

