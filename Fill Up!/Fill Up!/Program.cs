using System;
using System.Windows.Forms;
using Fill_Up_.Fill_Up_;
using System.Collections.Generic;

namespace Fill_Up_
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ListsOfBars allbars = new ListsOfBars();

            ReadFile load = new ReadFile();
            load.LoadData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(allbars));
        }
    }
}
