namespace Forge.Interfaces
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.tabToolbox = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.levelViewport = new Forge.Controls.Viewport();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpenSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBackgroundColour = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClearAllTiles = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCellSize = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpenContentDirectory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActiveTile = new System.Windows.Forms.Label();
            this.dlgBackgroundColour = new System.Windows.Forms.ColorDialog();
            this.picRefreshToolbox = new System.Windows.Forms.PictureBox();
            this.picActiveTile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefreshToolbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActiveTile)).BeginInit();
            this.SuspendLayout();
            // 
            // tabToolbox
            // 
            this.tabToolbox.Location = new System.Drawing.Point(12, 249);
            this.tabToolbox.Name = "tabToolbox";
            this.tabToolbox.SelectedIndex = 0;
            this.tabToolbox.Size = new System.Drawing.Size(450, 183);
            this.tabToolbox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.levelViewport);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 230);
            this.panel1.TabIndex = 1;
            // 
            // levelViewport
            // 
            this.levelViewport.BackColor = System.Drawing.Color.CornflowerBlue;
            this.levelViewport.BackgroundColour = System.Drawing.Color.CornflowerBlue;
            this.levelViewport.CellSize = 32;
            this.levelViewport.Location = new System.Drawing.Point(0, 28);
            this.levelViewport.Name = "levelViewport";
            this.levelViewport.Size = new System.Drawing.Size(449, 193);
            this.levelViewport.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btnOpenSave,
            this.toolStripSeparator4,
            this.btnBackgroundColour,
            this.toolStripSeparator5,
            this.btnClearAllTiles,
            this.toolStripSeparator6,
            this.btnCellSize,
            this.toolStripSeparator2,
            this.btnOpenContentDirectory,
            this.toolStripSeparator3,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel1.Text = "Editor";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOpenSave
            // 
            this.btnOpenSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.btnOpenSave.Image = global::Forge.Properties.Resources.Menu;
            this.btnOpenSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenSave.Name = "btnOpenSave";
            this.btnOpenSave.ShowDropDownArrow = false;
            this.btnOpenSave.Size = new System.Drawing.Size(20, 22);
            this.btnOpenSave.Text = "View additional options";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBackgroundColour
            // 
            this.btnBackgroundColour.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBackgroundColour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBackgroundColour.Image = global::Forge.Properties.Resources.Paintbrush;
            this.btnBackgroundColour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBackgroundColour.Name = "btnBackgroundColour";
            this.btnBackgroundColour.Size = new System.Drawing.Size(23, 22);
            this.btnBackgroundColour.Text = "toolStripButton2";
            this.btnBackgroundColour.ToolTipText = "Change the background colour of the level";
            this.btnBackgroundColour.Click += new System.EventHandler(this.btnBackgroundColour_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClearAllTiles
            // 
            this.btnClearAllTiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(152)))), ((int)(((byte)(184)))));
            this.btnClearAllTiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearAllTiles.Image = global::Forge.Properties.Resources.Eraser;
            this.btnClearAllTiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearAllTiles.Name = "btnClearAllTiles";
            this.btnClearAllTiles.Size = new System.Drawing.Size(23, 22);
            this.btnClearAllTiles.Text = "toolStripButton2";
            this.btnClearAllTiles.ToolTipText = "Clear all tiles on the viewport";
            this.btnClearAllTiles.Click += new System.EventHandler(this.btnClearAllTiles_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCellSize
            // 
            this.btnCellSize.BackColor = System.Drawing.SystemColors.Control;
            this.btnCellSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.btnCellSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCellSize.Image = global::Forge.Properties.Resources.Cells;
            this.btnCellSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCellSize.Name = "btnCellSize";
            this.btnCellSize.Size = new System.Drawing.Size(91, 22);
            this.btnCellSize.Text = "CELL SIZE";
            this.btnCellSize.ToolTipText = "Set the size of individual cells on the viewport";
            this.btnCellSize.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnCellSize_DropDownItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem2.Text = "8";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem3.Text = "16";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem4.Text = "32";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOpenContentDirectory
            // 
            this.btnOpenContentDirectory.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOpenContentDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenContentDirectory.Image = global::Forge.Properties.Resources.Folder;
            this.btnOpenContentDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenContentDirectory.Name = "btnOpenContentDirectory";
            this.btnOpenContentDirectory.Size = new System.Drawing.Size(149, 22);
            this.btnOpenContentDirectory.Text = "CONTENT DIRECTORY";
            this.btnOpenContentDirectory.ToolTipText = "Open the content directory in a new window";
            this.btnOpenContentDirectory.Click += new System.EventHandler(this.btnOpenContentDirectory_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = global::Forge.Properties.Resources.Unknown;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.Text = "HELP";
            this.btnHelp.ToolTipText = "Display the help menu";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currently Selected:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActiveTile
            // 
            this.lblActiveTile.AutoSize = true;
            this.lblActiveTile.Location = new System.Drawing.Point(150, 439);
            this.lblActiveTile.Name = "lblActiveTile";
            this.lblActiveTile.Size = new System.Drawing.Size(33, 13);
            this.lblActiveTile.TabIndex = 4;
            this.lblActiveTile.Text = "None";
            this.lblActiveTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picRefreshToolbox
            // 
            this.picRefreshToolbox.BackColor = System.Drawing.SystemColors.Control;
            this.picRefreshToolbox.Image = global::Forge.Properties.Resources.Refresh;
            this.picRefreshToolbox.Location = new System.Drawing.Point(438, 434);
            this.picRefreshToolbox.Name = "picRefreshToolbox";
            this.picRefreshToolbox.Size = new System.Drawing.Size(22, 22);
            this.picRefreshToolbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefreshToolbox.TabIndex = 5;
            this.picRefreshToolbox.TabStop = false;
            this.picRefreshToolbox.Click += new System.EventHandler(this.picRefreshToolbox_Click);
            // 
            // picActiveTile
            // 
            this.picActiveTile.Image = global::Forge.Properties.Resources.Unknown;
            this.picActiveTile.Location = new System.Drawing.Point(129, 437);
            this.picActiveTile.Name = "picActiveTile";
            this.picActiveTile.Size = new System.Drawing.Size(15, 15);
            this.picActiveTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picActiveTile.TabIndex = 3;
            this.picActiveTile.TabStop = false;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(476, 461);
            this.Controls.Add(this.picRefreshToolbox);
            this.Controls.Add(this.lblActiveTile);
            this.Controls.Add(this.picActiveTile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabToolbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 500);
            this.MinimumSize = new System.Drawing.Size(492, 500);
            this.Name = "Editor";
            this.Text = "FORGE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editor_FormClosed);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefreshToolbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActiveTile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabToolbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnOpenContentDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picActiveTile;
        private System.Windows.Forms.Label lblActiveTile;
        private System.Windows.Forms.PictureBox picRefreshToolbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripDropDownButton btnOpenSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnBackgroundColour;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ColorDialog dlgBackgroundColour;
        private System.Windows.Forms.ToolStripButton btnClearAllTiles;
        private Controls.Viewport levelViewport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSplitButton btnCellSize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}