using System;
using System.Drawing;
using System.Windows.Forms;
using Forge.Managers;

namespace Forge.Controls
{
    public partial class Viewport : UserControl
    {
        Timer update = new Timer();

        private int cellSize = 32;
        public int CellSize
        {
            get
            {
                return cellSize;
            }
            set
            {
                cellSize = value;
                Refresh();
            }
        }

        private Color backgroundColour;
        public Color BackgroundColour
        {
            get
            {
                return backgroundColour;
            }
            set
            {
                backgroundColour = value;
                BackColor = backgroundColour;
            }
        }

        private TileManager.Tile[,] TileDrawings = new TileManager.Tile[100, 100]; // Where we store tiles that should appear on the editor when it is redrawn.

        public Viewport()
        {
            this.Load += Viewport_Load;
        }

        private void DrawGrid()
        {
            Graphics g;
            g = CreateGraphics();

            g.DrawRectangle(Pens.Black, 0, 0, Width-1, Height-1);

            for (int x = 0; x < Width / CellSize; x++)
            {
                for (int y = 0; y < Height / CellSize; y++)
                {
                    g.DrawRectangle(Pens.Black, x * CellSize, y * CellSize, CellSize, CellSize);
                }
            }

            g.Dispose();
        }

        private void DrawFrame(object sender, EventArgs e) // Redraw the editor.
        {
            DrawTiles();
            DrawGrid();
        }

        private void Viewport_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.Location.X - e.Location.X % CellSize) / CellSize; // Calculate the x and y coordinates of the user's mouse press.
            int y = (e.Location.Y - e.Location.Y % CellSize) / CellSize;

            if (e.Button == MouseButtons.Left) // When the user left-clicks...
            {
                if (TileManager.ActiveTile != null) // Ensure that the user has actually selected a tile.
                {
                    DrawTile(TileManager.ActiveTile, x, y); // Add a tile to the drawing loop.
                }
            }
            else if (e.Button == MouseButtons.Right) // When the user right-clicks...
            {
                ClearDrawing(x, y); // Attempt to erase a tile.
            }
        }

        private void DrawTile(TileManager.Tile tile, int x, int y)
        {
            if (TileDrawings[x, y] == null) // If a tile has not already been placed at the defined coordinates...
            {
                TileDrawings[x, y] = tile; // Add a tile to the drawing loop.
            }
            else // If a tile has already been placed at the defined coordinates...
            {
                TileDrawings[x, y] = null; // Erase the tile.
                TileDrawings[x, y] = tile;
            }
            Refresh(); // IT'S REDRAWING TIME!
        }

        public void DrawTiles()
        {
            for (int x = 0; x < TileDrawings.GetLength(0); x++) // Iterate through each tile within the list of tiles that should be drawn.
                // TO-DO: Optimize this by calculating how many cells it is necessary for us to iterate through using EDITOR SIZE/CELL SIZE
                //        because we iterate through 10000 members every redraw using this method.
            {
                for (int y = 0; y < TileDrawings.GetLength(1); y++)
                {
                    if (TileDrawings[x, y] != null) // If a tile should be drawn at the current coordinates...
                    {
                        Graphics g = CreateGraphics();
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None; // Prevents the sprite being drawn blurry.

                        g.DrawImage(TileDrawings[x, y].actualSprite, x * CellSize + 1, y * CellSize + 1, CellSize - 1, CellSize - 1); // Position, scale and draw the sprite on the screen.

                        g.Dispose();
                    }
                }
            }
        }

        public void ClearDrawing(int x, int y) // Remove a single tile from the drawing loop.
        {
            if (TileDrawings[x, y] != null) // Make sure a tile has been placed at the defined coordinate.
            {
                TileDrawings[x, y] = null; // Remove the sprite at the defined coordinate.
                Refresh();
            }
        }

        public void ClearAllDrawings()
        {
            for (int x = 0; x < TileDrawings.GetLength(0); x++)
            {
                for (int y = 0; y < TileDrawings.GetLength(1); y++)
                {
                    ClearDrawing(x, y);
                }
            }
        }

        private void Viewport_Load(object sender, EventArgs e)
        {
            this.MouseDown += Viewport_MouseDown;

            update.Tick += new EventHandler(DrawFrame);

            update.Interval = 33;
            update.Enabled = true;

            update.Start(); // Initiate the drawing loop.

            DrawGrid();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // Double buffering prevents a ton of flashing.
        }
    }
}
