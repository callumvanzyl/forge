using Forge.Controls;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Forge.Managers
{
    /// <summary>
    /// A service used to manage game tiles
    /// and tile data within the application.
    /// </summary>
    public static class TileManager
    {
        public static List<Tile> tiles;
        public static List<string> tileTypes; 

        public class Tile
        {
            public bool collidable;
            public string name;
            public string sprite;
            public string type;

            public Image actualSprite;

            public TileSelector icon;
        }

        private static Tile activeTile;
        public static Tile ActiveTile
        {
            get
            {
                return activeTile;
            }
            set
            {
                activeTile = value;
                InterfaceManager.editorWindow.SetActiveTile(activeTile); // Set the active tile shown within the editor.
            }
        }

        private static Tile CreateTile(FileStream data) // Create a new tile object.
        {
            string rawData = File.ReadAllText(data.Name); // Read the JSON data file.
            Tile newTile = JsonConvert.DeserializeObject<Tile>(rawData); // Deserialize the raw JSON data into a new tile objects.

            Image sprite = ContentManager.GetImage(newTile.sprite, true); // Fetch the sprite associated with the new tile object.
            if (sprite != null)
            {
                newTile.actualSprite = sprite; // Set the sprite property of the new tile.
                newTile.icon = new TileSelector(newTile); // Create a new TileSelector object to be associated with this tile.
            }
            else
            {
                MessageBox.Show(".." + newTile.sprite + " is not a valid path for the sprite of the " + newTile.name + " tile, it will therefore not be added to your toolbox.", "Initialization Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Something is wrong with the JSON data, just skip it.
                return null;
            }

            return newTile;
        }

        public static void RefreshTileList()
        {
            tiles = new List<Tile>(); // Rebuild the tile and tile type list.
            tileTypes = new List<string>();

            string[] tileDirectory = ContentManager.GetDirectoryContent("\\Content\\Tiles\\Data", true); // Fetch the directory where tile data is stored.

            if (tileDirectory != null)
            {
                foreach (string f in tileDirectory)
                {
                    FileStream file = ContentManager.GetFile(f, false); // Fetch a tile data file.
                    Tile newTile = CreateTile(file); // Create new tile object from tile data file.
                    if (newTile != null)
                    {
                        tiles.Add(newTile); // Add the new tile to the list of available tiles.

                        if(tileTypes.Contains(newTile.type) == false) // If the tile type associated with this tile has not been acknowledged...
                        {
                            tileTypes.Add(newTile.type); // Add it!
                        }
                    } 
                }
            }
        }
    }
}
