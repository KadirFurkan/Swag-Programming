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

        private void BtnBerekenTijd_Click(object sender, EventArgs e)
        {
            string invoer = txtSeconden.Text;
            int seconden = int.Parse(invoer);

            int uur = seconden / 3600;
            int uurAftrek = uur * 3600;
            seconden = seconden - uurAftrek;
            int minuten = seconden / 60;
            int minutenAftrek = minuten * 60;
            seconden = seconden - minutenAftrek;

            uur.ToString();
            minuten.ToString();
            seconden.ToString();
            string uitvoer = $"{uur}:{minuten}:{seconden}";


            lblAntwoord.Text = uitvoer;

        }
    }
}
