using System;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Home : Form
    {
        AllBars allBars;

        public Home(AllBars a)
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
            new Map().Show();
        }
    }
}
