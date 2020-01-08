using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBerekenBedrag_Click(object sender, EventArgs e)
        {
            //Hier wordt de invoer van de gebruiker opgeslagen in de strings
            string invoerDagenGehuurd = txtDagenGehuurd.Text;
            string invoerKmGereden = txtKmGereden.Text;
            string invoerLitersGetankt = txtLitersGetankt.Text;

            //Hier worden alle strings geparst zoder ermee gerekend kan worden
            int dagenGehuurd = int.Parse(invoerDagenGehuurd);
            int kmGereden = int.Parse(invoerKmGereden);
            double litersGetankt = double.Parse(invoerLitersGetankt);

            //Hier komen alle berekeningen
            const int HUUR_PER_DAG = 55;
            int huurTotaal = HUUR_PER_DAG * dagenGehuurd;
            int rechtTotaalKM = dagenGehuurd * 100;
            int formuleExtraKM = kmGereden - rechtTotaalKM;

            if (checkTankOpHuurder.Checked && formuleExtraKM > 0)
            {
                double brandstofPrijs = litersGetankt * 2.20;
                double prijsExtraKM = 0.25 * formuleExtraKM;
                lblHuurBedrag.Text = (brandstofPrijs + (double)huurTotaal + prijsExtraKM).ToString("€ 0.00");
            }
            else if (formuleExtraKM > 0)
            {
                double prijsExtraKM = 0.25 * formuleExtraKM;
                lblHuurBedrag.Text = ((double)huurTotaal + prijsExtraKM).ToString("€ 0.00");
            }
            else
            {
                lblHuurBedrag.Text = ((double)huurTotaal).ToString("€ 0.00");
            }


        }
    }
}
