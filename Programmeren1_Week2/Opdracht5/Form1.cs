using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBerekenGem_Click(object sender, EventArgs e)
        {
            //Hier alle textboxen die worden geparst
            string invoerGetal1 = txtGetal1.Text;
            double getal1 = double.Parse(invoerGetal1);

            string invoerGetal2 = txtGetal2.Text;
            double getal2 = double.Parse(invoerGetal2);

            string invoerGetal3 = txtGetal3.Text;
            double getal3 = double.Parse(invoerGetal3);

            //Hier de berekening voor het gemiddelde
            double gemSom = ((double)getal1 + getal2 + getal3) / 3;

            lblGemResult.Text = gemSom.ToString("0.00");
        }
    }
}
