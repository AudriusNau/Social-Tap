using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Rating : Form
    {
        AllBars allBars;
        public Rating(AllBars a)
        {
            allBars = a;
            InitializeComponent();
            Form2_Load();
        }

        private void button1_Click(object sender, EventArgs e) //issaugoti
        {
            GlassOfBeer glass = new GlassOfBeer();

            glass.lackOfBeer = (int)numericUpDown1.Value;
            glass.price = numericUpDown2.Value;
                                                //reiktu pakeisti i switch
            if (radioButton1.Checked == true)
            {
                glass.orderedQuantity = 0.3;
            }
            else if (radioButton2.Checked == true)
            {
                glass.orderedQuantity = 0.4;
            }
            else if (radioButton3.Checked == true)
            {
                glass.orderedQuantity = 0.5;
            }
            else
                glass.orderedQuantity = 1;

            Bar bar = new Bar(textBarName.Text, int.Parse(domainUpDownRating.Text), glass);
            allBars.AddNewBar(bar);

            this.Hide();
            new Results(allBars, bar).Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBarName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Rating_Load(object sender, EventArgs e)
        {

        }
    }
}
