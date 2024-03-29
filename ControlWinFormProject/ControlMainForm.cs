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
    public partial class ControlMainForm : Form
    {
        public ControlMainForm()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("PortfolioMainForm.exe");
            this.Visible = false;
        }

        private void buttonProgress_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            this.Visible = false;
            progress.Show();
        }

        private void buttonCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = new CheckBox();
            this.Visible = false;
            checkBox.Show();
        }

        private void buttonCheckedListBox_Click(object sender, EventArgs e)
        {
            CheckedListBox checkedListBox = new CheckedListBox();
            this.Visible = false;
            checkedListBox.Show();
        }

        private void buttonRadioButton_Click(object sender, EventArgs e)
        {
            RadioButton radio = new RadioButton();
            this.Visible = false;
            radio.Show();
        }

        private void buttonComboBox_Click(object sender, EventArgs e)
        {
            ComboBoxControl comboBox = new ComboBoxControl();
            this.Visible = false;
            comboBox.Show();
        }

        private void buttonListBox_Click(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();
            this.Visible = false;
            listBox.Show();
        }

        private void buttonPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = new PictureBox();
            this.Visible = false;
            picture.Show();
        }

        private void buttonTrackBar_Click(object sender, EventArgs e)
        {
            TrackBar trackBar = new TrackBar();
            this.Visible = false;
            trackBar.Show();
        }

        private void buttonMenuStrip_Click(object sender, EventArgs e)
        {
            MenuStrip menuStrip = new MenuStrip();
            this.Visible = false;
            menuStrip.Show();
        }

        private void buttonStatusStrip_Click(object sender, EventArgs e)
        {
        }

        private void buttonDateTimePicker_Click(object sender, EventArgs e)
        {
        }

        private void buttonNumericUpDown_Click(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            this.Visible = false;
            numericUpDown.Show();
        }

        private void buttonFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            this.Visible = false;
            fontDialog.Show();
        }
    }
}