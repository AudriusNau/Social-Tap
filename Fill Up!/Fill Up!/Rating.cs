using System;
using System.Collections.Generic;
using Fill_Up_.Fill_Up_;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Rating : Form
    {
        ListsOfBars allBars;
        public Rating(ListsOfBars a)
        {
            allBars = a;
            InitializeComponent();
            Form2_Load();
        }

        private void button1_Click(object sender, EventArgs e) //issaugoti
        {
            if (textBarName.Text == string.Empty)
            {
                MessageBox.Show(Rating.Error1);
                return;
            }
            //Regex
             if (!Regex.IsMatch(textBarName.Text , @"^[a-zA-Z0-9 ]*$")) // Pavadinime gali buti tik raides, skaiciai ir tarpai
            {
                MessageBox.Show(Rating.Error3);
                return;
            }

            if (domainUpDownRating.Text == string.Empty)
            {
                MessageBox.Show(Rating.Error2);
                return;
            }

            GlassOfBeer glass = new GlassOfBeer();

            glass.LackOfBeer = (int)numericUpDown1.Value;
            glass.Price = numericUpDown2.Value;

            if (radioButton1.Checked == true)
            {
               glass.OrderedQuantity = Rating.Value1.StringToDouble();
            }
            else if (radioButton2.Checked == true)
            {
                glass.OrderedQuantity = Rating.Value2.StringToDouble();
            }
            else if (radioButton3.Checked == true)
            {
                glass.OrderedQuantity = Rating.Value3.StringToDouble();
            }
            else 
                glass.OrderedQuantity = Rating.Value4.StringToDouble();

            VisitedBar bar = new VisitedBar(textBarName.Text, int.Parse(domainUpDownRating.Text), glass);
            allBars.AddNewBar(bar);

            this.Hide();
            new Results(allBars, bar).Show();
        }
    }
}
