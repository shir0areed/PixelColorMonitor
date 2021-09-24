using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelColorMonitor
{
    public partial class ColorBox : PictureBox
    {
        public ColorBox()
        {
            InitializeComponent();

            if (!DesignMode)
                Image = bitmap;
        }

        public void PickFromScreen(Point location)
        {
            using (var g = Graphics.FromImage(Image))
                g.CopyFromScreen(location, new Point(0, 0), Image.Size);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

            base.OnPaint(pe);
        }

        readonly Bitmap bitmap = new Bitmap(1, 1);
    }
}
