using System;
using System.Text;
using System.Windows.Forms;

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
                queryadress.Append(Map1.GoogleMaps);

                if (bar != string.Empty)
                {
                    queryadress.Append(bar);
                }

                webBrowser1.Navigate(queryadress.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Map1.Error);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
