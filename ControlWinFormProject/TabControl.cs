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
    public partial class TabControl : Form
    {
        public TabControl()
        {
            InitializeComponent();
        }

        class Employee
        {
            public string EmpID { get; set; }
            public string EmpName { get; set; }
            public string EmpSex { get; set; }
            public bool EmpIsMarry { get; set; }
        }
        List<Employee> employees = new List<Employee>();

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ControlMainForm main = new ControlMainForm();
            this.Visible = false;
            main.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string sex = "";
            if(radioButtonM.Checked == true)
            {
                sex = "先生";
            }
            else
            {
                sex = "小姐";
            }

            employees.Add(new Employee()
            {
                EmpID = textBoxID.Text,
                EmpName = textBoxName.Text,
                EmpSex = sex,
                EmpIsMarry = checkBoxMarried.Checked
            });
            MessageBox.Show("新增成功");

            textBoxID.Text = "";
            textBoxName.Text = "";
            radioButtonF.Checked = true;
            checkBoxMarried.Checked = false;
        }

        private void TabControl_Load(object sender, EventArgs e)
        {
            textBoxShow.Dock = DockStyle.Fill;

            textBoxShow.Font = new Font(textBoxShow.Font.FontFamily, 11, FontStyle.Regular);
            textBoxShow.ReadOnly = true;
            textBoxShow.Multiline = true;
            radioButtonF.Checked = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                textBoxShow.Text = "編號\t姓名\t性別\t是否已婚" +
                    Environment.NewLine;
                textBoxShow.Text += "=============================" +
                    Environment.NewLine;

                for(int i=0; i <employees.Count; i++)
                {
                    textBoxShow.Text += employees[i].EmpID + "\t" +
                        employees[i].EmpName + " \t" +
                        employees[i].EmpSex + " \t" +
                        employees[i].EmpIsMarry.ToString() +
                        Environment.NewLine;
                }
            }
        }
    }
}