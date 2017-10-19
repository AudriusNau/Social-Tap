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
                queryadress.Append("https://www.google.lt/maps/search/");

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), FindInMap1.Error);
            }
        }

        private void FindInMap_Load(object sender, EventArgs e)
        {

        }
    }
}
