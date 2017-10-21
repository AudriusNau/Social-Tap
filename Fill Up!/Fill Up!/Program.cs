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
            AllBars allbars = new AllBars();
            
            ReadFile load = new ReadFile();
            load.LoadData(allbars);
            List <Bar> x = allbars.GetBarList();
            MessageBox.Show(x.Count.ToString());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(allbars));
        }
    }
}
