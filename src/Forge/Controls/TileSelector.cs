using System.Windows.Forms;
using Forge.Managers;

namespace Forge.Controls
{
    public partial class TileSelector : UserControl
    {
        private TileManager.Tile currentTile;
        public TileManager.Tile CurrentTile
        {
            get
            {
                return currentTile;
            }
            set
            {
                currentTile = value;
                picSprite.Image = currentTile.actualSprite;
                lblName.Text = currentTile.name;
            }
        }
       
        public TileSelector(TileManager.Tile tile)
        {
            InitializeComponent();
            CurrentTile = tile;
        }

        private void picSprite_Click(object sender, System.EventArgs e)
        {
            TileManager.ActiveTile = currentTile; // Set the active tile to the tile associated with this instance.
        }
    }
}
