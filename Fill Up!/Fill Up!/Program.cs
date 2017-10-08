using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(allbars));

            ReadFile.ReadingFile();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
           

           
        }
    }
}
