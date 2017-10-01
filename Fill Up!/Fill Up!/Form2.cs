using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fill_Up_;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
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
            Bar bar = new Bar();
            GlassOfBeer glass = new GlassOfBeer();

            bar.Name = textBarName.Text;
            bar.Rating = int.Parse(domainUpDownRating.Text);
            glass.LackOfBeer = (int)numericUpDown1.Value;
            glass.Price = (double)numericUpDown2.Value;

            if (radioButton1.Checked == true)
            {
                glass.OrderedQuantity = 0.3;
            }
            else if (radioButton2.Checked == true)
            {
                glass.OrderedQuantity = 0.4;
            }
            else if (radioButton3.Checked == true)
            {
                glass.OrderedQuantity = 0.5;
            }
            else
            {
                glass.OrderedQuantity = 1;
            }
        }
    }
}
