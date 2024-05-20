﻿using System;
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
using TH02_MusicApp.UserControls.MusicPage;

namespace TH02_MusicApp.UserControls.PlaylistPage
{
    public partial class PlaylistUC : UserControl
    {
        public PlaylistUC()
        {
            InitializeComponent();
            panelPlaylistName.Visible = false;
        }

        private void ptbAdd_Click(object sender, EventArgs e)
        {
            AddPlaylistForm addPlaylistForm = new AddPlaylistForm();
            addPlaylistForm.ShowDialog();

            // reload playlist
            LoadPlaylist();
        }

        private void LoadPlaylist()
        {
            // clear all playlist
            flowLayoutPanel1.Controls.Clear();

            // get all playlist
            List<Playlist> playlists = DataStore.Playlists;
            foreach (Playlist playlist in playlists)
            {
                // append playlist to flow layout panel
                PlaylistItem playlistItem = new PlaylistItem();
                playlistItem.LoadData(playlist.Name, playlist.Id);
                playlistItem.DeleteButtonClick += PlaylistControl_DeleteButtonClick;
                playlistItem.PlaylistDoubleClicked += PlaylistControl_PlaylistDoubleClicked;
                flowLayoutPanel1.Controls.Add(playlistItem);
            }
        }

        private void PlaylistControl_PlaylistDoubleClicked(object sender, EventArgs e)
        {
            if (sender is PlaylistItem playlistControl)
            {
                panelPlaylistName.Visible = true;
                labelPlaylistName.Text = playlistControl.name;
                panelAddPlaylist.Visible = false;
                DisplaySongsInPlaylist(playlistControl.id);
            }
        }

        private void DisplaySongsInPlaylist(Guid playlistId)
        {
            flowLayoutPanel1.Controls.Clear();
            Playlist playlist = DataStore.GetPlaylistById(playlistId);
            foreach (string songId in playlist.SongIds)
            {
                Song song = DataStore.GetSongById(songId);
                MusicInfoItem songControl = new MusicInfoItem();
                songControl.SetMusicInfo(song, false, true, true, true, true);
                songControl.PlayButtonClick += MusicBlock_PlayButtonClick;
                flowLayoutPanel1.Controls.Add(songControl);

                if (song.FileUrl == MusicPlayerManager.Instance._currentSongPath)
                    MusicPlayerManager.Instance._lastPlayedMusic = songControl;
            }
        }

        public void MusicBlock_PlayButtonClick(object sender, EventArgs e)
        {
            MusicInfoItem musicInfoBar = (MusicInfoItem)sender;
            MusicPlayerManager.Instance.UpdateLastPlayedMusic(musicInfoBar);
        }

        private void PlaylistControl_DeleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                // Remove the PlaylistControl from the FlowLayoutPanel
                if (sender is PlaylistItem playlistControl)
                {
                    DataStore.DeletePlaylist(playlistControl.id);
                    flowLayoutPanel1.Controls.Remove(playlistControl);
                    playlistControl.Dispose(); // Dispose the control to free resources
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PlaylistUC_Load(object sender, EventArgs e)
        {
            LoadPlaylist();
        }

        private void ptbBack_Click(object sender, EventArgs e)
        {
            // hide panel playlist name
            panelPlaylistName.Visible = false;
            panelAddPlaylist.Visible = true;
            LoadPlaylist();
        }

        private void panelAddPlaylist_Click(object sender, EventArgs e)
        {
            // call event btnAdd_Click when click on panelAddPlaylist
            ptbAdd_Click(sender, e);

        }
    }
}
