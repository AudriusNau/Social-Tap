using System;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Results : Form
    {
        ListsOfBars allBars;
        //string currentBar;

        public Results(ListsOfBars a, VisitedBar bar)
        {
            allBars = a;
            InitializeComponent();
            ChangeLabels(bar);
            
            var betterBars = allBars.GetBetterBars(bar);

            foreach (string m in betterBars)
            {
                listBox1.Items.Add(m);
            }

            /*VisitedBar betterBar = allBars.FindBetterBar(bar);
            VisitedBar cheaperBar = allBars.FindCheaperBar(bar);
            
            if(betterBar != cheaperBar)
            {
                if(betterBar.Rating >= cheaperBar.Rating)
                {
                    textBox1.Text = Results.Message + betterBar.Name;
                    currentBar = betterBar.Name;
                }
                  else
                  {
                      textBox1.Text = Results.Message + cheaperBar.Name;
                      currentBar = betterBar.Name;
                  } 
            }
            else
            {
                textBox1.Text = Results.Message + cheaperBar.Name;
                currentBar = betterBar.Name;
            }*/

        }

        private void showMap_Click(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            new Map(curItem).Show();
            //new Map(currentBar).Show();
        }
    }
}