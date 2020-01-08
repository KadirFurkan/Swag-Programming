using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBedragen_Click(object sender, EventArgs e)
        {
            //Alle textboxen worden gelezen en geparst
            string invoerBeginKM = txtBeginKM.Text;
            double beginKM = double.Parse(invoerBeginKM);

            string invoerEindKM = txtEindKM.Text;
            double eindKM = double.Parse(invoerEindKM);

            string invoerPrijsKM = txtPrijsKM.Text;
            double prijsKM = double.Parse(invoerPrijsKM);

            //Alle berekeningen
            double exclBTW = (eindKM - beginKM) * prijsKM;
            double BTW = exclBTW * 0.21;
            double inclBTW = exclBTW + BTW;

            //Hier alle uitvoer van het programma
            lblPrijsExBTW.Text = exclBTW.ToString("€ 0.00");
            lblBTW.Text = BTW.ToString("€ 0.00");
            lblPrijsIncBTW.Text = inclBTW.ToString("€ 0.00");

        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            txtBeginKM.Text = "";
            txtEindKM.Text = "";
            txtPrijsKM.Text = "";

            lblPrijsExBTW.Text = "";
            lblBTW.Text = "";
            lblPrijsIncBTW.Text = "";
        }
    }
}
