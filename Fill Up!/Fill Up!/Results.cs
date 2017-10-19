using System;
using System.Resources;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Results : Form
    {
        private const string resxFile = @".\Results.resx";
        AllBars allBars;
        string currentBar;
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
                {
                    textBox1.Text = Results1.Message + betterBar.Name;
                    currentBar = betterBar.Name;
                }
                  else
                  {
                      textBox1.Text = Results1.Message + cheaperBar.Name;
                      currentBar = betterBar.Name;
                  }
                   
            }
            else
            {
                textBox1.Text = Results1.Message + cheaperBar.Name;
                currentBar = betterBar.Name;
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

            new Map(this.currentBar).Show();
        }

        private void Results_Load(object sender, EventArgs e)
        {

        }
    }
}