namespace TH02_MusicApp.UserControls.MusicPage
{
    partial class MusicInfoItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicInfoItem));
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.lb_auther_singer = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.btn_addToPlaylist = new System.Windows.Forms.Button();
            this.btn_love = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_img
            // 
            this.pb_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_img.Location = new System.Drawing.Point(3, 3);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(100, 103);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_img.TabIndex = 0;
            this.pb_img.TabStop = false;
            this.pb_img.Click += new System.EventHandler(this.MusicInfoItem_Click);
            // 
            // lb_auther_singer
            // 
            this.lb_auther_singer.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_auther_singer.Location = new System.Drawing.Point(110, 49);
            this.lb_auther_singer.Name = "lb_auther_singer";
            this.lb_auther_singer.Size = new System.Drawing.Size(139, 55);
            this.lb_auther_singer.TabIndex = 4;
            this.lb_auther_singer.Text = "singerrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr";
            this.lb_auther_singer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_auther_singer.Click += new System.EventHandler(this.MusicInfoItem_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(114, 9);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(257, 48);
            this.lb_Name.TabIndex = 3;
            this.lb_Name.Text = "Only Youyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy";
            this.lb_Name.Click += new System.EventHandler(this.MusicInfoItem_Click);
            // 
            // btn_addToPlaylist
            // 
            this.btn_addToPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btn_addToPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addToPlaylist.BackgroundImage")));
            this.btn_addToPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addToPlaylist.Location = new System.Drawing.Point(377, 64);
            this.btn_addToPlaylist.Name = "btn_addToPlaylist";
            this.btn_addToPlaylist.Size = new System.Drawing.Size(35, 35);
            this.btn_addToPlaylist.TabIndex = 5;
            this.btn_addToPlaylist.UseVisualStyleBackColor = false;
            this.btn_addToPlaylist.Click += new System.EventHandler(this.ptbAddToPlaylist_Click);
            // 
            // btn_love
            // 
            this.btn_love.BackColor = System.Drawing.Color.Transparent;
            this.btn_love.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_love.BackgroundImage")));
            this.btn_love.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_love.Location = new System.Drawing.Point(336, 64);
            this.btn_love.Name = "btn_love";
            this.btn_love.Size = new System.Drawing.Size(35, 35);
            this.btn_love.TabIndex = 5;
            this.btn_love.UseVisualStyleBackColor = false;
            this.btn_love.Click += new System.EventHandler(this.ptbFavorite_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_play.BackgroundImage")));
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_play.Location = new System.Drawing.Point(295, 64);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(35, 35);
            this.btn_play.TabIndex = 5;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.ptbPlay_Click);
            // 
            // btn_download
            // 
            this.btn_download.BackColor = System.Drawing.Color.Transparent;
            this.btn_download.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_download.BackgroundImage")));
            this.btn_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_download.Location = new System.Drawing.Point(254, 64);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(35, 35);
            this.btn_download.TabIndex = 5;
            this.btn_download.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Location = new System.Drawing.Point(377, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(35, 35);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // MusicInfoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_love);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_addToPlaylist);
            this.Controls.Add(this.lb_auther_singer);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.pb_img);
            this.Name = "MusicInfoItem";
            this.Size = new System.Drawing.Size(425, 109);
            this.Click += new System.EventHandler(this.MusicInfoItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.Label lb_auther_singer;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_addToPlaylist;
        private System.Windows.Forms.Button btn_love;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_delete;
    }
}
