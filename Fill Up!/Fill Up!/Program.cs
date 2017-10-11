using System;
using System.Windows.Forms;
using Fill_Up_.Fill_Up_;

namespace Fill_Up_
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            AllBars allbars = new AllBars();
            ReadFile.ReadingFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(allbars));
        }
    }
}
