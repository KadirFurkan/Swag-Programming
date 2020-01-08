using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
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

            if (getal1 > getal3 && getal2 > getal3)
            {
                Console.WriteLine("Het derde getal is de kleinste getal van de drie");
            }
            else
            {
                Console.WriteLine("Het derde getal is niet de kleinste van de drie");
            }
        }
    }
}
