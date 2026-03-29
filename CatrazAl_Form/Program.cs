using System;
using System.Windows.Forms;

namespace CatrazAl_Form
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initialize WinForms application settings
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main GUI form
            Application.Run(new MainForm());
        }
    }
}