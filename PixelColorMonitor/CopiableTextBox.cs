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
    public partial class CopiableTextBox : TextBox
    {
        public CopiableTextBox()
        {
            InitializeComponent();

            ReadOnly = true;
        }
    }
}
