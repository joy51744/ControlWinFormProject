namespace ControlWinFormProject
{
    partial class ControlMainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonNumericUpDown = new System.Windows.Forms.Button();
            this.buttonToolTip = new System.Windows.Forms.Button();
            this.buttonComboBox = new System.Windows.Forms.Button();
            this.buttonCheckBox = new System.Windows.Forms.Button();
            this.buttonFontDialog = new System.Windows.Forms.Button();
            this.buttonScrollBar = new System.Windows.Forms.Button();
            this.buttonListBox = new System.Windows.Forms.Button();
            this.buttonCheckedListBox = new System.Windows.Forms.Button();
            this.buttonTrackBar = new System.Windows.Forms.Button();
            this.buttonPictureBox = new System.Windows.Forms.Button();
            this.buttonRadioButton = new System.Windows.Forms.Button();
            this.buttonProgress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "離開";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonNumericUpDown
            // 
            this.buttonNumericUpDown.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonNumericUpDown.Location = new System.Drawing.Point(644, 232);
            this.buttonNumericUpDown.Name = "buttonNumericUpDown";
            this.buttonNumericUpDown.Size = new System.Drawing.Size(130, 45);
            this.buttonNumericUpDown.TabIndex = 11;
            this.buttonNumericUpDown.Text = "簡易加減乘除";
            this.buttonNumericUpDown.UseVisualStyleBackColor = true;
            this.buttonNumericUpDown.Click += new System.EventHandler(this.buttonNumericUpDown_Click);
            // 
            // buttonToolTip
            // 
            this.buttonToolTip.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonToolTip.Location = new System.Drawing.Point(438, 232);
            this.buttonToolTip.Name = "buttonToolTip";
            this.buttonToolTip.Size = new System.Drawing.Size(130, 45);
            this.buttonToolTip.TabIndex = 8;
            this.buttonToolTip.Text = "提示小工具";
            this.buttonToolTip.UseVisualStyleBackColor = true;
            this.buttonToolTip.Click += new System.EventHandler(this.buttonToolTip_Click);
            // 
            // buttonComboBox
            // 
            this.buttonComboBox.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonComboBox.Location = new System.Drawing.Point(232, 232);
            this.buttonComboBox.Name = "buttonComboBox";
            this.buttonComboBox.Size = new System.Drawing.Size(130, 45);
            this.buttonComboBox.TabIndex = 5;
            this.buttonComboBox.Text = "簡易投票";
            this.buttonComboBox.UseVisualStyleBackColor = true;
            this.buttonComboBox.Click += new System.EventHandler(this.buttonComboBox_Click);
            // 
            // buttonCheckBox
            // 
            this.buttonCheckBox.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCheckBox.Location = new System.Drawing.Point(26, 232);
            this.buttonCheckBox.Name = "buttonCheckBox";
            this.buttonCheckBox.Size = new System.Drawing.Size(130, 45);
            this.buttonCheckBox.TabIndex = 2;
            this.buttonCheckBox.Text = "火車票價試算";
            this.buttonCheckBox.UseVisualStyleBackColor = true;
            this.buttonCheckBox.Click += new System.EventHandler(this.buttonCheckBox_Click);
            // 
            // buttonFontDialog
            // 
            this.buttonFontDialog.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonFontDialog.Location = new System.Drawing.Point(644, 374);
            this.buttonFontDialog.Name = "buttonFontDialog";
            this.buttonFontDialog.Size = new System.Drawing.Size(130, 45);
            this.buttonFontDialog.TabIndex = 12;
            this.buttonFontDialog.Text = "字體對話框";
            this.buttonFontDialog.UseVisualStyleBackColor = true;
            this.buttonFontDialog.Click += new System.EventHandler(this.buttonFontDialog_Click);
            // 
            // buttonScrollBar
            // 
            this.buttonScrollBar.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonScrollBar.Location = new System.Drawing.Point(438, 374);
            this.buttonScrollBar.Name = "buttonScrollBar";
            this.buttonScrollBar.Size = new System.Drawing.Size(130, 45);
            this.buttonScrollBar.TabIndex = 9;
            this.buttonScrollBar.Text = "調整圖片大小";
            this.buttonScrollBar.UseVisualStyleBackColor = true;
            this.buttonScrollBar.Click += new System.EventHandler(this.buttonScrollBar_Click);
            // 
            // buttonListBox
            // 
            this.buttonListBox.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonListBox.Location = new System.Drawing.Point(232, 374);
            this.buttonListBox.Name = "buttonListBox";
            this.buttonListBox.Size = new System.Drawing.Size(130, 45);
            this.buttonListBox.TabIndex = 6;
            this.buttonListBox.Text = "農夫過河";
            this.buttonListBox.UseVisualStyleBackColor = true;
            this.buttonListBox.Click += new System.EventHandler(this.buttonListBox_Click);
            // 
            // buttonCheckedListBox
            // 
            this.buttonCheckedListBox.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCheckedListBox.Location = new System.Drawing.Point(26, 374);
            this.buttonCheckedListBox.Name = "buttonCheckedListBox";
            this.buttonCheckedListBox.Size = new System.Drawing.Size(130, 45);
            this.buttonCheckedListBox.TabIndex = 3;
            this.buttonCheckedListBox.Text = "商店下單系統";
            this.buttonCheckedListBox.UseVisualStyleBackColor = true;
            this.buttonCheckedListBox.Click += new System.EventHandler(this.buttonCheckedListBox_Click);
            // 
            // buttonTrackBar
            // 
            this.buttonTrackBar.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonTrackBar.Location = new System.Drawing.Point(644, 90);
            this.buttonTrackBar.Name = "buttonTrackBar";
            this.buttonTrackBar.Size = new System.Drawing.Size(130, 45);
            this.buttonTrackBar.TabIndex = 10;
            this.buttonTrackBar.Text = "調整字型大小";
            this.buttonTrackBar.UseVisualStyleBackColor = true;
            this.buttonTrackBar.Click += new System.EventHandler(this.buttonTrackBar_Click);
            // 
            // buttonPictureBox
            // 
            this.buttonPictureBox.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPictureBox.Location = new System.Drawing.Point(438, 90);
            this.buttonPictureBox.Name = "buttonPictureBox";
            this.buttonPictureBox.Size = new System.Drawing.Size(130, 45);
            this.buttonPictureBox.TabIndex = 7;
            this.buttonPictureBox.Text = "紅綠燈";
            this.buttonPictureBox.UseVisualStyleBackColor = true;
            this.buttonPictureBox.Click += new System.EventHandler(this.buttonPictureBox_Click);
            // 
            // buttonRadioButton
            // 
            this.buttonRadioButton.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRadioButton.Location = new System.Drawing.Point(232, 90);
            this.buttonRadioButton.Name = "buttonRadioButton";
            this.buttonRadioButton.Size = new System.Drawing.Size(130, 45);
            this.buttonRadioButton.TabIndex = 4;
            this.buttonRadioButton.Text = "簡易匯率換算";
            this.buttonRadioButton.UseVisualStyleBackColor = true;
            this.buttonRadioButton.Click += new System.EventHandler(this.buttonRadioButton_Click);
            // 
            // buttonProgress
            // 
            this.buttonProgress.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonProgress.Location = new System.Drawing.Point(26, 90);
            this.buttonProgress.Name = "buttonProgress";
            this.buttonProgress.Size = new System.Drawing.Size(130, 45);
            this.buttonProgress.TabIndex = 1;
            this.buttonProgress.Text = "進度條";
            this.buttonProgress.UseVisualStyleBackColor = true;
            this.buttonProgress.Click += new System.EventHandler(this.buttonProgress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label1.Location = new System.Drawing.Point(275, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 115;
            this.label1.Text = "C# Control Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 116;
            this.label2.Text = "ProgressBar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 117;
            this.label3.Text = "FontDialog";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 118;
            this.label4.Text = "PictureBox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 119;
            this.label5.Text = "RadioButton";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 12);
            this.label6.TabIndex = 120;
            this.label6.Text = "ComboBox";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 12);
            this.label7.TabIndex = 121;
            this.label7.Text = "ListBox";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 12);
            this.label8.TabIndex = 122;
            this.label8.Text = "CheckBox";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 12);
            this.label9.TabIndex = 123;
            this.label9.Text = "ToolTip";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 12);
            this.label10.TabIndex = 124;
            this.label10.Text = "ScrollBar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(642, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 12);
            this.label11.TabIndex = 125;
            this.label11.Text = "TrackBar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(642, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 12);
            this.label12.TabIndex = 126;
            this.label12.Text = "NumericUpDown";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 422);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 127;
            this.label13.Text = "CheckedListBox";
            // 
            // ControlMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonNumericUpDown);
            this.Controls.Add(this.buttonToolTip);
            this.Controls.Add(this.buttonComboBox);
            this.Controls.Add(this.buttonCheckBox);
            this.Controls.Add(this.buttonFontDialog);
            this.Controls.Add(this.buttonScrollBar);
            this.Controls.Add(this.buttonListBox);
            this.Controls.Add(this.buttonCheckedListBox);
            this.Controls.Add(this.buttonTrackBar);
            this.Controls.Add(this.buttonPictureBox);
            this.Controls.Add(this.buttonRadioButton);
            this.Controls.Add(this.buttonProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ControlMainForm";
            this.Text = "馬顥心 | C#控制項專案";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button buttonNumericUpDown;
        private System.Windows.Forms.Button buttonToolTip;
        private System.Windows.Forms.Button buttonComboBox;
        private System.Windows.Forms.Button buttonCheckBox;
        private System.Windows.Forms.Button buttonFontDialog;
        private System.Windows.Forms.Button buttonScrollBar;
        private System.Windows.Forms.Button buttonListBox;
        private System.Windows.Forms.Button buttonCheckedListBox;
        private System.Windows.Forms.Button buttonTrackBar;
        private System.Windows.Forms.Button buttonPictureBox;
        private System.Windows.Forms.Button buttonRadioButton;
        private System.Windows.Forms.Button buttonProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

