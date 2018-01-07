using Forge.Managers;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Forge.Interfaces
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void RefreshToolbox() // Refreshes the tiles shown within the toolbox.
        {
            tabToolbox.TabPages.Clear();

            foreach (string tt in TileManager.tileTypes) // Get each type of cell that there is.
            {
                TabPage newTabPage = new TabPage(tt); // Create a new tab dedicated to the tile type.

                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.AutoScroll = true;
                panel.Size = new System.Drawing.Size(450, 183);
                panel.WrapContents = true;

                foreach (TileManager.Tile t in TileManager.tiles) // Add each tile to its associated tab.
                {
                    if (t.type == tt)
                    {
                        panel.Controls.Add(t.icon); // The TileSelector control associated with the current tile.
                    }

                }

                newTabPage.Controls.Add(panel);

                tabToolbox.TabPages.Add(newTabPage);
            }
        }

        public void BackgroundColorChanged(Color color)
        {
            btnBackgroundColour.BackColor = color;
        }

        private void Editor_Load(object sender, System.EventArgs e)
        {
            RefreshToolbox();
        }

        private void btnOpenContentDirectory_Click(object sender, System.EventArgs e)
        {
            string contentDirectory = ContentManager.GetDirectory("\\Content", true); // Get a path to the directory where tile sprites and data are stored.
            if (contentDirectory != null)
            {
                Process.Start("explorer", @contentDirectory);
            }
        }

        private void picRefreshToolbox_Click(object sender, System.EventArgs e)
        {
            TileManager.RefreshTileList(); // Force the tile manager to recollect active tiles.
            RefreshToolbox(); // Refresh the toolbox.
        }

        private void btnBackgroundColour_Click(object sender, System.EventArgs e)
        {
            DialogResult dialog = dlgBackgroundColour.ShowDialog(); // Show a colour dialog window.

            if (dialog == DialogResult.OK)
            {
                btnBackgroundColour.BackColor = dlgBackgroundColour.Color; // Set the colour of the paintbrush button.
                levelViewport.BackgroundColour = dlgBackgroundColour.Color; // Set the colour of the editor.
            }
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            InterfaceManager.splashWindow.Close();
        }

        public void SetActiveTile(TileManager.Tile tile) // Change the user's active tile.
        {
            picActiveTile.Image = tile.actualSprite;
            lblActiveTile.Text = tile.name;
        }

        private void btnClearAllTiles_Click(object sender, System.EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure that you want to clear the viewport of all existing tiles?", "Just making sure...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(choice == DialogResult.Yes)
            {
                levelViewport.ClearAllDrawings();
            }
        }

        private void btnCellSize_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            levelViewport.CellSize = Convert.ToInt32(e.ClickedItem.Text); // Set the dimensions of an individual cell to the number defined by the user.
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Interfaces.Help helpWindow = new Interfaces.Help(); // Create a new help menu window.
            helpWindow.ShowDialog();
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // Make sure that the user actually wants to exit.

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
