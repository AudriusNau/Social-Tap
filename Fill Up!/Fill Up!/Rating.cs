using System;
using System.Collections.Generic;
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
                MessageBox.Show(Rating1.Error1);
                return;
            }

            if (domainUpDownRating.Text == string.Empty)
            {
                MessageBox.Show(Rating1.Error2);
                return;
            }

            GlassOfBeer glass = new GlassOfBeer();

            glass.lackOfBeer = (int)numericUpDown1.Value;
            glass.price = numericUpDown2.Value;

            if (radioButton1.Checked == true)
            {
                glass.orderedQuantity = double.Parse(Rating1.Value1);
            }
            else if (radioButton2.Checked == true)
            {
                glass.orderedQuantity = double.Parse(Rating1.Value2);
            }
            else if (radioButton3.Checked == true)
            {
                glass.orderedQuantity = double.Parse(Rating1.Value3);
            }
            else 
                glass.orderedQuantity = double.Parse(Rating1.Value4);
            
            VisitedBar bar = new VisitedBar(textBarName.Text, int.Parse(domainUpDownRating.Text), glass);
            allBars.AddNewBar(bar);

            this.Hide();
            new Results(allBars, bar).Show();
        }
    }
}
