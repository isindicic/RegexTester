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
        public MainWindow()
        {
            InitializeComponent();
            CheckRegex();
        }

        private void tbRegex_TextChanged(object sender, EventArgs e)
        {
            CheckRegex();
        }

        private void rtbText2Test_TextChanged(object sender, EventArgs e)
        {
            CheckRegex();
        }

        private void checxBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckRegex();
        }

        private void CheckRegex()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string pattern = tbRegex.Text;
                string content = rtbText2Test.Text;

                int oldStart = rtbText2Test.SelectionStart;
                int oldLen = rtbText2Test.SelectionLength;

                rtbText2Test.SelectionStart = 0;
                rtbText2Test.SelectionLength = content.Length;
                rtbText2Test.SelectionColor = Color.Black;
                rtbText2Test.SelectionBackColor = Color.White;


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

                    MatchCollection matches = Regex.Matches(content, pattern, ro);
                    tsslNomatches.Text = matches.Count + " matches";

                    foreach (Match match in matches)
                    {
                        foreach (Capture capture in match.Captures)
                        {
                            //System.Diagnostics.Debug.WriteLine(String.Format("Index={0}, Value={1}", capture.Index, capture.Value));

                            rtbText2Test.SelectionStart = capture.Index;
                            rtbText2Test.SelectionLength = capture.Value.Length;
                            rtbText2Test.SelectionColor = Color.Yellow;
                            rtbText2Test.SelectionBackColor = Color.Red;

                        }
                    }
                }
                else
                    tsslNomatches.Text = "No regular expression specified";

                rtbText2Test.SelectionStart = oldStart;
                rtbText2Test.SelectionLength = oldLen;
                tbRegex.ForeColor = Color.Black;
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