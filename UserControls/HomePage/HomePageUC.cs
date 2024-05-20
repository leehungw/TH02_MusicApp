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

namespace TH02_MusicApp.UserControls.HomePage
{
    public partial class HomePageUC : UserControl
    {
        public HomePageUC()
        {
            InitializeComponent();
        }
        private void UCHome_Load(object sender, EventArgs e)
        {
            // call event click of recently label
            llRecently_LinkClicked(sender, null);

        }

        private void llRecently_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // clear all controls in flow layout panel 
            // and load isplay = true songs
            fpn_recent_download.Controls.Clear();
            List<Song> songs = DataStore.Songs;
            foreach (Song song in songs)
            {
                if (song.IsPlayed)
                {
                    MusicInfoBlock musicInfoBlock = new MusicInfoBlock(song);
                    musicInfoBlock.MusicItemClick += MusicItemClick;
                    fpn_recent_download.Controls.Add(musicInfoBlock);
                }
            }

            // set bg gradient active caption color for selected label
            llb_recently.BackColor = Color.Aqua;

            // set bg of download label to bg color of this form
            llb_download.BackColor = pn_button.BackColor;
        }

        private void llDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // clear all controls in flow layout panel 
            // and load isDownload = true songs
            fpn_recent_download.Controls.Clear();
            List<Song> songs = DataStore.Songs;
            foreach (Song song in songs)
            {
                if (song.IsDownloaded)
                {
                    MusicInfoBlock musicInfoBlock = new MusicInfoBlock(song);
                    musicInfoBlock.MusicItemClick += MusicItemClick;
                    fpn_recent_download.Controls.Add(musicInfoBlock);
                }
            }

            // set bg gradient active caption color for selected label
            llb_download.BackColor = Color.Aqua;

            // set bg of recently label to bg color of this form
            llb_recently.BackColor = pn_button.BackColor;
        }
        public event EventHandler MusicItem_Click;
        public void MusicItemClick(object sender, EventArgs e)
        {
            MusicItem_Click(sender, e);
        }
    }
}
