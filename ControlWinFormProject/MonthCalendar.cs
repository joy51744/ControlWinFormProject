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
    public partial class MonthCalendar : Form
    {
        public MonthCalendar()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();
        }

        private void MonthCalendar_Load(object sender, EventArgs e)
        {
            string[] Product = new string[] { "海賊王", "小叮噹", "史瑞克", "鋼鐵人", "葉問", "第一次愛上你", "時間旅途者", "阿凡達", "哥吉拉", "松藥局的兒子們", "紙牌屋", "蝴蝶效應", "烏龍派出所" };

            checkedListBox1.Items.AddRange(Product);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.ColumnWidth = 150;
            monthCalendar1.MinDate = DateTime.Now;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            textBox1.Text = "訂購產品如下: " +
                Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    textBox1.Text += "   ." +
                        checkedListBox1.Items[i].ToString() + Environment.NewLine;
                }
            }
            textBox1.Text += Environment.NewLine + "訂購人: " + textBoxName.Text + Environment.NewLine + "指定送貨日為: " + monthCalendar1.SelectionRange.Start.ToShortDateString() + "至 " + monthCalendar1.SelectionRange.End.ToShortDateString() + " 送達指定地點" + textBoxAddress.Text;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            textBox1.Text = "";
        }
    }
}