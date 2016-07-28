using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexTester
{
    public partial class MainWindow : Form
    {
        public string appDirectory = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            CheckRegex();
            btnCheck.Visible = !cbAutoCheck.Checked;

        }

        private void tbRegex_TextChanged(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
            if(cbAutoCheck.Checked)
                CheckRegex();
        }

        private void tbText2Test_TextChanged(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
            if (cbAutoCheck.Checked)
                CheckRegex();
        }

        private void checxBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckRegex();
        }

        private void cbAutoCheck_CheckedChanged(object sender, EventArgs e)
        {
            btnCheck.Visible = !cbAutoCheck.Checked;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckRegex();
        }

        private void CheckRegex()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string pattern = tbRegex.Text;
                string content = tbText2Test.Text;

                int oldStart = tbText2Test.SelectionStart;
                int oldLen = tbText2Test.SelectionLength;

                tbText2Test.SelectionStart = 0;
                tbText2Test.SelectionLength = content.Length;
                tbText2Test.SelectionColor = Color.Black;
                tbText2Test.SelectionBackColor = Color.White;

                tsslTime.Text = String.Empty;

                if (!String.IsNullOrEmpty(pattern))
                {
                    RegexOptions ro = RegexOptions.None;
                    if (cbIgnoreCase.Checked)
                        ro |= RegexOptions.IgnoreCase;
                    if (cbSingleLine.Checked)
                        ro |= RegexOptions.Singleline;
                    if (cbMultiLine.Checked)
                        ro |= RegexOptions.Multiline;
                    if (cbRightToLeft.Checked)
                        ro |= RegexOptions.RightToLeft;

                    DateTime start = DateTime.UtcNow;
                    MatchCollection matches = Regex.Matches(content, pattern, ro);
                    DateTime end = DateTime.UtcNow;

                    tsslNomatches.Text = matches.Count + " matches";
                    
                    TimeSpan duration = end - start;
                    if (duration.TotalMilliseconds > 0.0)
                        tsslTime.Text = String.Format("{0:0.000}mSec", duration.TotalMilliseconds);

                    foreach (Match match in matches)
                    {
                        foreach (Capture capture in match.Captures)
                        {
                            //System.Diagnostics.Debug.WriteLine(String.Format("Index={0}, Value={1}", capture.Index, capture.Value));

                            tbText2Test.SelectionStart = capture.Index;
                            tbText2Test.SelectionLength = capture.Value.Length;
                            tbText2Test.SelectionColor = Color.Yellow;
                            tbText2Test.SelectionBackColor = Color.Red;
                        }
                    }
                }
                else
                    tsslNomatches.Text = "No regular expression specified";

                tbText2Test.SelectionStart = oldStart;
                tbText2Test.SelectionLength = oldLen;
                tbRegex.ForeColor = Color.Black;
                btnCheck.Enabled = false;
            }
            catch (Exception ex)
            {
                tbRegex.ForeColor = Color.Red;
                tsslNomatches.Text = ex.Message;
            }

            Cursor.Current = Cursors.Default;
        }

    }
}