using System.Windows.Forms;

namespace Forge.Controls
{
    public partial class TileIcon : PictureBox
    {
        public TileIcon()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            base.OnPaint(e);
        }
    }
}
