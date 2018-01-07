using System.Drawing;
using System.Windows.Forms;

namespace Forge.Controls
{
    /// <summary>
    /// This control class is very similar to the vanilla progress bar
    /// except that we have overriden the default OnPaint event
    /// in order for the progress bar to be draw as a solid colour.
    /// </summary>
    public partial class FlatProgressBar : ProgressBar
    {
        private Color color;
        public Color Color
        {
            get
            {
                return this.color;
            }
            set
            {
                color = value;
            }
        }

        public FlatProgressBar()
        {
            this.Color = Color.Green;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bar = new Rectangle(0, 0, this.Width, this.Height);
            double scaleFactor = (((double)Value - (double)Minimum) / ((double)Maximum - (double)Minimum));

            bar.Width = (int)(bar.Width * scaleFactor);
            SolidBrush brush = new SolidBrush(this.Color);
            e.Graphics.FillRectangle(brush, 0, 0, bar.Width, bar.Height);
        }
    }
}
