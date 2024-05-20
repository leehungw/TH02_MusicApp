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
using TH02_MusicApp.UserControls.PlaylistPage;

namespace TH02_MusicApp.UserControls.SongDetail
{
    public partial class SongDetailUC : UserControl
    {
        private Song song;
        public SongDetailUC(Song song)
        {
            InitializeComponent();
            this.song = song;
        }

        private void SongDetailUC_Load(object sender, EventArgs e)
        {
            pb_songImg.Image = Image.FromFile(song.ImageUrl);
            lb_Name.Text = song.Name;
            lb_auther_singer.Text = song.Author;
            loadComments();
        }

        private void loadComments()
        {
            fpn_comment.Controls.Clear();

            List<Comment> comments = DataStore.GetCommentListBySongId(this.song.Id);
            foreach (Comment comment in comments)
            {
                CommentItem commentItem = new CommentItem();
                commentItem.loadComment(comment);
                commentItem.AutoSize = true;
                fpn_comment.Controls.Add(commentItem);
            }
        }

        private void btn_comment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_author.Text))
            {
                MessageBox.Show("Please enter your name");
                return;
            }
            if (tb_author.Text.Length > 20)
            {
                MessageBox.Show("Cannot enter name longer than 20 characters");
                return;
            }
            if (string.IsNullOrEmpty(tb_comment.Text))
            {
                MessageBox.Show("Please enter your comment");
                return;
            }

            Comment comment = new Comment(song.Id, tb_comment.Text, tb_author.Text);
            DataStore.AddComment(comment);
            loadComments();
            tb_author.Clear();
            tb_comment.Clear();
        }

        public event EventHandler BackButton_Click;
        private void ptbBack_Click(object sender, EventArgs e)
        {
            BackButton_Click(sender, e);
            this.Dispose();
        }
    }
}
