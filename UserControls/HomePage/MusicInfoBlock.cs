using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TH02_MusicApp.Model;

namespace TH02_MusicApp.UserControls.HomePage
{
    public partial class MusicInfoBlock : UserControl
    {
        Song song;
        public MusicInfoBlock(Song song)
        {
            InitializeComponent();
            this.song = song;
            pb_image.Image = Image.FromFile(song.ImageUrl);
            lb_name.Text = song.Name;
        }
        public event EventHandler MusicItemClick;
        private void MusicInfoItem_Click(object sender, EventArgs e)
        {
            MusicItemClick(song, e);
        }
    }
}
