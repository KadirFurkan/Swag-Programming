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
            //Hier wordt eerst het vaknaam gevraagd en opgeslagen in de string
            Console.Write("Geef het vaknaam: ");
            string invoerVak = Console.ReadLine();

            //Hier wordt aantal studenten opgeslagen in de string en geparst
            Console.Write("Geef het aantal studenten: ");
            string invoerAantalStudenten = Console.ReadLine();
            int aantalStudenten = int.Parse(invoerAantalStudenten);

            Console.WriteLine();
            //Hier zijn de arrays
            string[] namen = new string[aantalStudenten];
            double[] cijfers = new double[aantalStudenten];

            double totaal = 0;
            int teller = 0;

            for (int i = 1; i <= aantalStudenten; i++)
            {
                Console.Write("Geef de naam van de {0}e student: ", i);
                namen[i - 1] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= aantalStudenten ; i++)
            {
                Console.Write("Geef het cijfer van {0}: ", namen[i - 1]);
                cijfers[i - 1] = double.Parse(Console.ReadLine());
                totaal = totaal + cijfers[i - 1];
            }

            double gem = totaal / aantalStudenten;

            Console.WriteLine("Het gemiddelde cijfer is: {0}", gem.ToString("0.00"));
            Console.WriteLine("Het grootste getal is: {0}", cijfers.Max());

            Console.WriteLine();

            foreach (string naam in namen)
            {
                Console.WriteLine($"Student {naam} heeft voor {invoerVak} het cijfer {cijfers[teller]} ");
                teller++;
            }
        }
    }
}
