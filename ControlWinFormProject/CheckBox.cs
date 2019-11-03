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
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            double unit;

            unit = radioButton自強.Checked == true ? 2.27 : (radioButton莒光.Checked == true ? 1.75 : 1.46);
            int km = Convert.ToInt32(textBoxKM.Text);
            double money = unit * km;
            if (checkBox1.Checked == true) money /= 2;
            if (checkBox2.Checked == true) money *= 1.8;
            textBoxOutput.Text = "票價: NT" + money.ToString("F0") + " 元";
        }

        private void CheckBox_Load(object sender, EventArgs e)
        {
            radioButton自強.Checked = true;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}