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
                queryadress.Append(FindInMap1.GoogleMaps);
                queryadress1.Append(FindInMap1.OpenStreetMap);

                string text = listBox1.GetItemText(listBox1.SelectedItem);

                if (text == FindInMap1.FirstMap)
                {
                    if (street != string.Empty)
                    {
                        queryadress1.Append(street + FindInMap1.Comma + FindInMap1.Plus);
                    }

                    if (city != string.Empty)
                    {
                        queryadress1.Append(city + FindInMap1.Comma + FindInMap1.Plus);
                    }

                    if (bar != string.Empty)
                    {
                        queryadress1.Append(bar + FindInMap1.Comma + FindInMap1.Plus);
                    }

                    webBrowser1.Navigate(queryadress1.ToString());
                }
                else
                {
                    if (street != string.Empty)
                    {
                        queryadress.Append(street + FindInMap1.Comma + FindInMap1.Plus);
                    }

                    if (city != string.Empty)
                    {
                        queryadress.Append(city + FindInMap1.Comma + FindInMap1.Plus);
                    }

                    if (bar != string.Empty)
                    {
                        queryadress.Append(bar + FindInMap1.Comma + FindInMap1.Plus);
                    }

                    webBrowser1.Navigate(queryadress.ToString());
                }

            }
            catch
            {
                throw new MapException(FindInMap1.Error);
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
