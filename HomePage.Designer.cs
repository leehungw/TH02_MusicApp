namespace TH02_MusicApp
{
    partial class HomePage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pn_titleBar = new System.Windows.Forms.Panel();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pn_bottomNavigationbar = new System.Windows.Forms.Panel();
            this.pn_favourite = new System.Windows.Forms.Panel();
            this.pb_favourite = new System.Windows.Forms.PictureBox();
            this.lb_favourite = new System.Windows.Forms.Label();
            this.pn_recents = new System.Windows.Forms.Panel();
            this.pb_recents = new System.Windows.Forms.PictureBox();
            this.ln_recents = new System.Windows.Forms.Label();
            this.pn_playlist = new System.Windows.Forms.Panel();
            this.pb_playlist = new System.Windows.Forms.PictureBox();
            this.lb_playlist = new System.Windows.Forms.Label();
            this.pn_tabMusic = new System.Windows.Forms.Panel();
            this.pb_tabMusic = new System.Windows.Forms.PictureBox();
            this.lb_tabMusic = new System.Windows.Forms.Label();
            this.pn_UC = new System.Windows.Forms.Panel();
            this.pn_titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.pn_bottomNavigationbar.SuspendLayout();
            this.pn_favourite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_favourite)).BeginInit();
            this.pn_recents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_recents)).BeginInit();
            this.pn_playlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_playlist)).BeginInit();
            this.pn_tabMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tabMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_titleBar
            // 
            this.pn_titleBar.BackColor = System.Drawing.Color.DimGray;
            this.pn_titleBar.Controls.Add(this.pb_close);
            this.pn_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_titleBar.Location = new System.Drawing.Point(0, 0);
            this.pn_titleBar.Name = "pn_titleBar";
            this.pn_titleBar.Size = new System.Drawing.Size(450, 47);
            this.pn_titleBar.TabIndex = 0;
            // 
            // pb_close
            // 
            this.pb_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_close.BackgroundImage")));
            this.pb_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_close.Location = new System.Drawing.Point(398, 0);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(52, 47);
            this.pb_close.TabIndex = 0;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_click);
            // 
            // pn_bottomNavigationbar
            // 
            this.pn_bottomNavigationbar.BackColor = System.Drawing.Color.SlateBlue;
            this.pn_bottomNavigationbar.Controls.Add(this.pn_favourite);
            this.pn_bottomNavigationbar.Controls.Add(this.pn_recents);
            this.pn_bottomNavigationbar.Controls.Add(this.pn_playlist);
            this.pn_bottomNavigationbar.Controls.Add(this.pn_tabMusic);
            this.pn_bottomNavigationbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_bottomNavigationbar.Location = new System.Drawing.Point(0, 583);
            this.pn_bottomNavigationbar.Name = "pn_bottomNavigationbar";
            this.pn_bottomNavigationbar.Size = new System.Drawing.Size(450, 77);
            this.pn_bottomNavigationbar.TabIndex = 1;
            // 
            // pn_favourite
            // 
            this.pn_favourite.BackColor = System.Drawing.Color.MediumPurple;
            this.pn_favourite.Controls.Add(this.pb_favourite);
            this.pn_favourite.Controls.Add(this.lb_favourite);
            this.pn_favourite.Location = new System.Drawing.Point(360, 3);
            this.pn_favourite.Name = "pn_favourite";
            this.pn_favourite.Size = new System.Drawing.Size(90, 74);
            this.pn_favourite.TabIndex = 0;
            this.pn_favourite.Click += new System.EventHandler(this.PlaylistTab_Click);
            // 
            // pb_favourite
            // 
            this.pb_favourite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_favourite.BackgroundImage")));
            this.pb_favourite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_favourite.Location = new System.Drawing.Point(17, 5);
            this.pb_favourite.Name = "pb_favourite";
            this.pb_favourite.Size = new System.Drawing.Size(56, 46);
            this.pb_favourite.TabIndex = 1;
            this.pb_favourite.TabStop = false;
            this.pb_favourite.Click += new System.EventHandler(this.PlaylistTab_Click);
            // 
            // lb_favourite
            // 
            this.lb_favourite.AutoSize = true;
            this.lb_favourite.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_favourite.Location = new System.Drawing.Point(17, 54);
            this.lb_favourite.Name = "lb_favourite";
            this.lb_favourite.Size = new System.Drawing.Size(53, 16);
            this.lb_favourite.TabIndex = 0;
            this.lb_favourite.Text = "Playlist";
            this.lb_favourite.Click += new System.EventHandler(this.PlaylistTab_Click);
            // 
            // pn_recents
            // 
            this.pn_recents.BackColor = System.Drawing.Color.MediumPurple;
            this.pn_recents.Controls.Add(this.pb_recents);
            this.pn_recents.Controls.Add(this.ln_recents);
            this.pn_recents.Location = new System.Drawing.Point(241, 3);
            this.pn_recents.Name = "pn_recents";
            this.pn_recents.Size = new System.Drawing.Size(90, 74);
            this.pn_recents.TabIndex = 0;
            this.pn_recents.Click += new System.EventHandler(this.LoveTab_Click);
            // 
            // pb_recents
            // 
            this.pb_recents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_recents.BackgroundImage")));
            this.pb_recents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_recents.Location = new System.Drawing.Point(17, 5);
            this.pb_recents.Name = "pb_recents";
            this.pb_recents.Size = new System.Drawing.Size(56, 46);
            this.pb_recents.TabIndex = 1;
            this.pb_recents.TabStop = false;
            this.pb_recents.Click += new System.EventHandler(this.LoveTab_Click);
            // 
            // ln_recents
            // 
            this.ln_recents.AutoSize = true;
            this.ln_recents.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_recents.Location = new System.Drawing.Point(24, 54);
            this.ln_recents.Name = "ln_recents";
            this.ln_recents.Size = new System.Drawing.Size(38, 16);
            this.ln_recents.TabIndex = 0;
            this.ln_recents.Text = "Love";
            this.ln_recents.Click += new System.EventHandler(this.LoveTab_Click);
            // 
            // pn_playlist
            // 
            this.pn_playlist.BackColor = System.Drawing.Color.MediumPurple;
            this.pn_playlist.Controls.Add(this.pb_playlist);
            this.pn_playlist.Controls.Add(this.lb_playlist);
            this.pn_playlist.Location = new System.Drawing.Point(120, 3);
            this.pn_playlist.Name = "pn_playlist";
            this.pn_playlist.Size = new System.Drawing.Size(90, 74);
            this.pn_playlist.TabIndex = 0;
            this.pn_playlist.Click += new System.EventHandler(this.MusicTab_Click);
            // 
            // pb_playlist
            // 
            this.pb_playlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_playlist.BackgroundImage")));
            this.pb_playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_playlist.Location = new System.Drawing.Point(17, 5);
            this.pb_playlist.Name = "pb_playlist";
            this.pb_playlist.Size = new System.Drawing.Size(56, 46);
            this.pb_playlist.TabIndex = 1;
            this.pb_playlist.TabStop = false;
            this.pb_playlist.Click += new System.EventHandler(this.MusicTab_Click);
            // 
            // lb_playlist
            // 
            this.lb_playlist.AutoSize = true;
            this.lb_playlist.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_playlist.Location = new System.Drawing.Point(23, 54);
            this.lb_playlist.Name = "lb_playlist";
            this.lb_playlist.Size = new System.Drawing.Size(43, 16);
            this.lb_playlist.TabIndex = 0;
            this.lb_playlist.Text = "Music";
            this.lb_playlist.Click += new System.EventHandler(this.MusicTab_Click);
            // 
            // pn_tabMusic
            // 
            this.pn_tabMusic.BackColor = System.Drawing.Color.MediumPurple;
            this.pn_tabMusic.Controls.Add(this.pb_tabMusic);
            this.pn_tabMusic.Controls.Add(this.lb_tabMusic);
            this.pn_tabMusic.Location = new System.Drawing.Point(0, 3);
            this.pn_tabMusic.Name = "pn_tabMusic";
            this.pn_tabMusic.Size = new System.Drawing.Size(90, 74);
            this.pn_tabMusic.TabIndex = 0;
            this.pn_tabMusic.Click += new System.EventHandler(this.HomeTab_Click);
            // 
            // pb_tabMusic
            // 
            this.pb_tabMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_tabMusic.BackgroundImage")));
            this.pb_tabMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_tabMusic.Location = new System.Drawing.Point(17, 5);
            this.pb_tabMusic.Name = "pb_tabMusic";
            this.pb_tabMusic.Size = new System.Drawing.Size(56, 46);
            this.pb_tabMusic.TabIndex = 1;
            this.pb_tabMusic.TabStop = false;
            this.pb_tabMusic.Click += new System.EventHandler(this.HomeTab_Click);
            // 
            // lb_tabMusic
            // 
            this.lb_tabMusic.AutoSize = true;
            this.lb_tabMusic.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tabMusic.Location = new System.Drawing.Point(22, 54);
            this.lb_tabMusic.Name = "lb_tabMusic";
            this.lb_tabMusic.Size = new System.Drawing.Size(43, 16);
            this.lb_tabMusic.TabIndex = 0;
            this.lb_tabMusic.Text = "Home";
            this.lb_tabMusic.Click += new System.EventHandler(this.HomeTab_Click);
            // 
            // pn_UC
            // 
            this.pn_UC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_UC.Location = new System.Drawing.Point(0, 47);
            this.pn_UC.Name = "pn_UC";
            this.pn_UC.Size = new System.Drawing.Size(450, 536);
            this.pn_UC.TabIndex = 2;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 660);
            this.Controls.Add(this.pn_UC);
            this.Controls.Add(this.pn_bottomNavigationbar);
            this.Controls.Add(this.pn_titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.pn_titleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.pn_bottomNavigationbar.ResumeLayout(false);
            this.pn_favourite.ResumeLayout(false);
            this.pn_favourite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_favourite)).EndInit();
            this.pn_recents.ResumeLayout(false);
            this.pn_recents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_recents)).EndInit();
            this.pn_playlist.ResumeLayout(false);
            this.pn_playlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_playlist)).EndInit();
            this.pn_tabMusic.ResumeLayout(false);
            this.pn_tabMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tabMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_titleBar;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Panel pn_bottomNavigationbar;
        private System.Windows.Forms.Panel pn_favourite;
        private System.Windows.Forms.PictureBox pb_favourite;
        private System.Windows.Forms.Label lb_favourite;
        private System.Windows.Forms.Panel pn_recents;
        private System.Windows.Forms.PictureBox pb_recents;
        private System.Windows.Forms.Label ln_recents;
        private System.Windows.Forms.Panel pn_playlist;
        private System.Windows.Forms.PictureBox pb_playlist;
        private System.Windows.Forms.Label lb_playlist;
        private System.Windows.Forms.Panel pn_tabMusic;
        private System.Windows.Forms.PictureBox pb_tabMusic;
        private System.Windows.Forms.Label lb_tabMusic;
        private System.Windows.Forms.Panel pn_UC;
    }
}