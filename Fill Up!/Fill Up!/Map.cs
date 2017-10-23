using System;
using System.Text;
using System.Windows.Forms;
using Fill_Up_.Exceptions;

namespace Fill_Up_
{
    public partial class Map : Form
    {
        public Map(string currentBar)
        {
            InitializeComponent();

            string bar = currentBar;

            try
            {
                StringBuilder queryadress = new StringBuilder();
                queryadress.Append(Map.GoogleMaps);

                if (bar != string.Empty)
                {
                    queryadress.Append(bar);
                }

                webBrowser1.Navigate(queryadress.ToString());

            }
            catch
            {
                throw new MapException(Map.Error);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
