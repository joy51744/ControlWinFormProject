﻿using System;
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
    }
}
