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
    public partial class FontDialog : Form
    {
        public FontDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //显示字体对话框
            DialogResult dr = fontDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮，则更改文本框中的字体
            if (dr == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();

        }
    }
}