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
    public partial class MenuStrip : Form
    {
        public MenuStrip()
        {
            InitializeComponent();
        }

        private void 標楷體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelShow.Font = new Font("標楷體", 16, labelShow.Font.Style);
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelShow.Font = new Font("Arial", 16, labelShow.Font.Style);
        }

        private void 粗體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelShow.Font = new Font(labelShow.Font, labelShow.Font.Style ^ FontStyle.Bold);
            粗體ToolStripMenuItem.Checked = !(粗體ToolStripMenuItem.Checked);
        }

        private void MenuStrip_Load(object sender, EventArgs e)
        {
            labelShow.Text = "歡迎光臨";
        }

        private void 斜體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelShow.Font = new Font(labelShow.Font, labelShow.Font.Style ^ FontStyle.Italic);
            斜體ToolStripMenuItem.Checked = !(斜體ToolStripMenuItem.Checked);
        }

        private void 底線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelShow.Font = new Font(labelShow.Font, labelShow.Font.Style ^ FontStyle.Underline);
            底線ToolStripMenuItem.Checked = !(斜體ToolStripMenuItem.Checked);
        }

        private void 一般ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelShow.Font = new Font(labelShow.Font, labelShow.Font.Style ^ FontStyle.Regular);
            一般ToolStripMenuItem.Checked = !(一般ToolStripMenuItem.Checked);
        }

        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelShow.ForeColor = Color.Blue;
        }

        private void 黃色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelShow.ForeColor = Color.Yellow;
        }

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelShow.ForeColor = Color.Green;
        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelShow.ForeColor = Color.Red;
        }
    }
}