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
            var f = FloatButton.Checked;
            var c = ColorBox.CurColor;
            RGBBox.Text =
                $"({CStringGenerator.GetString(c.R, f)}," +
                $" {CStringGenerator.GetString(c.G, f)}," +
                $" {CStringGenerator.GetString(c.B, f)})";
            var hsv = CHSV.Calc(c);
            HSVBox.Text =
                $"({CStringGenerator.GetString(hsv[0], f)}," +
                $" {CStringGenerator.GetString(hsv[1], f)}," +
                $" {CStringGenerator.GetString(hsv[2], f)})";
        }
    }

    static class CStringGenerator
    {
        public static string GetString(byte val, bool f)
        {
            return f ? GetFloatString(val) : GetIntString(val);
        }

        public static string GetString(float val, bool f)
        {
            return f ? GetFloatString(val) : GetIntString(val);
        }

        private static string GetFloatString(byte val)
        {
            return GetFloatString(val / 255.0f);
        }

        private static string GetFloatString(float val)
        {
            return $"{val:F3}f";
        }

        private static string GetIntString(byte val)
        {
            return val.ToString();
        }

        private static string GetIntString(float val)
        {
            return GetIntString((byte)Math.Floor(val * 255.0f));
        }
    }
}
