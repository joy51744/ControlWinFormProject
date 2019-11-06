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
    public partial class StatusStrip : Form
    {
        public StatusStrip()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Enter the username with minimun one character.";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "";
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Enter the password with minimun one character.";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Click to Login";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "";
        }

        private void StatusStrip_Load(object sender, EventArgs e)
        {
            toolStripLabel1.BackColor = Color.SkyBlue;
        }
    }
}