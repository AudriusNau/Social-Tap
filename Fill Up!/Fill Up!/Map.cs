using System;
using System.Resources;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Map : Form
    {
        private const string resxFile = @".\Map.resx";
        ResourceManager rm = new ResourceManager(resxFile, typeof(Map).Assembly);
        AllBars allBars;
        public Map(AllBars a)
        {
            InitializeComponent();

            string bar = "snekutis"; //pakeisti i rekomenduojama bara

            try
            {
                StringBuilder queryadress = new StringBuilder();
                queryadress.Append("https://www.google.lt/maps/search/");

                if (bar != string.Empty)
                {
                    queryadress.Append(bar);
                }

                webBrowser1.Navigate(queryadress.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), rm.GetString("Error"));
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
