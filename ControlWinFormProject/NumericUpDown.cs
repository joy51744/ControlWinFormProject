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
    public partial class NumericUpDown : Form
    {
        public NumericUpDown()
        {
            InitializeComponent();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal n1, n2;
            decimal sum = 0;
            n1 = numericUpDown1.Value;
            n2 = numericUpDown2.Value;
        }
    }
}
