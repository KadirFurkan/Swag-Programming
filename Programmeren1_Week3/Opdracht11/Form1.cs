using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBerekenGemiddelde_Click(object sender, EventArgs e)
        {
            //Hier wordt de invoer van de gebruiker opgeslagen in de strings
            string invoerGetal1 = txtGetal1.Text;
            double getal1 = double.Parse(invoerGetal1);
            string invoerGetal2 = txtGetal2.Text;
            double getal2 = double.Parse(invoerGetal2);
            double grootsteGetal;
            double kleinsteGetal;
            double gemiddelde = (getal1 + getal2) / 2;

            if (getal1 > getal2)
            {
                grootsteGetal = getal1;
                kleinsteGetal = getal2;
            }
            else
            {
                grootsteGetal = getal2;
                kleinsteGetal = getal1;
            }
            double verschil = grootsteGetal - gemiddelde;

            lblGrootsteGetal.Text = grootsteGetal.ToString();
            lblGemiddelde.Text = gemiddelde.ToString("0.00");
            lblVerschil.Text = verschil.ToString("0.00");
        }
    }
}
