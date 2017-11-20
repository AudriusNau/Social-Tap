using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace Fill_Up_
{
    public partial class Home : Form
    {
        ListsOfBars allBars;

        public Home(ListsOfBars a)
        {
            allBars = a;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Rating(allBars).Show();
        }
        
        private void nearestBars_Click(object sender, EventArgs e)
        {
            new FindInMap().Show();
        }

        private void favoriteBars_Click(object sender, EventArgs e)
        {
            new ListOfRatings(allBars).Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
