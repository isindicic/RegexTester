namespace SindaSoft.RegexTester
{
    partial class MainWindow
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.tbRegex = new System.Windows.Forms.TextBox();
            this.tbText2Test = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslNomatches = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbIgnoreCase = new System.Windows.Forms.CheckBox();
            this.cbSingleLine = new System.Windows.Forms.CheckBox();
            this.cbMultiLine = new System.Windows.Forms.CheckBox();
            this.cbRightToLeft = new System.Windows.Forms.CheckBox();
            this.cbAutoCheck = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 11);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 17);
            label1.TabIndex = 3;
            label1.Text = "Regular expression:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 63);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 17);
            label2.TabIndex = 3;
            label2.Text = "Text to test:";
            // 
            // tbRegex
            // 
            this.tbRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegex.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRegex.Location = new System.Drawing.Point(16, 31);
            this.tbRegex.Margin = new System.Windows.Forms.Padding(4);
            this.tbRegex.Name = "tbRegex";
            this.tbRegex.Size = new System.Drawing.Size(721, 27);
            this.tbRegex.TabIndex = 0;
            this.tbRegex.TextChanged += new System.EventHandler(this.tbRegex_TextChanged);
            // 
            // tbText2Test
            // 
            this.tbText2Test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText2Test.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbText2Test.Location = new System.Drawing.Point(16, 82);
            this.tbText2Test.Margin = new System.Windows.Forms.Padding(4);
            this.tbText2Test.Name = "tbText2Test";
            this.tbText2Test.Size = new System.Drawing.Size(721, 337);
            this.tbText2Test.TabIndex = 1;
            this.tbText2Test.Text = "";
            this.tbText2Test.WordWrap = false;
            this.tbText2Test.TextChanged += new System.EventHandler(this.tbText2Test_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNomatches,
            this.tsslTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(944, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslNomatches
            // 
            this.tsslNomatches.Name = "tsslNomatches";
            this.tsslNomatches.Size = new System.Drawing.Size(75, 20);
            this.tsslNomatches.Text = "? matches";
            // 
            // tsslTime
            // 
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(0, 20);
            // 
            // cbIgnoreCase
            // 
            this.cbIgnoreCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIgnoreCase.Location = new System.Drawing.Point(760, 305);
            this.cbIgnoreCase.Margin = new System.Windows.Forms.Padding(4);
            this.cbIgnoreCase.Name = "cbIgnoreCase";
            this.cbIgnoreCase.Size = new System.Drawing.Size(154, 21);
            this.cbIgnoreCase.TabIndex = 4;
            this.cbIgnoreCase.Text = "Ignore case";
            this.cbIgnoreCase.UseVisualStyleBackColor = true;
            this.cbIgnoreCase.CheckedChanged += new System.EventHandler(this.checxBox_CheckedChanged);
            // 
            // cbSingleLine
            // 
            this.cbSingleLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSingleLine.Location = new System.Drawing.Point(760, 336);
            this.cbSingleLine.Margin = new System.Windows.Forms.Padding(4);
            this.cbSingleLine.Name = "cbSingleLine";
            this.cbSingleLine.Size = new System.Drawing.Size(154, 21);
            this.cbSingleLine.TabIndex = 4;
            this.cbSingleLine.Text = "Single line";
            this.cbSingleLine.UseVisualStyleBackColor = true;
            this.cbSingleLine.CheckedChanged += new System.EventHandler(this.checxBox_CheckedChanged);
            // 
            // cbMultiLine
            // 
            this.cbMultiLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMultiLine.Location = new System.Drawing.Point(760, 367);
            this.cbMultiLine.Margin = new System.Windows.Forms.Padding(4);
            this.cbMultiLine.Name = "cbMultiLine";
            this.cbMultiLine.Size = new System.Drawing.Size(154, 21);
            this.cbMultiLine.TabIndex = 4;
            this.cbMultiLine.Text = "Multiline";
            this.cbMultiLine.UseVisualStyleBackColor = true;
            this.cbMultiLine.CheckedChanged += new System.EventHandler(this.checxBox_CheckedChanged);
            // 
            // cbRightToLeft
            // 
            this.cbRightToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRightToLeft.Location = new System.Drawing.Point(760, 398);
            this.cbRightToLeft.Margin = new System.Windows.Forms.Padding(4);
            this.cbRightToLeft.Name = "cbRightToLeft";
            this.cbRightToLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbRightToLeft.Size = new System.Drawing.Size(154, 21);
            this.cbRightToLeft.TabIndex = 4;
            this.cbRightToLeft.Text = "Right to left";
            this.cbRightToLeft.UseVisualStyleBackColor = true;
            this.cbRightToLeft.CheckedChanged += new System.EventHandler(this.checxBox_CheckedChanged);
            // 
            // cbAutoCheck
            // 
            this.cbAutoCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoCheck.Location = new System.Drawing.Point(760, 84);
            this.cbAutoCheck.Margin = new System.Windows.Forms.Padding(4);
            this.cbAutoCheck.Name = "cbAutoCheck";
            this.cbAutoCheck.Size = new System.Drawing.Size(154, 21);
            this.cbAutoCheck.TabIndex = 4;
            this.cbAutoCheck.Text = "Check as you type";
            this.cbAutoCheck.UseVisualStyleBackColor = true;
            this.cbAutoCheck.CheckedChanged += new System.EventHandler(this.cbAutoCheck_CheckedChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Location = new System.Drawing.Point(760, 31);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(137, 27);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 462);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.cbAutoCheck);
            this.Controls.Add(this.cbRightToLeft);
            this.Controls.Add(this.cbMultiLine);
            this.Controls.Add(this.cbSingleLine);
            this.Controls.Add(this.cbIgnoreCase);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbText2Test);
            this.Controls.Add(this.tbRegex);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Simple .NET RegEx Tester";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRegex;
        private System.Windows.Forms.RichTextBox tbText2Test;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslNomatches;
        private System.Windows.Forms.CheckBox cbIgnoreCase;
        private System.Windows.Forms.CheckBox cbSingleLine;
        private System.Windows.Forms.CheckBox cbMultiLine;
        private System.Windows.Forms.CheckBox cbRightToLeft;
        private System.Windows.Forms.CheckBox cbAutoCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
    }
}

