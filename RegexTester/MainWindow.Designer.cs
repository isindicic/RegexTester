namespace RegexTester
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
            this.rtbText2Test = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslNomatches = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbIgnoreCase = new System.Windows.Forms.CheckBox();
            this.cbSingleLine = new System.Windows.Forms.CheckBox();
            this.cbMultiLine = new System.Windows.Forms.CheckBox();
            this.cbRightToLeft = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 13);
            label1.TabIndex = 3;
            label1.Text = "Regular expression:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 51);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 3;
            label2.Text = "Text to test:";
            // 
            // tbRegex
            // 
            this.tbRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegex.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRegex.Location = new System.Drawing.Point(12, 25);
            this.tbRegex.Name = "tbRegex";
            this.tbRegex.Size = new System.Drawing.Size(661, 23);
            this.tbRegex.TabIndex = 0;
            this.tbRegex.TextChanged += new System.EventHandler(this.tbRegex_TextChanged);
            // 
            // rtbText2Test
            // 
            this.rtbText2Test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText2Test.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbText2Test.Location = new System.Drawing.Point(12, 67);
            this.rtbText2Test.Name = "rtbText2Test";
            this.rtbText2Test.Size = new System.Drawing.Size(524, 267);
            this.rtbText2Test.TabIndex = 1;
            this.rtbText2Test.Text = "";
            this.rtbText2Test.WordWrap = false;
            this.rtbText2Test.TextChanged += new System.EventHandler(this.rtbText2Test_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNomatches});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(690, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslNomatches
            // 
            this.tsslNomatches.Name = "tsslNomatches";
            this.tsslNomatches.Size = new System.Drawing.Size(60, 17);
            this.tsslNomatches.Text = "? matches";
            // 
            // cbIgnoreCase
            // 
            this.cbIgnoreCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIgnoreCase.AutoSize = true;
            this.cbIgnoreCase.Location = new System.Drawing.Point(562, 70);
            this.cbIgnoreCase.Name = "cbIgnoreCase";
            this.cbIgnoreCase.Size = new System.Drawing.Size(82, 17);
            this.cbIgnoreCase.TabIndex = 4;
            this.cbIgnoreCase.Text = "Ignore case";
            this.cbIgnoreCase.UseVisualStyleBackColor = true;
            this.cbIgnoreCase.CheckedChanged += new System.EventHandler(this.checxBox_CheckedChanged);
            // 
            // cbSingleLine
            // 
            this.cbSingleLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSingleLine.AutoSize = true;
            this.cbSingleLine.Location = new System.Drawing.Point(562, 93);
            this.cbSingleLine.Name = "cbSingleLine";
            this.cbSingleLine.Size = new System.Drawing.Size(74, 17);
            this.cbSingleLine.TabIndex = 4;
            this.cbSingleLine.Text = "Single line";
            this.cbSingleLine.UseVisualStyleBackColor = true;
            this.cbSingleLine.CheckedChanged += new System.EventHandler(this.checxBox_CheckedChanged);
            // 
            // cbMultiLine
            // 
            this.cbMultiLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMultiLine.AutoSize = true;
            this.cbMultiLine.Location = new System.Drawing.Point(562, 116);
            this.cbMultiLine.Name = "cbMultiLine";
            this.cbMultiLine.Size = new System.Drawing.Size(64, 17);
            this.cbMultiLine.TabIndex = 4;
            this.cbMultiLine.Text = "Multiline";
            this.cbMultiLine.UseVisualStyleBackColor = true;
            this.cbMultiLine.CheckedChanged += new System.EventHandler(this.checxBox_CheckedChanged);
            // 
            // cbRightToLeft
            // 
            this.cbRightToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRightToLeft.AutoSize = true;
            this.cbRightToLeft.Location = new System.Drawing.Point(562, 139);
            this.cbRightToLeft.Name = "cbRightToLeft";
            this.cbRightToLeft.Size = new System.Drawing.Size(80, 17);
            this.cbRightToLeft.TabIndex = 4;
            this.cbRightToLeft.Text = "Right to left";
            this.cbRightToLeft.UseVisualStyleBackColor = true;
            this.cbRightToLeft.CheckedChanged += new System.EventHandler(this.checxBox_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 368);
            this.Controls.Add(this.cbRightToLeft);
            this.Controls.Add(this.cbMultiLine);
            this.Controls.Add(this.cbSingleLine);
            this.Controls.Add(this.cbIgnoreCase);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtbText2Test);
            this.Controls.Add(this.tbRegex);
            this.Name = "MainWindow";
            this.Text = "Simple .NET RegEx Tester";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRegex;
        private System.Windows.Forms.RichTextBox rtbText2Test;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslNomatches;
        private System.Windows.Forms.CheckBox cbIgnoreCase;
        private System.Windows.Forms.CheckBox cbSingleLine;
        private System.Windows.Forms.CheckBox cbMultiLine;
        private System.Windows.Forms.CheckBox cbRightToLeft;
    }
}

