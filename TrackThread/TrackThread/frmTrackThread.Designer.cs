namespace TrackThread
{
    partial class frmTrackThread
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRun = new Button();
            lbThread = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.BackColor = SystemColors.GradientActiveCaption;
            btnRun.Location = new Point(85, 82);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // lbThread
            // 
            lbThread.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbThread.AutoSize = true;
            lbThread.BackColor = SystemColors.ActiveCaption;
            lbThread.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbThread.Location = new Point(57, 38);
            lbThread.Name = "lbThread";
            lbThread.Size = new Size(75, 21);
            lbThread.TabIndex = 1;
            lbThread.Text = "-Thread-";
            lbThread.Click += lbThread_Click;
            // 
            // frmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpaperflare_com_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(257, 135);
            Controls.Add(lbThread);
            Controls.Add(btnRun);
            Name = "frmTrackThread";
            Text = "frmTrackThread";
            Load += frmTrackThread_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Label lbThread;
    }
}
