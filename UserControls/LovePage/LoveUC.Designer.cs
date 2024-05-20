namespace TH02_MusicApp.UserControls.LovePage
{
    partial class LoveUC
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
            this.fpn_loveSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fpn_loveSongs
            // 
            this.fpn_loveSongs.AutoScroll = true;
            this.fpn_loveSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpn_loveSongs.Location = new System.Drawing.Point(0, 0);
            this.fpn_loveSongs.Name = "fpn_loveSongs";
            this.fpn_loveSongs.Size = new System.Drawing.Size(450, 536);
            this.fpn_loveSongs.TabIndex = 1;
            // 
            // LoveUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.fpn_loveSongs);
            this.Name = "LoveUC";
            this.Size = new System.Drawing.Size(450, 536);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpn_loveSongs;
    }
}
