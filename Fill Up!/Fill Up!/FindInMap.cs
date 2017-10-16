using System;
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
                    queryadress.Append(street + "," + "+");
                }

                if (city != string.Empty)
                {
                    queryadress.Append(city + "," + "+");
                }

                if (bar != string.Empty)
                {
                    queryadress.Append(bar + "," + "+");
                }

                webBrowser1.Navigate(queryadress.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
