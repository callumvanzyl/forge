using System.Threading;

namespace Forge.Interfaces
{
    partial class Splash
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
            this.picSplash = new System.Windows.Forms.PictureBox();
            this.fprgLoadApplication = new Forge.Controls.FlatProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // picSplash
            // 
            this.picSplash.Image = global::Forge.Properties.Resources.Splash;
            this.picSplash.Location = new System.Drawing.Point(13, 0);
            this.picSplash.Name = "picSplash";
            this.picSplash.Size = new System.Drawing.Size(475, 171);
            this.picSplash.TabIndex = 1;
            this.picSplash.TabStop = false;
            // 
            // fprgLoadApplication
            // 
            this.fprgLoadApplication.Color = System.Drawing.Color.RoyalBlue;
            this.fprgLoadApplication.Location = new System.Drawing.Point(0, 170);
            this.fprgLoadApplication.Name = "fprgLoadApplication";
            this.fprgLoadApplication.Size = new System.Drawing.Size(500, 10);
            this.fprgLoadApplication.TabIndex = 2;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(500, 180);
            this.ControlBox = false;
            this.Controls.Add(this.fprgLoadApplication);
            this.Controls.Add(this.picSplash);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 180);
            this.Name = "Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORGE";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picSplash;
        private Controls.FlatProgressBar fprgLoadApplication;
    }
}