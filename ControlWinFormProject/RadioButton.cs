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
    public partial class RadioButton : Form
    {
        public RadioButton()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(textBox1.Text);
            double a = Convert.ToDouble(textBox2.Text);
            double total = Convert.ToDouble(money * a);
            double total1 = Convert.ToDouble(money / a);

            if (radioButton1.Checked == true)
            {
                labelMessage.Text = "台幣 " + money + " 元 可兌換成 美金 " + total1.ToString("#0.00") + " 元";
            }
            else
            {
                labelMessage.Text = "美金 " + money + " 元 可兌換成台幣  " + total.ToString() + " 元";
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}