using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hier worden de getallen opgeslagen in de strings
            Console.WriteLine("Geef uw eerste getal op:");
            string invoerGetal1 = Console.ReadLine();
            Console.WriteLine("Geef het tweede getal op:");
            string invoerGetal2 = Console.ReadLine();

            //Hier worden de strings geparst zodat ermee berekend kan worden
            int getal1 = int.Parse(invoerGetal1);
            int getal2 = int.Parse(invoerGetal2);

            //Hier zijn alle berekeningen
            if (getal1 % getal2 == 0)
            {
                Console.WriteLine("Number 1 is multiple by number 2");
            }
            else if (getal2 % getal1 == 0)
            {
                Console.WriteLine("Number 2 is multiple by number 1");
            }
            else
            {
                Console.WriteLine("Numbers are no multiples");
            }

        }
    }
}
