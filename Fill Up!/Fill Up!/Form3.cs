using System;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Form3 : Form
    {
        public Form3(Bar bar)
        {
            AllBars allBars = new AllBars();
            InitializeComponent();
            ChangeLabels(bar);

            Bar betterBar = allBars.FindBetterBar(bar);
            Bar cheaperBar = allBars.FindCheaperBar(bar);

            //  ****** list'as tuscias, todel betterBar ir cheaperBar tuscios reiksmes
            //palyginima padarysiu AllBars klaseje, kai suprasiu kame problema su listu

            if(betterBar != cheaperBar)
            {
                textBox1.Text = "Sąžiningai alaus įpiltų bare: " + betterBar.Name;
                textBox1.Text += "Pigesnis alus bare: " + cheaperBar.Name;
            }
            else
            {
                textBox1.Text = "Apsimoka eiti į barą: " + cheaperBar.Name;
            }
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
    }
}