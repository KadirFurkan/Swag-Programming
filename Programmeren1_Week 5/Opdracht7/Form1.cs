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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGooien_Click(object sender, EventArgs e)
        {
            //Dit is de array voor de dobbelsteen
            int[] dobbelsteen = new int[6];

            //Dit is de random code
            Random rnd = new Random();

            for (int i = 0; i < dobbelsteen.Length; i++)
            {
                dobbelsteen[i] = 0;
            }

            for (int i = 0; i < 6000; i++)
            {
                int random = rnd.Next(1, 7);
                dobbelsteen[random - 1] = dobbelsteen[random - 1] + 1;
            }

            int count = 0;
            foreach (int getal in dobbelsteen)
            {
                lblWaarde.Text += $"Waarde {count} is {getal} keer gegooid \n";
                count++;
            }
        }
    }
}
