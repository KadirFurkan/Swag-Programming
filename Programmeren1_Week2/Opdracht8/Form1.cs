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

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            //Alle Variabelen
            string invoerTshirts;
            string invoerBroeken;

            int aantalTshirts;
            int aantalBroeken;

            //Ingevulde textboxen worden geparst
            invoerTshirts = txtAantalShirts.Text;
            aantalTshirts = int.Parse(invoerTshirts);

            invoerBroeken = txtAantalBroeken.Text;
            aantalBroeken = int.Parse(invoerBroeken);

            //Hier zijn de sommen van de applicatie
            int prijs = (aantalTshirts * 30) + (aantalBroeken * 100);
            double btwPrijs = prijs * 0.21;
            double totPrijs = btwPrijs + prijs;

            //Hier wordt het weer uitgeprint in de applicatie
            lblDatum.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            lblPrijs.Text = prijs.ToString("€ 0.00");
            lblBTW.Text = btwPrijs.ToString("€ 0.00");
            lblTotPrijs.Text = totPrijs.ToString("€ 0.00");


        }
    }
}
