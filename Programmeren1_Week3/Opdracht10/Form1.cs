using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            string invoerMaandsalaris = txtMaandsalaris.Text;
            double maandSalaris = double.Parse(invoerMaandsalaris);
            double salarisVerhoging = 1.05;
            double verhogingMaandSalaris = maandSalaris * salarisVerhoging;
            double verhoging = maandSalaris * 0.05;

            const int MIN_VERHOGING = 75;

            if (verhoging < 75)
            {
                lblVerhoging.Text = MIN_VERHOGING.ToString("€ 0.00");
                lblNieuweMaandsalaris.Text = (maandSalaris + MIN_VERHOGING).ToString("€ 0.00");
            }
            else if (verhoging > 75)
            {
                lblVerhoging.Text = verhoging.ToString("€ 0.00");
                lblNieuweMaandsalaris.Text = (verhogingMaandSalaris.ToString("€ 0.00"));
            }
            

        }
    }
}
