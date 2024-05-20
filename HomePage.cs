using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH02_MusicApp.Model;
using TH02_MusicApp.Shared_Preferences;
using TH02_MusicApp.UserControls.HomePage;
using TH02_MusicApp.UserControls.LovePage;
using TH02_MusicApp.UserControls.MusicPage;
using TH02_MusicApp.UserControls.PlaylistPage;
using TH02_MusicApp.UserControls.SongDetail;

namespace TH02_MusicApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            LoadHomeTab();
        }

        private void PlaylistTab_Click(object sender, EventArgs e)
        {
            PlaylistUC playlistUC = new PlaylistUC();
            playlistUC.Dock = DockStyle.Fill;
            pn_UC.Controls.Clear();
            pn_UC.Controls.Add(playlistUC);
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeTab_Click(object sender, EventArgs e)
        {
            LoadHomeTab();
        }

        private void LoadHomeTab()
        {
            pn_UC.Controls.Clear();
            HomePageUC home = new HomePageUC();
            home.Dock = DockStyle.Fill;
            pn_UC.Controls.Add(home);
        }

        private void MusicTab_Click(object sender, EventArgs e)
        {
            pn_UC.Controls.Clear();
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;
            pn_UC.Controls.Add(flowLayoutPanel);

            List<Song> songs = DataStore.Songs;
            foreach (Song song in songs) { 
                MusicInfoItem musicInfoItem = new MusicInfoItem();
                musicInfoItem.SetMusicInfo(song, true, true, true, true, false);
                musicInfoItem.PlayButtonClick += MusicBlock_PlayButtonClick;
                musicInfoItem.MusicItemClick += MusicItem_Click;
                flowLayoutPanel.Controls.Add(musicInfoItem);

                if (song.FileUrl == MusicPlayerManager.Instance._currentSongPath)
                    MusicPlayerManager.Instance._lastPlayedMusic = musicInfoItem;
            }
        }
        private void MusicItem_Click(object sender, EventArgs e)
        {
            Song song = sender as Song;
            SongDetailUC songDetail = new SongDetailUC(song);
            songDetail.BackButton_Click += SongDetail_BackButton_Click;
            pn_UC.Controls[0].Visible = false;
            pn_UC.Controls.Add((SongDetailUC)songDetail);
        }

        private void SongDetail_BackButton_Click(object sender, EventArgs e)
        {
            pn_UC.Controls[0].Visible = true;
        }

        public void MusicBlock_PlayButtonClick(object sender, EventArgs e)
        {
            MusicInfoItem musicInfoItem = (MusicInfoItem)sender;
            MusicPlayerManager.Instance.UpdateLastPlayedMusic(musicInfoItem);
        }

        private void btnPlaycrossfade_Click(object sender, EventArgs e)
        {

        }

        private void LoveTab_Click(object sender, EventArgs e)
        {
            LoveUC loveUC = new LoveUC();
            loveUC.Dock = DockStyle.Fill;
            pn_UC.Controls.Clear();
            pn_UC.Controls.Add(loveUC);
        }
        private void pb_close_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
