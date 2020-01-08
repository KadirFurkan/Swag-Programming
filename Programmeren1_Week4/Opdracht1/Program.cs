using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer uw getal in: ");
            string invoerGetal = Console.ReadLine();
            int getal = int.Parse(invoerGetal);

            int totaalPositiefGetal = 0;
            int teller = 0;
            
            while (getal != 0)
            {
                if (getal > 0)
                {
                    Console.Write("Voer uw getal in: ");
                    string invoerPositiefGetal = Console.ReadLine();
                    int invoerPosGetal = int.Parse(invoerPositiefGetal);
                    totaalPositiefGetal = totaalPositiefGetal + invoerPosGetal;
                    teller++;
                }

                Console.Write("Voer uw getal in: ");
                getal = int.Parse(Console.ReadLine());
            }

            double gemSom = (double)totaalPositiefGetal / (double)teller;
            Console.WriteLine(gemSom.ToString("0.00"));
        }
    }
}
