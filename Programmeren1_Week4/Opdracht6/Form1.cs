using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBerekenEindKapitaal_Click(object sender, EventArgs e)
        {
            string invoerBedrag = txtStartBedrag.Text;
            double startBedrag = double.Parse(invoerBedrag);

            for (int jaar = 1; jaar <= 5; jaar++)
            {
                startBedrag = startBedrag * 1.05;
            }

            lblEindKapitaal.Text = startBedrag.ToString("€ 0.00");
        }
    }
}
