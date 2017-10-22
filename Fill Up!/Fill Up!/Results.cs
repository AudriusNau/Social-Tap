using System;
using System.Resources;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Results : Form
    {
        private const string resxFile = @".\Results.resx";
        ListsOfBars allBars;
        string currentBar;
        public Results(ListsOfBars a, VisitedBar bar)
        {
            allBars = a;
            InitializeComponent();
            ChangeLabels(bar);

            VisitedBar betterBar = allBars.FindBetterBar(bar);
            VisitedBar cheaperBar = allBars.FindCheaperBar(bar);
            
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
    }
}