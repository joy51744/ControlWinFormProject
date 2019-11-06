namespace ControlWinFormProject
{
    partial class CheckedListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.checkedListBoxLot = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.buttonCheckLot = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
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
            this.toolStrip1.Size = new System.Drawing.Size(409, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "離開";
            this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
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
            // checkedListBoxLot
            // 
            this.checkedListBoxLot.CheckOnClick = true;
            this.checkedListBoxLot.FormattingEnabled = true;
            this.checkedListBoxLot.Location = new System.Drawing.Point(12, 67);
            this.checkedListBoxLot.Name = "checkedListBoxLot";
            this.checkedListBoxLot.Size = new System.Drawing.Size(385, 157);
            this.checkedListBoxLot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "大樂透 -- 請選擇6個號碼";
            // 
            // labelShow
            // 
            this.labelShow.Location = new System.Drawing.Point(12, 247);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(385, 139);
            this.labelShow.TabIndex = 4;
            // 
            // buttonCheckLot
            // 
            this.buttonCheckLot.Location = new System.Drawing.Point(12, 406);
            this.buttonCheckLot.Name = "buttonCheckLot";
            this.buttonCheckLot.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckLot.TabIndex = 5;
            this.buttonCheckLot.Text = "兌獎";
            this.buttonCheckLot.UseVisualStyleBackColor = true;
            this.buttonCheckLot.Click += new System.EventHandler(this.buttonCheckLot_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(167, 406);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "清除";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(322, 406);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonEnd.TabIndex = 7;
            this.buttonEnd.Text = "結束";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 441);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCheckLot);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxLot);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CheckedListBox";
            this.Text = "C#控制項專案 | 大樂透";
            this.Load += new System.EventHandler(this.CheckedListBox_Load);
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
        private System.Windows.Forms.CheckedListBox checkedListBoxLot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Button buttonCheckLot;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEnd;
    }
}