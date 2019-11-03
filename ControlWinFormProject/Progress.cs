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
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 99)
            {
                label1.Text = "It's Done.";
            }
            else
            {
                progressBar1.Increment(1);
                label1.Text = progressBar1.Value.ToString() + " %";
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value = 0;
                label1.Text = string.Empty;
            }
        }

        private void 圖片版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Progress2 progress = new Progress2();
            this.Visible = false;
            progress.Show();
        }

        private void 圓形版1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Progress3 progress = new Progress3();
            this.Visible = false;
            progress.Show();
        }

        private void 文字版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Progress4 progress = new Progress4();
            this.Visible = false;
            progress.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}