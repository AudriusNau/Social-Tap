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
    public partial class Zemelapis : Form
    {
        public Zemelapis()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ieskoti_Click(object sender, EventArgs e)
        {
            string gatve = textBoxGatve.Text;
            string miestas = textBoxMiestas.Text;
            string baras = textBoxBaras.Text;

            try
            {
                StringBuilder queryadress = new StringBuilder();
                queryadress.Append("http://maps.google.com/maps?q=");

                if (gatve != string.Empty)
                {
                    queryadress.Append(gatve + "," + "+");
                }

                if (miestas != string.Empty)
                {
                    queryadress.Append(miestas + "," + "+");
                }

                if (baras !=string.Empty)
                {
                    queryadress.Append(baras + "," + "+");
                }

                webBrowser1.Navigate(queryadress.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void atgal_Click(object sender, EventArgs e)
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

        private void textBoxBaras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
