using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                _song.IsPlayed = true;
                DataStore.AddOrUpdateSong(_song);
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



        public event EventHandler MusicItemClick;
        private void MusicInfoItem_Click(object sender, EventArgs e)
        {
            MusicItemClick(_song, e);
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationPath = Path.Combine(folderBrowserDialog.SelectedPath, Path.GetFileName(_song.FileUrl));

                    try
                    {
                        if (File.Exists(destinationPath))
                        {
                            DialogResult result = MessageBox.Show("The file already exists. Do you want to overwrite it?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.No)
                            {
                                return;
                            }
                        }

                        File.Copy(_song.FileUrl, destinationPath, true);
                        _song.IsDownloaded = true;
                        DataStore.AddOrUpdateSong(_song);
                        MessageBox.Show("Download completed successfully!", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while downloading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public event EventHandler DeleteBtn_Click;
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteBtn_Click(this, e);
        }
    }
}
