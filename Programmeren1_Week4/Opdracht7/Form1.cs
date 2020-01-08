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

        private void BtnMaakVierkant_Click(object sender, EventArgs e)
        {
            string invoerZijde = txtZijde.Text;
            int zijde = int.Parse(invoerZijde);

            string letterZijde = "";

            for (int j = 1; j <= zijde; j++)
            {

                if (j == 1 || j == zijde)
                {
                    for (int a = 1; a <= zijde; a++)
                    {
                        letterZijde = letterZijde + "x";
                        lblVierkant.Text = letterZijde;

                    }
                    letterZijde = letterZijde + "\n";
                }
                else
                {
                    for (int x = 1; x <= zijde; x++)
                    {
                        if (x == 1 || x == zijde)
                        {
                            letterZijde = letterZijde + "x";
                            lblVierkant.Text = letterZijde;
                        }
                        else
                        {
                            letterZijde = letterZijde + " ";
                            lblVierkant.Text = letterZijde;
                        }
                    }
                    letterZijde = letterZijde + "\n";
                }








            }


                
                
                
            
        }
    }
}
