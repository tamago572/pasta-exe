namespace pasta_exe
{
    partial class Form1
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
            playPastaBtn = new Button();
            reverbBar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)reverbBar).BeginInit();
            SuspendLayout();
            // 
            // playPastaBtn
            // 
            playPastaBtn.BackColor = Color.Aqua;
            playPastaBtn.Cursor = Cursors.Hand;
            playPastaBtn.Font = new Font("Yu Gothic UI", 48F);
            playPastaBtn.Location = new Point(162, 273);
            playPastaBtn.Name = "playPastaBtn";
            playPastaBtn.Size = new Size(484, 107);
            playPastaBtn.TabIndex = 0;
            playPastaBtn.Text = "button1";
            playPastaBtn.UseVisualStyleBackColor = false;
            playPastaBtn.Click += playPastaBtn_Click;
            // 
            // reverbBar
            // 
            reverbBar.Location = new Point(124, 36);
            reverbBar.Name = "reverbBar";
            reverbBar.Size = new Size(548, 45);
            reverbBar.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reverbBar);
            Controls.Add(playPastaBtn);
            Name = "Form1";
            Text = "パスタ作ったお前.exe";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)reverbBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playPastaBtn;
        private TrackBar reverbBar;
    }
}
