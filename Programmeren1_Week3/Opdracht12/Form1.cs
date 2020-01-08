using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBerekenBiosKaart_Click(object sender, EventArgs e)
        {
            string invoerLeeftijd = txtLeeftijd.Text;
            int leeftijd = int.Parse(invoerLeeftijd);
            const int PRIJS_KAARTJE = 12;
            int halvePrijs = PRIJS_KAARTJE / 2;

            if (leeftijd >= 13 && leeftijd < 55)
            {
                lblPrijsKaartje.Text = PRIJS_KAARTJE.ToString("€ 0.00");
            }
            else if (leeftijd <= 12 && leeftijd > 5)
            {
                lblPrijsKaartje.Text = halvePrijs.ToString("€ 0.00");
            }
            else
            {
                lblPrijsKaartje.Text = ("€ 0.00");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
