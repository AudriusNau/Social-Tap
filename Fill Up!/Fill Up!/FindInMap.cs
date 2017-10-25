using System;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Fill_Up_.Exceptions;
using Fill_Up_.Fill_Up_;

namespace Fill_Up_
{
    public partial class FindInMap : Form
    {
        private const string resxFile = @".\FindInMap.resx";
        ResourceManager rm = new ResourceManager(resxFile, typeof(FindInMap).Assembly);

        public FindInMap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string street = textBoxStreet.Text;
            string city = textBoxCity.Text;
            string bar = textBoxBar.Text;

            try
            {
                MapFactory mf = new MapFactory();
                mf.AddNewMap(new GoogleMaps());
                mf.AddNewMap(new OpenStreetMap());

                StringBuilder queryadress = new StringBuilder();
                string text = listBox1.GetItemText(listBox1.SelectedItem);

                if (listBox1.GetItemText(listBox1.SelectedItem) == string.Empty)
                {
                    MessageBox.Show(Results.Error2);
                    return;
                }

                queryadress.Append(mf.GetUrl(text));

                if (street != string.Empty)
                {
                    queryadress.Append(FindInMap1.Comma + FindInMap1.Plus + street);
                }

                if (city != string.Empty)
                {
                    queryadress.Append(FindInMap1.Comma + FindInMap1.Plus + city);
                }

                if (bar != string.Empty)
                {
                    queryadress.Append(bar);
                }

                webBrowser1.Navigate(queryadress.ToString());
            }
            catch
            {
                throw new MapException(FindInMap1.Error);
            }
        }
    }
}
