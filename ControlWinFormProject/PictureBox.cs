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
    public partial class PictureBox : Form
    {
        string[] secRed = new string[60];  //宣告紅燈秒數
        string[] secYellow = new string[2];  //宣告黃燈秒數       
        string[] secGreen = new string[60];  //宣告綠燈秒數
        int t = 0;  //宣告紅綠燈計算秒數
        public PictureBox()
        {
            InitializeComponent();
        }

        private void PictureBox_Load(object sender, EventArgs e)
        {
            //畫面執行時所產生的事件
            pictureBoxRed.Image = Page1.White;
            pictureBoxYellow.Image = Page1.White;
            pictureBoxGreen.Image = Page1.White;
            timer1.Enabled = false;
            timer1.Interval = 1000;
            labelSec.Enabled = false;

            for (int i = 0; i < secGreen.Length; i++)
            {
                if (i > (secGreen.Length - 10))
                {
                    secGreen[i] = "0" + (secGreen.Length - i).ToString();
                }
                else
                {
                    secGreen[i] = (secGreen.Length - i).ToString();
                }
            }

            for (int i = 0; i < secYellow.Length; i++)
            {
                secYellow[i] = "88";  //黃燈時不顯示秒數
            }

            for (int i = 0; i < secRed.Length; i++)
            {
                if (i > (secRed.Length - 10))
                {
                    secRed[i] = "0" + (secRed.Length - i).ToString();
                }
                else
                {
                    secRed[i] = (secRed.Length - i).ToString();
                }
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //按下"Start"按鈕時所產生的事件
            if (buttonStart.Text == "開始")
            {
                timer1.Enabled = true;
                buttonStart.Text = "暫停";
            }
            else if (buttonStart.Text == "暫停")
            {
                timer1.Enabled = false;
                buttonStart.Text = "開始";
            }
        }

        private void ButtonEnd_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Timer1觸發所產生的事件
            t += 1;
            if (t >= 1 && t <= secGreen.Length)
            {
                labelSec.Enabled = true;
                labelSec.Text = secGreen[t - 1];
                labelSec.ForeColor = System.Drawing.Color.Green;
                pictureBoxRed.Image = Page1.White;
                pictureBoxYellow.Image = Page1.White;
                pictureBoxGreen.Image = Page1.Green;
            }
            else if (t >= (secGreen.Length + 1) && t <= (secGreen.Length + secYellow.Length))
            {
                labelSec.Enabled = false;
                labelSec.Text = secYellow[t - (secGreen.Length + 1)];
                pictureBoxRed.Image = Page1.White;
                pictureBoxYellow.Image = Page1.Yellow;
                pictureBoxGreen.Image = Page1.White;
            }
            else if (t >= (secGreen.Length + secYellow.Length + 1) && t <= (secGreen.Length + secYellow.Length + secRed.Length))
            {
                labelSec.Enabled = true;
                labelSec.Text = secRed[t - (secGreen.Length + secYellow.Length + 1)];
                labelSec.ForeColor = System.Drawing.Color.Red;
                pictureBoxRed.Image = Page1.Red;
                pictureBoxYellow.Image = Page1.White;
                pictureBoxGreen.Image = Page1.White;
                if (t == (secGreen.Length + secYellow.Length + secRed.Length))
                {
                    t = 0;
                }
            }
        }
    }
}
