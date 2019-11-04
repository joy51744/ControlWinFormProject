namespace ControlWinFormProject
{
    partial class NumericUpDown
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.radioButtonPlus = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtract = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiply = new System.Windows.Forms.RadioButton();
            this.radioButtonDivide = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(377, 25);
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(84, 83);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(189, 83);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(290, 89);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 12);
            this.labelOutput.TabIndex = 6;
            // 
            // radioButtonPlus
            // 
            this.radioButtonPlus.AutoSize = true;
            this.radioButtonPlus.Location = new System.Drawing.Point(152, 56);
            this.radioButtonPlus.Name = "radioButtonPlus";
            this.radioButtonPlus.Size = new System.Drawing.Size(29, 16);
            this.radioButtonPlus.TabIndex = 7;
            this.radioButtonPlus.TabStop = true;
            this.radioButtonPlus.Text = "+";
            this.radioButtonPlus.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtract
            // 
            this.radioButtonSubtract.AutoSize = true;
            this.radioButtonSubtract.Location = new System.Drawing.Point(152, 85);
            this.radioButtonSubtract.Name = "radioButtonSubtract";
            this.radioButtonSubtract.Size = new System.Drawing.Size(27, 16);
            this.radioButtonSubtract.TabIndex = 8;
            this.radioButtonSubtract.TabStop = true;
            this.radioButtonSubtract.Text = "-";
            this.radioButtonSubtract.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiply
            // 
            this.radioButtonMultiply.AutoSize = true;
            this.radioButtonMultiply.Location = new System.Drawing.Point(152, 114);
            this.radioButtonMultiply.Name = "radioButtonMultiply";
            this.radioButtonMultiply.Size = new System.Drawing.Size(29, 16);
            this.radioButtonMultiply.TabIndex = 9;
            this.radioButtonMultiply.TabStop = true;
            this.radioButtonMultiply.Text = "*";
            this.radioButtonMultiply.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivide
            // 
            this.radioButtonDivide.AutoSize = true;
            this.radioButtonDivide.Location = new System.Drawing.Point(152, 143);
            this.radioButtonDivide.Name = "radioButtonDivide";
            this.radioButtonDivide.Size = new System.Drawing.Size(26, 16);
            this.radioButtonDivide.TabIndex = 10;
            this.radioButtonDivide.TabStop = true;
            this.radioButtonDivide.Text = "/";
            this.radioButtonDivide.UseVisualStyleBackColor = true;
            // 
            // NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 215);
            this.Controls.Add(this.radioButtonDivide);
            this.Controls.Add(this.radioButtonMultiply);
            this.Controls.Add(this.radioButtonSubtract);
            this.Controls.Add(this.radioButtonPlus);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "NumericUpDown";
            this.Text = "C#控制項專案 | 小數點相加";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.RadioButton radioButtonPlus;
        private System.Windows.Forms.RadioButton radioButtonSubtract;
        private System.Windows.Forms.RadioButton radioButtonMultiply;
        private System.Windows.Forms.RadioButton radioButtonDivide;
    }
}