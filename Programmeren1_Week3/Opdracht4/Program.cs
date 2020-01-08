using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hier wordt de invoer van de gebruiker opgeslagen in strings
            Console.WriteLine("Schrijf uw eerste getal op: ");
            string invoerGetal1 = Console.ReadLine();
            Console.WriteLine("Schrijf uw tweede getal op: ");
            string invoerGetal2 = Console.ReadLine();
            Console.WriteLine("Schrijf uw derde getal op: ");
            string invoerGetal3 = Console.ReadLine();

            //Hier worden de strings geparst waardoor we kunnen rekenen
            int getal1 = int.Parse(invoerGetal1);
            int getal2 = int.Parse(invoerGetal2);
            int getal3 = int.Parse(invoerGetal3);

            //Hier komen alle berekeningen
            int som = getal1 + getal2 + getal3;
            int keer = getal1 * getal2 * getal3;
            double gemSom = (double)som / 3;
            int kleinsteGetal;
            int grootsteGetal;
            bool grootteGetal1 = getal1 > getal2 && getal1 > getal3;
            bool grootteGetal2 = getal2 > getal1 && getal2 > getal3;
            bool grootteGetal3 = getal3 > getal1 && getal3 > getal2;
            bool kleinsteGetal1 = getal1 < getal2 && getal1 < getal3;
            bool kleinsteGetal2 = getal2 < getal1 && getal2 < getal3;
            bool kleinsteGetal3 = getal3 < getal1 && getal3 < getal2;


            //Hier wordt gecheckt welk getal het grootste is
            if (grootteGetal1 == true)
            {
                grootsteGetal = getal1;
            }
            else if (grootteGetal2 == true)
            {
                grootsteGetal = getal2;
            }
            else
            {
                grootsteGetal = getal3;
            }

            //Hier wordt gecheckt welk getal het kleinste is
            if (kleinsteGetal1 == true)
            {
                kleinsteGetal = getal1;
            }
            else if (kleinsteGetal2 == true)
            {
                kleinsteGetal = getal2;
            }
            else
            {
                kleinsteGetal = getal3;
            }

            //Hier wordt het resultaat geprint
            Console.WriteLine("De som is: {0}", som);
            Console.WriteLine("Het gemiddelde is: {0}", gemSom.ToString("0.00"));
            Console.WriteLine("Het product is: {0}", keer);
            Console.WriteLine("Het grootste getal is: {0}", grootsteGetal);
            Console.WriteLine("Het kleinste getal is: {0}", kleinsteGetal);



        }
    }
}
