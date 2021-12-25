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
            LocationLabel.Text = location.ToString();
            var c = ColorBox.CurColor;
            RGBBox.Text =
                $"({CStringGenerator.GetFloatString(c.R)}," +
                $" {CStringGenerator.GetFloatString(c.G)}," +
                $" {CStringGenerator.GetFloatString(c.B)})";
            var hsv = CHSV.Calc(c);
            HSVBox.Text =
                $"({CStringGenerator.GetFloatString(hsv[0])}," +
                $" {CStringGenerator.GetFloatString(hsv[1])}," +
                $" {CStringGenerator.GetFloatString(hsv[2])})";
        }
    }

    static class CStringGenerator
    {
        public static string GetFloatString(byte val)
        {
            return GetFloatString(val / 255.0f);
        }

        public static string GetFloatString(float val)
        {
            return $"{val:F3}f";
        }
    }
}
