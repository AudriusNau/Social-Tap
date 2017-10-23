using System;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Fill_Up_.Exceptions;

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

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void textBoxBaras_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string street = textBoxStreet.Text;
            string city = textBoxCity.Text;
            string bar = textBoxBar.Text;

            try
            {
                StringBuilder queryadress = new StringBuilder();
                StringBuilder queryadress1 = new StringBuilder();
                queryadress.Append(FindInMap.GoogleMaps);
                queryadress1.Append(FindInMap.OpenStreetMap);

                string text = listBox1.GetItemText(listBox1.SelectedItem);

                if (text == FindInMap.FirstMap)
                {
                    if (street != string.Empty)
                    {
                        queryadress1.Append(street + FindInMap.Comma + FindInMap.Plus);
                    }

                    if (city != string.Empty)
                    {
                        queryadress1.Append(city + FindInMap.Comma + FindInMap.Plus);
                    }

                    if (bar != string.Empty)
                    {
                        queryadress1.Append(bar + FindInMap.Comma + FindInMap.Plus);
                    }

                    webBrowser1.Navigate(queryadress1.ToString());
                }
                else
                {
                    if (street != string.Empty)
                    {
                        queryadress.Append(street + FindInMap.Comma + FindInMap.Plus);
                    }

                    if (city != string.Empty)
                    {
                        queryadress.Append(city + FindInMap.Comma + FindInMap.Plus);
                    }

                    if (bar != string.Empty)
                    {
                        queryadress.Append(bar + FindInMap.Comma + FindInMap.Plus);
                    }

                    webBrowser1.Navigate(queryadress.ToString());
                }

            }
            catch
            {
                throw new MapException(FindInMap.Error);
            }
        }

        private void FindInMap_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void city_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
