namespace TH02_MusicApp.UserControls.PlaylistPage
{
    partial class PlaylistItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbDelete = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ptbDelete);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(328, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 51);
            this.panel1.TabIndex = 5;
            // 
            // ptbDelete
            // 
            this.ptbDelete.BackColor = System.Drawing.Color.Plum;
            this.ptbDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbDelete.Image = ((System.Drawing.Image)(resources.GetObject("ptbDelete.Image")));
            this.ptbDelete.Location = new System.Drawing.Point(55, 0);
            this.ptbDelete.Name = "ptbDelete";
            this.ptbDelete.Padding = new System.Windows.Forms.Padding(6);
            this.ptbDelete.Size = new System.Drawing.Size(51, 51);
            this.ptbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDelete.TabIndex = 2;
            this.ptbDelete.TabStop = false;
            this.ptbDelete.Click += new System.EventHandler(this.ptbDelete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Plum;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Size = new System.Drawing.Size(51, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.ptbDeleteInside_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(134, 24);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(98, 24);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "lb_name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PlaylistItem";
            this.Size = new System.Drawing.Size(437, 109);
            this.DoubleClick += new System.EventHandler(this.PlaylistFolderBar_DoubleClick);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbDelete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
