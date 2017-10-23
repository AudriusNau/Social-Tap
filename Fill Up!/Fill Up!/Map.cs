using System;
using System.Text;
using System.Windows.Forms;
using Fill_Up_.Exceptions;

namespace Fill_Up_
{
    public partial class Map : Form
    {
        public Map(string currentBar, string text)
        {
            InitializeComponent();

            string bar = currentBar;

            try
            {
                StringBuilder queryadress = new StringBuilder();
                StringBuilder queryadress1 = new StringBuilder();
                queryadress.Append(Map.GoogleMaps);
                queryadress1.Append(Map.OpenStreetMap);

                if (text == Map.FirstMap)
                {
                    if (bar != string.Empty)
                    {
                        queryadress1.Append(bar);
                    }

                    webBrowser1.Navigate(queryadress1.ToString());
                }
                else
                {
                    if (bar != string.Empty)
                    {
                        queryadress.Append(bar);
                    }

                    webBrowser1.Navigate(queryadress.ToString());
                }

            }
            catch
            {
                throw new MapException(Map.Error);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
