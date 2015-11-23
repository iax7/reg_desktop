using System.Windows.Forms;

namespace Registration
{
    /// <summary>
    /// Creates Windows MessageBox already preconfigured, avoiding using same parameters over and over
    /// </summary>
    public static class MessageCustom
    {
        public static DialogResult Error(string message, string title = "Error", MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
        }
        public static DialogResult Information(string message, string title = "Information", MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }
        public static DialogResult Question(string message, string title = "Question", MessageBoxButtons buttons = MessageBoxButtons.YesNo)
        {
            return MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
        }
        public static DialogResult Warning(string message, string title = "Warning", MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
        }

    }
}
