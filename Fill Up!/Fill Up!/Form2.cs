using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Form2 : Form
    {
        AllBars allBars;
        public Form2(AllBars a)
        {
            allBars = a;
            InitializeComponent();
            Form2_Load();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form1)
                {
                    frm.Show();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //issaugoti
        {
            GlassOfBeer glass = new GlassOfBeer();

            glass.lackOfBeer = (int)numericUpDown1.Value;
            glass.price = numericUpDown2.Value;

            if (radioButton1.Checked == true)
            {
                glass.orderedQuantity = 0.3;
            }
            else if (radioButton2.Checked == true)
            {
                glass.orderedQuantity = 0.4;
            }
            else if (radioButton3.Checked == true)
            {
                glass.orderedQuantity = 0.5;
            }
            else
                glass.orderedQuantity = 1;

            Bar bar = new Bar(textBarName.Text, int.Parse(domainUpDownRating.Text), glass);
            x.AddNewBar(bar);

            List<Bar> hehe = allBars.GetBarList();
            MessageBox.Show(hehe.Count.ToString());

            this.Hide();
            Form3 frm3 = new Form3(allBars, bar);
            frm3.Show();
        }
    }
}
