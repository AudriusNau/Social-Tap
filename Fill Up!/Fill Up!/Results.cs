using System;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Results : Form
    {
        ListsOfBars allBars;

        public Results(ListsOfBars a, VisitedBar bar)
        {
            
            allBars = a;
            InitializeComponent();
            listBox1.Items.Clear();
            ChangeLabels(bar);
            
            var betterBars = allBars.GetBetterBars(bar);
            
            foreach (string m in betterBars)
            {
                listBox1.Items.Add(m);
            }

            if(listBox1.Items.Count == 0)
            {
                listBox1.Items.Add(Results.Message);
            }
        }

        private void showMap_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == string.Empty)
            {
                MessageBox.Show(Results.Error1);
                return;
            }

            string curItem = listBox1.SelectedItem.ToString();
            new Map(curItem).Show();
        }
    }
}