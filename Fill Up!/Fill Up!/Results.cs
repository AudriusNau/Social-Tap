using System;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Results : Form
    {
        AllBars allBars;

        public Results(AllBars a, Bar bar)
        {
            allBars = a;
            InitializeComponent();
            ChangeLabels(bar);

            Bar betterBar = allBars.FindBetterBar(bar);
            Bar cheaperBar = allBars.FindCheaperBar(bar);
            
            if(betterBar != cheaperBar)
            {
                if(betterBar.Rating >= cheaperBar.Rating)
                    textBox1.Text = "Apsimoka eiti į barą: " + betterBar.Name;
                  else
                    textBox1.Text = "Apsimoka eiti į barą: " + cheaperBar.Name;
            }
            else
            {
                textBox1.Text = "Apsimoka eiti į barą: " + cheaperBar.Name;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void barName_Click(object sender, EventArgs e)
        {

        }

        private void showMap_Click(object sender, EventArgs e)
        {
            new Map(allBars).Show();
        }

        private void Results_Load(object sender, EventArgs e)
        {

        }
    }
}