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
        /// <summary>
        /// The main entry point for the application.
        /// </summaryl
        [STAThread]
        static void Main()
        {

            ReadFile.ReadingFile();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
           

            
        }
    }
}
