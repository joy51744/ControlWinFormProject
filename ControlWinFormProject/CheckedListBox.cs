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
    public partial class CheckedListBox : Form
    {
        public CheckedListBox()
        {
            InitializeComponent();
        }

        int[] pcLot = new int[6];

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();

        }

        private void buttonCheckLot_Click(object sender, EventArgs e)
        {
            int count = 0;

            for(int i =0; i < checkedListBoxLot.Items.Count;i++)
            {
                if(checkedListBoxLot.GetItemChecked(i))
                {
                    count++;
                }
            }

            if(count !=6)
            {
                MessageBox.Show("請選擇6個號碼");
                return;
            }

            //呼叫SetLot方法,產生本期大樂透6個號碼並放式pcLot陣列內
            SetLot(ref pcLot, 1, 49, pcLot.Length);
            //將pcLot陣列內的大樂透號碼進行遞增排序,以方便比對是否中獎
            Array.Sort(pcLot);
            //myNumStr存放使用者所選的號碼,pcNumStr存放本期樂透號碼
            string myNumStr = "", pcNumStr = "";
            //將本期大樂透號碼逐一指定pcNumStr字串變數
            //以便將來和使用者所選號碼myNumStr比對
            for (int i =0; i <= pcLot.GetUpperBound(0); i++)
            {
                pcNumStr += pcLot[i].ToString() + ", ";
            }
            //將使用者在核取方塊所選號碼逐一指定myNumStr
            //以便將來和使用者所選號碼pcNumStr比對
            for(int i =0; i <checkedListBoxLot.Items.Count; i++)
            {
                if (checkedListBoxLot.GetItemChecked(i))
                {
                    myNumStr += checkedListBoxLot.Items[i].ToString() + ", ";
                }
            }
            labelShow.Text = "本期大樂透號碼如下\n" + pcNumStr + "\n";
            //判斷是否中獎
            if(pcNumStr == myNumStr)
            {
                labelShow.Text += "恭喜你中獎了..";
            }
            else
            {
                labelShow.Text = "對不起,你失敗了,再接再厲..";
            }
        }

        private void SetLot(ref int[] choose, int min, int max, int num)
        {
            int[] lot = new int[50];
            int max_dim, choice;
            int i, j;
            max_dim = max - min + 1;
            for(i =0; i <max_dim; i++)
            {
                lot[i] = min + i;
            }
            Random random = new Random();
            for (i = 0; i < num; i++)
            {
                choice = random.Next(0, max_dim);
                choose[i] = lot[choice];
                for(j = choice; j <max_dim; j++)
                {
                    lot[j] = lot[j + 1];
                }
                max_dim--;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            for(int i =0; i <checkedListBoxLot.Items.Count;i++)
            {
                checkedListBoxLot.SetItemChecked(i, false);
            }
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();
        }

        private void CheckedListBox_Load(object sender, EventArgs e)
        {
            checkedListBoxLot.MultiColumn = true;
            checkedListBoxLot.ColumnWidth = 45;
            
            //在checkedlistbox核取清單加入1-49大樂透號碼,可供使用者勾選
            for(int i=1; i<=49;i++)
            {
                checkedListBoxLot.Items.Add(i.ToString());
            }
            labelShow.Text = "本期未開獎...請耐心等候";
        }
    }
}
