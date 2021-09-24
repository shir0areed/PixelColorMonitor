using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelColorMonitor
{
    public partial class PixelColorMonitorForm : Form
    {
        public PixelColorMonitorForm()
        {
            InitializeComponent();
            ColorBox.Image = new Bitmap(1, 1);
        }

        private void PickButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (var g = Graphics.FromImage(ColorBox.Image))
                    g.CopyFromScreen(PickButton.PointToScreen(e.Location), new Point(0, 0), ColorBox.Image.Size);
                ColorBox.Invalidate();
            }
        }

        private void PickButton_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
