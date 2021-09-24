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
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

            base.OnPaint(pe);
        }
    }
}
