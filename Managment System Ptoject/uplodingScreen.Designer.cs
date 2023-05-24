
namespace Managment_System_Ptoject
{
    partial class uplodingScreen
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
            this.components = new System.ComponentModel.Container();
            this.headline = new System.Windows.Forms.Label();
            this.progressBarLabel = new System.Windows.Forms.Label();
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // headline
            // 
            this.headline.AutoSize = true;
            this.headline.BackColor = System.Drawing.Color.Transparent;
            this.headline.Font = new System.Drawing.Font("Imprint MT Shadow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headline.ForeColor = System.Drawing.Color.Black;
            this.headline.Location = new System.Drawing.Point(178, 9);
            this.headline.Name = "headline";
            this.headline.Size = new System.Drawing.Size(664, 56);
            this.headline.TabIndex = 0;
            this.headline.Text = "Employee Managment System";
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.AutoSize = true;
            this.progressBarLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBarLabel.Font = new System.Drawing.Font("Sitka Small", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.progressBarLabel.ForeColor = System.Drawing.Color.White;
            this.progressBarLabel.Location = new System.Drawing.Point(452, 234);
            this.progressBarLabel.Name = "progressBarLabel";
            this.progressBarLabel.Size = new System.Drawing.Size(0, 54);
            this.progressBarLabel.TabIndex = 0;
            // 
            // loadingBar
            // 
            this.loadingBar.ForeColor = System.Drawing.Color.Lime;
            this.loadingBar.Location = new System.Drawing.Point(165, 222);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(722, 29);
            this.loadingBar.TabIndex = 1;
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Enabled = true;
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // uplodingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Managment_System_Ptoject.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 570);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.progressBarLabel);
            this.Controls.Add(this.headline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1003, 570);
            this.MinimumSize = new System.Drawing.Size(1003, 570);
            this.Name = "uplodingScreen";
            this.Text = "uplodingScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headline;
        private System.Windows.Forms.Label progressBarLabel;
        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.Timer progressBarTimer;
    }
}