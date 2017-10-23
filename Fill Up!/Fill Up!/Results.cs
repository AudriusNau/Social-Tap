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
            listBox2.Items.Clear();
            ChangeLabels(bar);
            
            var betterBars = allBars.GetBetterBars(bar);
            
            foreach (string m in betterBars)
            {
                listBox2.Items.Add(m);
            }

            if(listBox2.Items.Count == 0)
            {
                listBox2.Items.Add(Results.Message);
            }
        }

        private void showMap_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem.ToString() == string.Empty)
            {
                MessageBox.Show(Results.Error1);
                return;
            }

            if (listBox1.SelectedItem.ToString() == string.Empty)
            {
                MessageBox.Show(Results.Error2);
                return;
            }

            string curItem = listBox2.SelectedItem.ToString();
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            new Map(curItem, text).Show();
        }
    }
}