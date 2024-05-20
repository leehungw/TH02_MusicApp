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

namespace TH02_MusicApp.UserControls.SongDetail
{
    public partial class CommentItem : UserControl
    {
        public CommentItem()
        {
            InitializeComponent();
        }

        public void loadComment(Comment comment)
        {
            lb_author.Text = comment.author;
            lb_comment.Text = comment.content;
        }
    }
}
