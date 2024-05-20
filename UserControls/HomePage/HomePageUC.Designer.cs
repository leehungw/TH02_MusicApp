namespace TH02_MusicApp.UserControls.HomePage
{
    partial class HomePageUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageUC));
            this.pb_ad = new System.Windows.Forms.PictureBox();
            this.pn_button = new System.Windows.Forms.Panel();
            this.llb_download = new System.Windows.Forms.LinkLabel();
            this.llb_recently = new System.Windows.Forms.LinkLabel();
            this.fpn_recent_download = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ad)).BeginInit();
            this.pn_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_ad
            // 
            this.pb_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_ad.Image = ((System.Drawing.Image)(resources.GetObject("pb_ad.Image")));
            this.pb_ad.Location = new System.Drawing.Point(0, 0);
            this.pb_ad.Name = "pb_ad";
            this.pb_ad.Size = new System.Drawing.Size(450, 183);
            this.pb_ad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ad.TabIndex = 0;
            this.pb_ad.TabStop = false;
            // 
            // pn_button
            // 
            this.pn_button.BackColor = System.Drawing.Color.BlueViolet;
            this.pn_button.Controls.Add(this.llb_download);
            this.pn_button.Controls.Add(this.llb_recently);
            this.pn_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_button.Location = new System.Drawing.Point(0, 183);
            this.pn_button.Name = "pn_button";
            this.pn_button.Size = new System.Drawing.Size(450, 70);
            this.pn_button.TabIndex = 1;
            // 
            // llb_download
            // 
            this.llb_download.AutoSize = true;
            this.llb_download.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_download.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.llb_download.Location = new System.Drawing.Point(125, 28);
            this.llb_download.Name = "llb_download";
            this.llb_download.Size = new System.Drawing.Size(70, 18);
            this.llb_download.TabIndex = 3;
            this.llb_download.TabStop = true;
            this.llb_download.Text = "Download";
            this.llb_download.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDownload_LinkClicked);
            // 
            // llb_recently
            // 
            this.llb_recently.AutoSize = true;
            this.llb_recently.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_recently.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.llb_recently.Location = new System.Drawing.Point(21, 28);
            this.llb_recently.Name = "llb_recently";
            this.llb_recently.Size = new System.Drawing.Size(63, 18);
            this.llb_recently.TabIndex = 2;
            this.llb_recently.TabStop = true;
            this.llb_recently.Text = "Recently";
            this.llb_recently.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRecently_LinkClicked);
            // 
            // fpn_recent_download
            // 
            this.fpn_recent_download.AutoScroll = true;
            this.fpn_recent_download.BackColor = System.Drawing.Color.RosyBrown;
            this.fpn_recent_download.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fpn_recent_download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpn_recent_download.Location = new System.Drawing.Point(0, 253);
            this.fpn_recent_download.Name = "fpn_recent_download";
            this.fpn_recent_download.Size = new System.Drawing.Size(450, 283);
            this.fpn_recent_download.TabIndex = 2;
            // 
            // HomePageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpn_recent_download);
            this.Controls.Add(this.pn_button);
            this.Controls.Add(this.pb_ad);
            this.Name = "HomePageUC";
            this.Size = new System.Drawing.Size(450, 536);
            this.Load += new System.EventHandler(this.UCHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ad)).EndInit();
            this.pn_button.ResumeLayout(false);
            this.pn_button.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_button;
        private System.Windows.Forms.FlowLayoutPanel fpn_recent_download;
        private System.Windows.Forms.LinkLabel llb_download;
        private System.Windows.Forms.LinkLabel llb_recently;
        private System.Windows.Forms.PictureBox pb_ad;
    }
}
