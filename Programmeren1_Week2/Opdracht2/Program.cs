using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alle variabelen
            double getal1;
            double getal2;
            double getal3;
            double gem_getallen;

            //Hier worden de getallen opgevraagd van de gebruiker
            Console.WriteLine("Geef een getal:");
            string antwoord_getal1 = Console.ReadLine();
            Console.WriteLine("Geef nog een getal");
            string antwoord_getal2 = Console.ReadLine();
            Console.WriteLine("Geef uw laatste getal");
            string antwoord_getal3 = Console.ReadLine();

            //Hier worden de antwoorden geparst om te rekenen
            getal1 = double.Parse(antwoord_getal1);
            getal2 = double.Parse(antwoord_getal2);
            getal3 = double.Parse(antwoord_getal3);
            gem_getallen = (getal1 + getal2 + getal3) / 3;

            //Hier komt het gemiddelde van de 3 getallen
            Console.WriteLine("Het gemiddelde van de 3 getallen is: {0}", gem_getallen);


        }
    }
}
