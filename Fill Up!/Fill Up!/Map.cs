using System;
using System.Text;
using System.Windows.Forms;
using Fill_Up_.Exceptions;
using Fill_Up_.Fill_Up_;

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
                MapFactory mf = new MapFactory();
                mf.AddNewMap(new GoogleMaps());
                mf.AddNewMap(new OpenStreetMap());

                StringBuilder queryadress = new StringBuilder();
                queryadress.Append(mf.GetUrl(text));

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
    }
}
