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
    public partial class Progress4 : Form
    {
        public Progress4()
        {
            InitializeComponent();
        }

        private void buttonTest1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                return;
            }
            else
            {
                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = Convert.ToInt32(textBox2.Text);
                output("進度條開始");
                timer1.Enabled = true;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                output("進度條暫停");
                buttonPause.Text = "繼續";
                timer1.Enabled = false;
            }
            else
            {
                output("進度條繼續");
                buttonPause.Text = "暫停";
                timer1.Enabled = true;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            output("進度條停止");
            timer1.Enabled = false;
            progressBar1.Value = 0;
        }

        private void output(string log)
        {
            if (textBox3.GetLineFromCharIndex(textBox3.Text.Length) < 100)
            {
                textBox3.Text = "";
                textBox3.AppendText(DateTime.Now.ToString("HH:mm:ss") + log + "\r\n");
                Console.Write(textBox3.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                output("進度運行中（" + progressBar1.Value.ToString() + "/" + progressBar1.Maximum + ")...");
            }
            else
            {
                output("進度已完成");
                timer1.Enabled = false;
            }
        }
    }
}