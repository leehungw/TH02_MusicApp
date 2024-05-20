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
using TH02_MusicApp.UserControls.MusicPage;

namespace TH02_MusicApp.UserControls.LovePage
{
    public partial class LoveUC : UserControl
    {
        public LoveUC()
        {
            InitializeComponent();
            fpn_loveSongs.AutoScroll = false;
            fpn_loveSongs.HorizontalScroll.Maximum = 0;
            fpn_loveSongs.VerticalScroll.Visible = false;
            fpn_loveSongs.AutoScroll = true;
            LoadLovedSongs();
        }

        private void LoadLovedSongs()
        {
            fpn_loveSongs.Controls.Clear();

            // get loved songs from all songs
            List<Song> lovedSongs = DataStore.Songs.FindAll(song => song.IsFavorite);
            foreach (Song song in lovedSongs)
            {
                MusicInfoItem musicInfoItem = new MusicInfoItem();
                musicInfoItem.SetMusicInfo(song, false, false, true, true, false);
                musicInfoItem.MusicItemClick += MusicItemClick;
                if (song.FileUrl == MusicPlayerManager.Instance._currentSongPath)
                {
                    MusicPlayerManager.Instance._lastPlayedMusic = musicInfoItem;
                    musicInfoItem.btn_play.BackgroundImage = Properties.Resources.is_playing_icon;
                }
                fpn_loveSongs.Controls.Add(musicInfoItem);
            }
        }
        public event EventHandler MusicItem_Click;
        public void MusicItemClick(object sender, EventArgs e)
        {
            MusicItem_Click(sender, e);
        }
    }
}
