using System;
using System.Windows.Forms;

namespace Registration
{
    static class Program
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Program));
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
