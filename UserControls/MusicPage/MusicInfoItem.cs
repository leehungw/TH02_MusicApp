using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH02_MusicApp.Config;
using TH02_MusicApp.Model;
using TH02_MusicApp.Shared_Preferences;

namespace TH02_MusicApp.UserControls.MusicPage
{
    public partial class MusicInfoItem : UserControl
    {
        public Song _song;

        public MusicInfoItem()
        {
            InitializeComponent();
        }

        public void SetMusicInfo(
            Song song,
            bool isAddToPlaylistVisible,
            bool isFavoriteVisible,
            bool isPlayVisible,
            bool isDownloadVisible,
            bool isDeleteVisible)
        {
            this._song = song;
            pb_img.Image = Image.FromFile(song.ImageUrl);
            lb_Name.Text = song.Name;
            lb_auther_singer.Text = song.Author;
            btn_addToPlaylist.Visible = isAddToPlaylistVisible;
            btn_love.Visible = isFavoriteVisible;
            btn_play.Visible = isPlayVisible;
            btn_download.Visible = isDownloadVisible;
            btn_delete.Visible = isDeleteVisible;

            if (song.IsFavorite)
                btn_love.BackgroundImage = Properties.Resources.heart_fill;
            else
                btn_love.BackgroundImage = Properties.Resources.heart_outline;

            if (song.IsPlaying)
                btn_play.BackgroundImage = Properties.Resources.is_playing_icon;
            else
                btn_play.BackgroundImage = Properties.Resources.play_icon;
        }

        private void ptbAddToPlaylist_Click(object sender, EventArgs e)
        {
            AddToPlaylistForm addMusicToPlaylistForm = new AddToPlaylistForm(_song.Id);
            addMusicToPlaylistForm.ShowDialog();
        }


        public event EventHandler PlayButtonClick;
        private void ptbPlay_Click(object sender, EventArgs e)
        {
            if (_song != null)
            {
                MusicPlayerManager.Instance.PlayOrPause(_song.FileUrl);
                UpdatePlayButtonImage();
            }

            PlayButtonClick?.Invoke(this, e);
        }

        public void UpdatePlayButtonImage()
        {
            var player = MusicPlayerManager.Instance;
            if (player.IsPlaying(_song.FileUrl))
            {
                btn_play.BackgroundImage = Properties.Resources.is_playing_icon;
            }
            else
            {
                btn_play.BackgroundImage = Properties.Resources.play_icon;
            }
        }

        private void ptbFavorite_Click(object sender, EventArgs e)
        {
            if (_song == null)
                return;

            _song.IsFavorite = !_song.IsFavorite;
            if (_song.IsFavorite)
                btn_love.BackgroundImage = Properties.Resources.heart_fill;
            else
                btn_love.BackgroundImage = Properties.Resources.heart_outline;

            DataStore.AddOrUpdateSong(_song);
        }
        


        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler MusicItemClick;
        private void MusicInfoItem_Click(object sender, EventArgs e)
        {
            MusicItemClick(_song, e);
        }
    }
}
