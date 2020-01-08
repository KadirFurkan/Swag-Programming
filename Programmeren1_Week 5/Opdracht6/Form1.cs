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

        int[] getallen = new int[20];
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Random int aangemaakt
            Random rnd = new Random();

            int teller = 0;
            int teller_2 = 0;

            //Hier komt de verwerking van de code
            foreach (int getal in getallen)
            {
                getallen[teller] = rnd.Next(0, 500);
                lblVooraf.Text += $"Element {teller} = {getallen[teller]} \n";
                teller++;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            const int PLUS = 10;
            const int MIN = -5;
            int teller = 0;
            int teller_2 = 0;

            int invoer = int.Parse(txtInvoer.Text);

            foreach (int getal in getallen)
            {
                if (getallen[teller] >= invoer)
                {
                    getallen[teller] = getallen[teller] + PLUS;
                    teller++;
                }
                else if (getallen[teller] < invoer)
                {
                    getallen[teller] = getallen[teller] + MIN;
                    teller++;
                }

                lblAchteraf.Text += $"Element {teller_2} = {getallen[teller_2]} \n";
                teller_2++;
            }

            button1.Enabled = false;
        }
    }
}
