namespace TH02_MusicApp.UserControls.SongDetail
{
    partial class CommentItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentItem));
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.lb_comment = new System.Windows.Forms.Label();
            this.lb_author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_avatar
            // 
            this.pb_avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_avatar.BackgroundImage")));
            this.pb_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_avatar.Location = new System.Drawing.Point(3, 3);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(72, 64);
            this.pb_avatar.TabIndex = 0;
            this.pb_avatar.TabStop = false;
            // 
            // lb_comment
            // 
            this.lb_comment.AutoSize = true;
            this.lb_comment.Location = new System.Drawing.Point(93, 34);
            this.lb_comment.MaximumSize = new System.Drawing.Size(300, 0);
            this.lb_comment.Name = "lb_comment";
            this.lb_comment.Size = new System.Drawing.Size(297, 64);
            this.lb_comment.TabIndex = 1;
            this.lb_comment.Text = "this is a longgggggggggggggggggggggggggggggggggggggggggggggggggggggggggg commentt" +
    "tttttttttttttttttttttttt";
            // 
            // lb_author
            // 
            this.lb_author.AutoSize = true;
            this.lb_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_author.Location = new System.Drawing.Point(93, 3);
            this.lb_author.MaximumSize = new System.Drawing.Size(300, 0);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(56, 18);
            this.lb_author.TabIndex = 1;
            this.lb_author.Text = "author";
            // 
            // CommentItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.lb_comment);
            this.Controls.Add(this.pb_avatar);
            this.MinimumSize = new System.Drawing.Size(405, 0);
            this.Name = "CommentItem";
            this.Size = new System.Drawing.Size(405, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.Label lb_comment;
        private System.Windows.Forms.Label lb_author;
    }
}
