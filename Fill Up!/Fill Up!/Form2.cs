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
using System.Collections;

namespace Fill_Up_
{
    public partial class Form2 : Form
    {
        AllBars allBars = new AllBars();
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

        private void textBarName_TextChanged(object sender, EventArgs e) { }  //baro pavadinimas
        private void label1_Click(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { } //0,3
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { } //0,4
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }  //0,5
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { } //1
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { } //kiek truksta mm
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) { } //eurai

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
            {
                glass.orderedQuantity = 1;
            }

            Bar bar = new Bar(textBarName.Text, int.Parse(domainUpDownRating.Text), glass);
            allBars.addNewBar(bar);

        }
    }
}
