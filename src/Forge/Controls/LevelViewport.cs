using Forge.Managers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forge.Controls
{
    public partial class EditorViewport : UserControl
    {
        private bool designMode;

        public int CellSize = 32;

        Timer update = new Timer();

        private Color backgroundColor;
        public Color BackgroundColor
        {
            get
            {
                return backgroundColor;
            }
            set
            {
                backgroundColor = value;
                BackColor = backgroundColor;
            }
        }
        
        private TileManager.Tile[,] TileDrawings = new TileManager.Tile[20, 20];

        public EditorViewport()
        {
            //InitializeComponent();
        }

        private void DrawGrid()
        {
            Graphics g;
            g = CreateGraphics();

            g.DrawRectangle(Pens.Black, 1, -1, Width - 2, Height);

            for (int x = 0; x < Width / CellSize; x++)
            {
                for (int y = 0; y < Height / CellSize; y++)
                {
                    g.DrawRectangle(Pens.Black, x * CellSize, y * CellSize, CellSize, CellSize);
                }
            }
        }

        private void DrawFrame(object sender, EventArgs e)
        {
            DrawGrid();
            DrawTiles();
        }

        private void EditorViewport_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.Location.X - e.Location.X % CellSize) / CellSize;
            int y = (e.Location.Y - e.Location.Y % CellSize) / CellSize;

            if (e.Button == MouseButtons.Left)
            {
                if (TileManager.ActiveTile != null)
                {
                    if (TileDrawings[x, y] == null)
                    {
                        TileDrawings[x, y] = TileManager.ActiveTile;
                    }
                    else
                    {
                        ClearDrawing(x, y);
                        TileDrawings[x, y] = TileManager.ActiveTile;
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                ClearDrawing(x, y);
            }
        }

        public void DrawTiles()
        {

            for (int x = 0; x < TileDrawings.GetLength(0); x++)
            {
                for (int y = 0; y < TileDrawings.GetLength(1); y++)
                {
                    if (TileDrawings[x, y] != null)
                    {
                        Graphics g = CreateGraphics();
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;

                        g.DrawImage(TileDrawings[x, y].actualSprite, x * CellSize + 1, y * CellSize + 1, CellSize - 1, CellSize - 1);
                    }
                }
            }
        }

        public void ClearDrawing(int x, int y)
        {
            if (TileDrawings[x, y] != null)
            {
                TileDrawings[x, y] = null;
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

        private void EditorViewport_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            update.Tick += new EventHandler(DrawFrame);

            update.Interval = 33;
            update.Enabled = true;

            update.Start();
        }
    }
}