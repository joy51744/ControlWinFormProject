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
    public partial class ComboBoxControl : Form
    {
        public ComboBoxControl()
        {
            InitializeComponent();
        }

        private string[] singer = new string[] { "孫燕姿,梁靜茹,蔡健雅,郭靜,黃小琥" };
        private string[] message = new string[] { "孫燕姿 --- Radio , 梁靜茹 --- 可以的話 ,蔡健雅 --- 失語者,郭靜 --- 可惜,黃小琥 --- 心酸的成熟" };
        int[] votes = new int[6];

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();
        }

        private void buttonVote_Click(object sender, EventArgs e)
        {
            votes[comboBox1.SelectedIndex] += 1;
            listBoxVote.Items.Clear();
            for(int i=0;i<singer.Length;i++)
            {
                listBoxVote.Items.Add(singer[i] + "\t" + votes[i] + "票");
            }
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(singer);
            for(int i=0; i<singer.Length;i++)
            {
                listBoxVote.Items.Add(singer[i] + "\t" + votes[i] + "票");
            }
            comboBox1.SelectedItem = singer[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMessage.Text = message[comboBox1.SelectedIndex];
        }
    }
}