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
            //Hier wordt richtgetal bepaald door de gebruiker
            Console.Write("Geef het richtgetal: ");
            string invoerRichtgetal = Console.ReadLine();
            int richtgetal = int.Parse(invoerRichtgetal);
            int teller = 0;

            Console.Write("Voer uw getal in: ");
            string invoergetal = Console.ReadLine();
            int getal = int.Parse(invoergetal);

            while (getal != 0)
            {
                if (getal == richtgetal)
                {
                    teller++;
                }

                Console.Write("Voer uw getal in: ");
                getal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Het aantal getallen dat gelijk was aan het richtgetal is: {0}", teller);
        }
    }
}
