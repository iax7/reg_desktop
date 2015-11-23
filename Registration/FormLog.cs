using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using log4net.Appender;
using System.IO;

namespace Registration
{
    /// <summary>
    /// Shows the user all logs from Log4Net except the ones of DEBUG type.
    /// In order to this form to work you need to register it as listerner first with static method: FormLog.RegisterAsListener()
    /// </summary>
    public partial class FormLog : Form, IAppender
    {
        #region Singleton
        private static FormLog _default;
        public static FormLog Default
        {
            get
            {
                if (_default == null)
                {
                    _default = new FormLog();
                }
                return _default;
            }
        }
        private FormLog()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// Opens the form, or if already opened brings it to front
        /// </summary>
        public new void Show()
        {
            Form log = Application.OpenForms[Default.GetType().Name];
            if (log != null)
            {
                if (!log.Visible) 
                    base.Show();
                else 
                    log.BringToFront();
            }
            else
                base.Show();
        }

        /// <summary>
        /// Warning: Call this from Main Window after InitializeMethod.
        /// </summary>
        public static void RegisterAsListener()
        {
            ((log4net.Repository.Hierarchy.Hierarchy)log4net.LogManager.GetRepository()).Root.AddAppender(FormLog.Default);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public void DoAppend(log4net.Core.LoggingEvent loggingEvent)
        {
            string msg = String.Format("{0}: {1}", loggingEvent.Level.Name, loggingEvent.MessageObject.ToString());            
            switch (loggingEvent.Level.Name)
            {
                case "ERROR":
                    Append(msg);
                    Highlight("ERROR:", Color.Salmon);
                    break;
                case "FATAL":
                    AppendFatal(msg);                    
                    break;
                case "WARN":
                    Append(msg);
                    Highlight("WARN:", Color.YellowGreen);
                    break;
                /* case "DEBUG":
                     Highlight("DEBUG:",Color.DimGray);
                     break;*/
                case "INFO":
                    Append(msg);
                    Highlight("INFO:", Color.ForestGreen);
                    break;
            }
        }

        #region LogMessages

        public delegate void AppendDelegate(string Text);
        public delegate void AppendFatalDelegate(string Text);
        public delegate void HighlightDelegate(string Text, Color? color);

        public void Append(string Text)
        {
            if (txtLog.InvokeRequired)
            {
                try
                {
                    AppendDelegate del = Append;
                    txtLog.Invoke(del, new object[] { Text });
                }
                catch (Exception ex)
                {
                    MessageCustom.Error("The Log could not be updated: " + ex);
                }
            }
            else
            {
                txtLog.AppendText(string.Format("[{0:HH:mm:ss}] {1}{2}", DateTime.Now.ToUniversalTime(), Text, Environment.NewLine));
                txtLog.ScrollToCaret();
            }
        }
        public void AppendFatal(string Text)
        {
            if (txtLog.InvokeRequired)
            {
                try
                {
                    AppendFatalDelegate del = AppendFatal;
                    txtLog.Invoke(del, new object[] {Text});
                }
                catch (Exception ex)
                {
                    MessageCustom.Error("The Log could not be updated: " + ex);
                }
            }
            else
            {
                const string err = "FATAL:";
                Append(Text);
                txtLog.Find(err, RichTextBoxFinds.Reverse);
                txtLog.SelectionFont  = new Font(txtLog.Font, FontStyle.Bold);
                txtLog.SelectionColor = Color.Red;
                txtLog.Find(Text, RichTextBoxFinds.Reverse);
                txtLog.SelectionColor = Color.Red;
            }
        }
        public void Highlight(string Text, Color? color)
        {
            if (txtLog.InvokeRequired)
            {
                try
                {
                    HighlightDelegate del = Highlight;
                    txtLog.Invoke(del, new object[] {Text, color});
                }
                catch (Exception ex)
                {
                    MessageCustom.Error("The Log could not be updated: " + ex);
                }
            }
            else
            {
                if (color == null)
                    color = Color.OrangeRed;

                txtLog.Find(Text, RichTextBoxFinds.Reverse);
                txtLog.SelectionFont  = new Font(txtLog.Font, FontStyle.Bold);
                txtLog.SelectionColor = color.Value;
            }
        }
        #endregion

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Application.StartupPath,""));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

    }
}
