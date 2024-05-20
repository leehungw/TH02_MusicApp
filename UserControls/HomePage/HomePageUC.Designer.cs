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
            this.pb_ad = new System.Windows.Forms.PictureBox();
            this.pn_button = new System.Windows.Forms.Panel();
            this.fpn_recent_download = new System.Windows.Forms.FlowLayoutPanel();
            this.llb_download = new System.Windows.Forms.LinkLabel();
            this.llb_recently = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ad)).BeginInit();
            this.pn_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_ad
            // 
            this.pb_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_ad.Location = new System.Drawing.Point(0, 0);
            this.pb_ad.Name = "pb_ad";
            this.pb_ad.Size = new System.Drawing.Size(450, 183);
            this.pb_ad.TabIndex = 0;
            this.pb_ad.TabStop = false;
            // 
            // pn_button
            // 
            this.pn_button.Controls.Add(this.llb_download);
            this.pn_button.Controls.Add(this.llb_recently);
            this.pn_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_button.Location = new System.Drawing.Point(0, 183);
            this.pn_button.Name = "pn_button";
            this.pn_button.Size = new System.Drawing.Size(450, 70);
            this.pn_button.TabIndex = 1;
            // 
            // fpn_recent_download
            // 
            this.fpn_recent_download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpn_recent_download.Location = new System.Drawing.Point(0, 253);
            this.fpn_recent_download.Name = "fpn_recent_download";
            this.fpn_recent_download.Size = new System.Drawing.Size(450, 283);
            this.fpn_recent_download.TabIndex = 2;
            // 
            // llb_download
            // 
            this.llb_download.AutoSize = true;
            this.llb_download.Location = new System.Drawing.Point(125, 28);
            this.llb_download.Name = "llb_download";
            this.llb_download.Size = new System.Drawing.Size(68, 16);
            this.llb_download.TabIndex = 3;
            this.llb_download.TabStop = true;
            this.llb_download.Text = "Download";
            // 
            // llb_recently
            // 
            this.llb_recently.AutoSize = true;
            this.llb_recently.Location = new System.Drawing.Point(21, 28);
            this.llb_recently.Name = "llb_recently";
            this.llb_recently.Size = new System.Drawing.Size(60, 16);
            this.llb_recently.TabIndex = 2;
            this.llb_recently.TabStop = true;
            this.llb_recently.Text = "Recently";
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_ad)).EndInit();
            this.pn_button.ResumeLayout(false);
            this.pn_button.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ad;
        private System.Windows.Forms.Panel pn_button;
        private System.Windows.Forms.FlowLayoutPanel fpn_recent_download;
        private System.Windows.Forms.LinkLabel llb_download;
        private System.Windows.Forms.LinkLabel llb_recently;
    }
}
