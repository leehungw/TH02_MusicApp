namespace TH02_MusicApp.UserControls.SongDetail
{
    partial class SongDetailUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongDetailUC));
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_auther_singer = new System.Windows.Forms.Label();
            this.fpn_comment = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_commentPost = new System.Windows.Forms.Panel();
            this.btn_comment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.pb_songImg = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbBack = new System.Windows.Forms.PictureBox();
            this.pn_commentPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_songImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(157, 55);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(111, 27);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Only You";
            // 
            // lb_auther_singer
            // 
            this.lb_auther_singer.AutoSize = true;
            this.lb_auther_singer.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_auther_singer.Location = new System.Drawing.Point(158, 98);
            this.lb_auther_singer.Name = "lb_auther_singer";
            this.lb_auther_singer.Size = new System.Drawing.Size(54, 22);
            this.lb_auther_singer.TabIndex = 2;
            this.lb_auther_singer.Text = "singer";
            // 
            // fpn_comment
            // 
            this.fpn_comment.AutoScroll = true;
            this.fpn_comment.AutoSize = true;
            this.fpn_comment.Location = new System.Drawing.Point(0, 233);
            this.fpn_comment.MaximumSize = new System.Drawing.Size(450, 170);
            this.fpn_comment.Name = "fpn_comment";
            this.fpn_comment.Size = new System.Drawing.Size(450, 170);
            this.fpn_comment.TabIndex = 3;
            // 
            // pn_commentPost
            // 
            this.pn_commentPost.Controls.Add(this.btn_comment);
            this.pn_commentPost.Controls.Add(this.label2);
            this.pn_commentPost.Controls.Add(this.label1);
            this.pn_commentPost.Controls.Add(this.tb_comment);
            this.pn_commentPost.Controls.Add(this.tb_author);
            this.pn_commentPost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_commentPost.Location = new System.Drawing.Point(0, 401);
            this.pn_commentPost.Name = "pn_commentPost";
            this.pn_commentPost.Size = new System.Drawing.Size(450, 135);
            this.pn_commentPost.TabIndex = 4;
            // 
            // btn_comment
            // 
            this.btn_comment.Location = new System.Drawing.Point(344, 39);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(93, 23);
            this.btn_comment.TabIndex = 2;
            this.btn_comment.Text = "Comment";
            this.btn_comment.UseVisualStyleBackColor = true;
            this.btn_comment.Click += new System.EventHandler(this.btn_comment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Post Your Comment";
            // 
            // tb_comment
            // 
            this.tb_comment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_comment.Location = new System.Drawing.Point(17, 72);
            this.tb_comment.Multiline = true;
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.Size = new System.Drawing.Size(420, 48);
            this.tb_comment.TabIndex = 0;
            // 
            // tb_author
            // 
            this.tb_author.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_author.Location = new System.Drawing.Point(80, 39);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(188, 26);
            this.tb_author.TabIndex = 0;
            // 
            // pb_songImg
            // 
            this.pb_songImg.Location = new System.Drawing.Point(17, 55);
            this.pb_songImg.Name = "pb_songImg";
            this.pb_songImg.Size = new System.Drawing.Size(134, 131);
            this.pb_songImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_songImg.TabIndex = 0;
            this.pb_songImg.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Comments";
            // 
            // ptbBack
            // 
            this.ptbBack.Image = ((System.Drawing.Image)(resources.GetObject("ptbBack.Image")));
            this.ptbBack.Location = new System.Drawing.Point(16, 8);
            this.ptbBack.Name = "ptbBack";
            this.ptbBack.Size = new System.Drawing.Size(41, 41);
            this.ptbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBack.TabIndex = 5;
            this.ptbBack.TabStop = false;
            this.ptbBack.Click += new System.EventHandler(this.ptbBack_Click);
            // 
            // SongDetailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbBack);
            this.Controls.Add(this.lb_auther_singer);
            this.Controls.Add(this.fpn_comment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pn_commentPost);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.pb_songImg);
            this.Name = "SongDetailUC";
            this.Size = new System.Drawing.Size(450, 536);
            this.Load += new System.EventHandler(this.SongDetailUC_Load);
            this.pn_commentPost.ResumeLayout(false);
            this.pn_commentPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_songImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_songImg;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_auther_singer;
        private System.Windows.Forms.FlowLayoutPanel fpn_comment;
        private System.Windows.Forms.Panel pn_commentPost;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_comment;
        private System.Windows.Forms.Button btn_comment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbBack;
    }
}
