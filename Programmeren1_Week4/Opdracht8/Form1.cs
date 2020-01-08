using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVergelijk_Click(object sender, EventArgs e)
        {
            string invoer = txtInvoerGetal.Text;
            int getal = int.Parse(invoer);

            double som1 = 0;
            double som2 = getal * (getal + 1) / 2;

            for (int i = 0; i <= getal; i++)
            {
                som1 = som1 + i;
            }

            if (som1 == som2)
            {
                lblVergelijking.Text = "De som en de formule zijn gelijk";
            }
            else
            {
                lblVergelijking.Text = "De som en de formule zijn niet gelijk";
            }
            lblSom1.Text = som1.ToString();
            lblSom2.Text = som2.ToString();

        }
    }
}
