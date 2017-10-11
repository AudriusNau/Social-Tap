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
            this.Hide();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Rating)
                {
                    frm.Show();
                    return;
                }
            }

            Rating f2 = new Rating(allBars);
            f2.Show();
        }
        
        private void artimiausiBarai_Click(object sender, EventArgs e)
        {
            
        }

        private void artimiausiBarai_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Map)
                {
                    frm.Show();
                    return;
                }
            }

            Map zemelapis = new Map();
            zemelapis.Show();
        }
    }
}
