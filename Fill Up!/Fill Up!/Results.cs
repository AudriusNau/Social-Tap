﻿using System;
using System.Windows.Forms;

namespace Fill_Up_
{
    public partial class Results : Form
    {
        AllBars allBars;
        string currentBar;
        public Results(AllBars a, Bar bar)
        {
            allBars = a;
            InitializeComponent();
            ChangeLabels(bar);

            Bar betterBar = allBars.FindBetterBar(bar);
            Bar cheaperBar = allBars.FindCheaperBar(bar);

            if(betterBar != cheaperBar)
            {
                textBox1.Text = "Sąžiningai alaus įpiltų bare: " + betterBar.Name;
                textBox1.Text += "Pigesnis alus bare: " + cheaperBar.Name;
            }
            else
            {
                textBox1.Text = "Apsimoka eiti į barą: " + cheaperBar.Name;
                this.currentBar = cheaperBar.Name;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void barName_Click(object sender, EventArgs e)
        {

        }

        private void showMap_Click(object sender, EventArgs e)
        {
            new Map(currentBar).Show();
        }
    }
}