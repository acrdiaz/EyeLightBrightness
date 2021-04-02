using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeLightBrightness
{
    public partial class frmTrackBar : Form
    {
        public frmTrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            SetBrightness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetBrightness();
        }

        private void SetBrightness()
        {
            short value = (short)trackBar1.Value;
            label1.Text = "Brightness Color: " + value;
            Display.SetBrightness(value);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Display.SetBrightness(100);
        }
    }
}
