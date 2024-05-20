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
using TH02_MusicApp.Shared_Preferences;

namespace TH02_MusicApp.UserControls.MusicPage
{
    public partial class AddToPlaylistForm : Form
    {
        string songId;
        public AddToPlaylistForm(string songId)
        {
            InitializeComponent();
            this.songId = songId;
        }

        private void AddMusicToPlaylistForm_Load(object sender, EventArgs e)
        {
            // load all playlist to combobox
            List<Playlist> playlists = DataStore.Playlists;
            foreach (Playlist playlist in playlists)
            {
                comboBox1.Items.Add(playlist.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add song to playlist
            Guid playlistId = DataStore.Playlists[comboBox1.SelectedIndex].Id;
            DataStore.AddSongToPlaylist(playlistId, songId);
            MessageBox.Show("Add song to playlist successfully");
            this.Close();
        }
    }
}
