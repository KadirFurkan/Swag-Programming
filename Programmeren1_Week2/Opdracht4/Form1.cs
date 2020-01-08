using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string invoer = txtGeefPrijs.Text;
            double geefPrijs = double.Parse(invoer);

            double BTW_Formule = 1.21;
            double BTW = 0.21;
            double BTW_Prijs = BTW * geefPrijs;
            double totaalPrijs = BTW_Formule * geefPrijs;

            lblPrijs.Text = geefPrijs.ToString("0.00");
            lblBTW.Text =  BTW_Prijs.ToString("0.00");
            lblTotaalPrijs.Text = totaalPrijs.ToString("0.00");


        }
    }
}
