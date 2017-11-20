using System;
using System.Windows.Forms;
using Fill_Up_.Fill_Up_;
using System.Threading;

namespace Fill_Up_
{
    static class Program
    {
        public static void SoundTrack()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            string path = @"Fly_Me_To_The_Moon.wav";
            player.SoundLocation = path;
            player.Play();
            
        }
        [STAThread]
        static void Main()
        {
            ListsOfBars allbars = new ListsOfBars();

            Thread th = new Thread(SoundTrack);
            th.Start();

            ReadFile load = new ReadFile();
            load.ReadData(allbars);
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(allbars));

            WriteFile write = new WriteFile();
            write.WriteToFile(allbars);
        }
    }
}
