using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;
using System.IO;
using System.Threading;

namespace SindaSoft.RegexTester
{
    public partial class MainWindow : Form
    {
        private string settingsFile  = null;
        private Thread scanThread = null;
        private bool rescan_required = false;

        private string regex2test = null;
        private string text2test = null;

        public MainWindow()
        {
            InitializeComponent();

            UriBuilder uri = new UriBuilder(Assembly.GetExecutingAssembly().CodeBase);
            settingsFile = Uri.UnescapeDataString(uri.Path);
            settingsFile = Path.Combine(Path.GetDirectoryName(settingsFile) ,  "RegexTester.xml" );
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Settings s = Settings.serializeFrom(this.settingsFile);
            if (s != null)
            {
                this.tbRegex.Text = s.regularExpression;
                this.tbText2Test.Text = s.testText;
                this.cbAutoCheck.Checked = s.checkAsType;
                this.cbIgnoreCase.Checked = s.ignoreCase;
                this.cbSingleLine.Checked = s.singleLine;
                this.cbMultiLine.Checked = s.multiLine;
                this.cbRightToLeft.Checked = s.rightToLeft;
                this.cbIgnoreWhitespace.Checked = s.ignoreWhitespace;
                this.cbECMA.Checked = s.ecma;
                this.cbCultureInvariant.Checked = s.cultureInvariant;
                this.cbExpCulture.Checked = s.cultureExplicit;
            }

            CheckRegex();
            btnCheck.Visible = !cbAutoCheck.Checked;


            ToolTip tt = new ToolTip();
            tt.InitialDelay = 1000;
            tt.AutoPopDelay = 5000;
            tt.ReshowDelay = 500;
            tt.ShowAlways = true;

            tt.SetToolTip(this.cbIgnoreCase,  @"Specifies case-insensitive matching");

            tt.SetToolTip(this.cbSingleLine,   "Specifies single-line mode. Changes the meaning of the dot (.) so it matches every\n" + 
                                               @"character (instead of every character except \n).");

            tt.SetToolTip(this.cbMultiLine,    "Multiline mode. Changes the meaning of ^ and $ so they match at the beginning and end,\n" + 
                                               "respectively, of any line, and not just the beginning and end of the entire string.");

            tt.SetToolTip(this.cbRightToLeft, @"Specifies that the search will be from right to left instead of from left to right.");

            tt.SetToolTip(this.cbIgnoreWhitespace,  "Eliminates unescaped white space from the pattern and enables comments marked with #.\n"+
                                                    "However, the System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace value\n" +
                                                    "does not affect or eliminate white space in character classes.");

            tt.SetToolTip(this.cbIgnoreWhitespace, "Enables ECMAScript-compliant behavior for the expression. This value can\n" +
                                                    "be used only in conjunction with the System.Text.RegularExpressions.RegexOptions.IgnoreCase,\n" +
                                                    "System.Text.RegularExpressions.RegexOptions.Multiline, and System.Text.RegularExpressions.RegexOptions.Compiled\n" +
                                                    "values. The use of this value with any other values results in an exception.");

            tt.SetToolTip(this.cbECMA, @"Specifies case-insensitive matching");

            tt.SetToolTip(this.cbCultureInvariant, "Specifies that cultural differences in language is ignored. See Performing\n"+
                                                   "Culture-Insensitive Operations in the RegularExpressions Namespace for more\n"+
                                                   "information.");

            tt.SetToolTip(this.cbExpCulture, "Specifies that the only valid captures are explicitly named or numbered groups\n"+
                                             "of the form (?<name>…). This allows unnamed parentheses to act as noncapturing\n"+
                                             "groups without the syntactic clumsiness of the expression (?:…).");

        
        }

        private void tbRegex_TextChanged(object sender, EventArgs e)
        {
            if (tbRegex.Text.Equals(regex2test))
                return;
            regex2test = tbRegex.Text;

            btnCheck.Enabled = true;
            if(cbAutoCheck.Checked)
                CheckRegex();
        }

        private void tbText2Test_TextChanged(object sender, EventArgs e)
        {
            if (tbText2Test.Text.Equals(text2test))
                return;
            text2test = tbText2Test.Text;

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
            if (scanThread == null || !scanThread.IsAlive)
            {
                scanThread = new Thread(new ThreadStart(CheckRegexWorker));
                scanThread.Start();
            }
            else
                rescan_required = true;
        }

        private void CheckRegexWorker()
        {
            this.Invoke((MethodInvoker)delegate
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
                                    if (cbExpCulture.Checked)
                                        ro |= RegexOptions.ExplicitCapture;
                                    if (cbCultureInvariant.Checked)
                                        ro |= RegexOptions.CultureInvariant;
                                    if (cbECMA.Checked)
                                        ro |= RegexOptions.ECMAScript;
                                    if (cbIgnoreWhitespace.Checked)
                                        ro |= RegexOptions.IgnorePatternWhitespace;

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

                            if (rescan_required)
                            {
                                rescan_required = false;
                                scanThread = new Thread(new ThreadStart(CheckRegexWorker));
                                scanThread.Start();
                            }
                        });
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings s = new Settings();

            s.regularExpression = this.tbRegex.Text;
            s.testText = this.tbText2Test.Text;
            s.checkAsType = this.cbAutoCheck.Checked;
            s.ignoreCase = this.cbIgnoreCase.Checked;
            s.singleLine = this.cbSingleLine.Checked;
            s.multiLine = this.cbMultiLine.Checked;
            s.rightToLeft = this.cbRightToLeft.Checked;
            s.ignoreWhitespace = this.cbIgnoreWhitespace.Checked;
            s.ecma = this.cbECMA.Checked;
            s.cultureInvariant = this.cbCultureInvariant.Checked;
            s.cultureExplicit = this.cbExpCulture.Checked;

            s.serializeTo(this.settingsFile);
        }
    }
}