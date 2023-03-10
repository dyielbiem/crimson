using System;
using System.Windows.Forms;

namespace AppDevProj
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogInForm loginWindow = new LogInForm();
            loginWindow.ShowDialog();
            //MainForm mainWindow = new MainForm();
            //mainWindow.ShowDialog();
            
            
        }
    }
}
