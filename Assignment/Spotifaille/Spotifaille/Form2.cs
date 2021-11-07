using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace Spotifaille
{
    public partial class MainForm : Form
    {
        private List<Song> songList;
        private FileReader fr;
        private User _user;
        WMPLib.WindowsMediaPlayer wplayer;
        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
            fr = new FileReader();
            songList = new List<Song>();
            songList = fr.ReadPlaylist();
            wplayer = new WMPLib.WindowsMediaPlayer();
            LoadPlaylist();

            wplayer.settings.autoStart = true;
            wplayer.settings.volume = 20;
            volumeTrackBar.Value = 20;
        }

        private void LoadPlaylist()
        {
            listView1.Items.Clear();
            ListViewItem item;
            foreach (Song song in songList)
            {
                item = new ListViewItem(song.Artiste, 0);
                item.SubItems.Add(song.Titre);
                item.SubItems.Add(song.Duree);
                listView1.Items.Add(item);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //CreateMyListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connexionForm.f1.Show();
            connexionForm.f2.Hide();

            wplayer.close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                //Console.WriteLine("Now Playing : " + songList[listView1.SelectedIndices[0]].Titre + " " + songList[listView1.SelectedIndices[0]].Artiste + " " + songList[listView1.SelectedIndices[0]].Duree + " " + songList[listView1.SelectedIndices[0]].SongPath + " " + songList[listView1.SelectedIndices[0]].ImgPath);
                //Console.WriteLine("Now playing : " + songList[listView1.SelectedIndices[0]].Titre);
                richTextBox1.Text = String.Format("{0} :{1} : {2}",listView1.SelectedItems[0].Text, songList[listView1.SelectedIndices[0]].Titre, songList[listView1.SelectedIndices[0]].Duree);
                authorLabel.Text = songList[listView1.SelectedIndices[0]].Artiste;
                titleLabel.Text = songList[listView1.SelectedIndices[0]].Titre;
                wplayer.URL = songList[listView1.SelectedIndices[0]].SongPath;
                fr.WriteLog(_user.MailAddress, listView1.SelectedItems[0].Text, songList[listView1.SelectedIndices[0]].Titre);
                totalTimeLabel.Text = songList[listView1.SelectedIndices[0]].Duree;
                currentTimeLabel.Text = "00:00";
                progressBar1.Value = 0;
                var x = songList[listView1.SelectedIndices[0]].Duree;
                var y = x.Split(':');
                progressBar1.Maximum = Convert.ToInt32(y[0]) * 60 + Convert.ToInt32(y[1]);
                //Console.WriteLine(songList[listView1.SelectedIndices[0]].SongPath);
                if(songList[listView1.SelectedIndices[0]].ImgPath == null)
                {
                    coverPictureBox.ImageLocation = "Img/Default.jpg";
                }
                else
                {
                    coverPictureBox.ImageLocation = songList[listView1.SelectedIndices[0]].ImgPath;
                }
                pauseButton.Enabled = true;
                pauseButton.Visible = true;
                playButton.Enabled = false;
                playButton.Visible = false;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            songList = fr.ReadPlaylist(openFileDialog1.FileName);
            LoadPlaylist();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wplayer.controls.play();
            pauseButton.Enabled = true;
            pauseButton.Visible = true;
            playButton.Enabled = false;
            playButton.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wplayer.controls.pause();
            playButton.Enabled = true;
            playButton.Visible = true;
            pauseButton.Enabled = false;
            pauseButton.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(wplayer.playState == WMPLib.WMPPlayState.wmppsPlaying && progressBar1.Value <= progressBar1.Maximum)
            {
                progressBar1.Value = Convert.ToInt32(wplayer.controls.currentPosition);
                currentTimeLabel.Text = wplayer.controls.currentPositionString;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items[listView1.SelectedIndices[0]+1].Selected = true;
            listView1.Items[listView1.SelectedIndices[0]].Selected = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            wplayer.settings.volume = volumeTrackBar.Value;
        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            wplayer.close();
            wplayer.URL = "";
            totalTimeLabel.Text = "00:00";
            currentTimeLabel.Text = "00:00";
            progressBar1.Value = 0;
            playButton.Enabled = true;
            playButton.Visible = true;
            pauseButton.Enabled = false;
            pauseButton.Visible = false;
            openFileDialog1.ShowDialog();
        }
    }
}
