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
        }

        Point location = default;

        private void PickButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                location = PickButton.PointToScreen(e.Location);
        }

        private void PickTimer_Tick(object sender, EventArgs e)
        {
            ColorBox.PickFromScreen(location);
            LocationBox.Text = location.ToString();
            var c = ColorBox.CurColor;
            RGBBox.Text =
                $"({CStringGenerator.GetColorString(c.R)}," +
                $" {CStringGenerator.GetColorString(c.G)}," +
                $" {CStringGenerator.GetColorString(c.B)})";
        }
    }

    static class CStringGenerator
    {
        public static string GetColorString(byte val)
        {
            return $"{val / 255.0f:F3}f";
        }
    }
}
