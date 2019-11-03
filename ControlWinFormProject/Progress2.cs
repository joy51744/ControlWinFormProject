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
    public partial class Progress2 : Form
    {
        public Progress2()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }
        }

        private void Progress2_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
        }
    }
}