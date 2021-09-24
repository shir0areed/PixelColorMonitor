﻿using System;
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

        private void PickButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                location = PickButton.PointToScreen(e.Location);
                ColorBox.PickFromScreen(location);
                LocationBox.Text = location.ToString();
            }
        }

        private void PickButton_MouseUp(object sender, MouseEventArgs e)
        {

        }

        Point location = default;
    }
}
