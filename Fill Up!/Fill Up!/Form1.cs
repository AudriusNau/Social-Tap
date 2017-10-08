using System;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Form1 : Form
    {
        AllBars allBars;

        public Form1(AllBars a)
        {
            allBars = a;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form2)
                {
                    frm.Show();
                    return;
                }
            }

            Form2 f2 = new Form2(allBars);
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
                if (frm is Zemelapis)
                {
                    frm.Show();
                    return;
                }
            }

            Zemelapis zemelapis = new Zemelapis();
            zemelapis.Show();
        }
    }
}
