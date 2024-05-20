using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH02_MusicApp.Shared_Preferences;

namespace TH02_MusicApp.UserControls.PlaylistPage
{
    public partial class PlaylistItem : UserControl
    {
        public Guid id;
        public string name;
        public PlaylistItem()
        {
            InitializeComponent();
        }

        // load data for playlist folder bar
        public void LoadData(string name, Guid id)
        {
            lb_name.Text = name;
            this.name = name;
            this.id = id;
        }

        private void ptbDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this playlist?", "Delete Playlist", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            OnDeleteButtonClick(EventArgs.Empty);
        }

        // Define an event to notify the parent form
        public event EventHandler DeleteButtonClick;

        protected virtual void OnDeleteButtonClick(EventArgs e)
        {
            DeleteButtonClick?.Invoke(this, e);
        }

        public event EventHandler PlaylistDoubleClicked;

        private void PlaylistFolderBar_DoubleClick(object sender, EventArgs e)
        {
            PlaylistDoubleClicked?.Invoke(this, e);

        }
        private void ptbDeleteInside_Click(object sender, EventArgs e)
        {
            // delete all songs in playlist but keep playlist
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all songs in this playlist?", "Delete Playlist", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            DataStore.DeleteAllSongsFromPlaylist(id);
            MessageBox.Show("All songs in playlist have been deleted successfully!");

        }
    }
}
