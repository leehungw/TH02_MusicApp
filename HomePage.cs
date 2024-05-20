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
            playlistUC.MusicItem_Click += MusicItem_Click;
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
            home.MusicItem_Click += MusicItem_Click;
            home.Dock = DockStyle.Fill;
            pn_UC.Controls.Add(home);
        }

        private void MusicTab_Click(object sender, EventArgs e)
        {
            pn_UC.Controls.Clear();
            MusicUC musicUC = new MusicUC();
            musicUC.Dock = DockStyle.Fill;
            musicUC.MusicItem_Click += MusicItem_Click;
            pn_UC.Controls.Add(musicUC);
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

        private void btnPlaycrossfade_Click(object sender, EventArgs e)
        {

        }

        private void LoveTab_Click(object sender, EventArgs e)
        {
            LoveUC loveUC = new LoveUC();
            loveUC.Dock = DockStyle.Fill;
            loveUC.MusicItem_Click += MusicItem_Click;
            pn_UC.Controls.Clear();
            pn_UC.Controls.Add(loveUC);
        }
        private void pb_close_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
