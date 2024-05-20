namespace TH02_MusicApp.UserControls.HomePage
{
    partial class MusicInfoBlock
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
            this.lb_name = new System.Windows.Forms.Label();
            this.pb_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.BackColor = System.Drawing.Color.IndianRed;
            this.lb_name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(0, 100);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(130, 95);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Rồi ta sẽ ngắm pháo hoa cùng nhau";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_name.Click += new System.EventHandler(this.MusicInfoItem_Click);
            // 
            // pb_image
            // 
            this.pb_image.BackColor = System.Drawing.Color.IndianRed;
            this.pb_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_image.Location = new System.Drawing.Point(0, 0);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(130, 101);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 3;
            this.pb_image.TabStop = false;
            this.pb_image.Click += new System.EventHandler(this.MusicInfoItem_Click);
            // 
            // MusicInfoBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.lb_name);
            this.Name = "MusicInfoBlock";
            this.Size = new System.Drawing.Size(130, 195);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox pb_image;
    }
}
