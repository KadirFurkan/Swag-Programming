using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            //Hier wordt de input opgeslagen in de strings en geparst
            string invoerLeeftijd = txtLeeftijd.Text;
            int leeftijd = int.Parse(invoerLeeftijd);
            string invoerDuurLidmaatschap = txtDuurLidmaatschap.Text;
            int duurLidmaatschap = int.Parse(invoerDuurLidmaatschap);

            //Alle variabelen
            int kortingLeeftijd = 25;
            int kortingLidmaatschap = 20;
            int contributieVoetbal = 175;
            int contributieHandbal = 225;

            //Hier komt de uitwerking van de code
            if (rdbtnVoetbal.Checked)
            {
                if (leeftijd > 40 && duurLidmaatschap > 10)
                {
                    contributieVoetbal = contributieVoetbal - kortingLeeftijd - kortingLidmaatschap;
                    lblContributie.Text = contributieVoetbal.ToString("€ 0.00");
                }
                else if (leeftijd > 40)
                {
                    contributieVoetbal = contributieVoetbal - kortingLeeftijd;
                    lblContributie.Text = contributieVoetbal.ToString("€ 0.00");
                }
                else if (duurLidmaatschap > 10)
                {
                    contributieVoetbal = contributieVoetbal - kortingLidmaatschap;
                    lblContributie.Text = contributieVoetbal.ToString("€ 0.00");
                }
            }
            else
            {
                if (leeftijd > 40 && duurLidmaatschap > 10)
                {
                    contributieHandbal = contributieHandbal - kortingLeeftijd - kortingLidmaatschap;
                    lblContributie.Text = contributieHandbal.ToString("€ 0.00");
                }
                else if (leeftijd > 40)
                {
                    contributieHandbal = contributieHandbal - kortingLeeftijd;
                    lblContributie.Text = contributieHandbal.ToString("€ 0.00");
                }
                else if (duurLidmaatschap > 10)
                {
                    contributieHandbal = contributieHandbal - kortingLidmaatschap;
                    lblContributie.Text = contributieHandbal.ToString("€ 0.00");
                }
            }

            
        }
    }
}
