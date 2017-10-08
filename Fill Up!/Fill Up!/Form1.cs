using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

            Form2 f2 = new Form2();
            f2.Show();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void megstamiausiBarai_Click(object sender, EventArgs e)
        {

        }

        private void artimiausiBarai_Click(object sender, EventArgs e)
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
