using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWinFormProject
{
    public partial class TrackBar : Form
    {
        public TrackBar()
        {
            InitializeComponent();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Minimum = 10;
            trackBar1.Maximum = 72;
            label1.Font = new Font("標楷體", trackBar1.Value);
        }

        private void TrackBar_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("標楷體", 10);
        }
    }
}