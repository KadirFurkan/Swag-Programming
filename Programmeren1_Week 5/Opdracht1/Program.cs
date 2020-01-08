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
            //Hier maak je een array aan
            int[] getallen = new int[20];

            //Hier heb je de random getal
            Random rnd = new Random();

            int totaal = 0;
            int teller = 0;

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = rnd.Next(0, 200);
                totaal += getallen[i];
                Console.WriteLine("Element " + i + " is: {0}", getallen[i]);
            }

            Console.WriteLine();
            double gemTotaal = (double)totaal / getallen.Length;
            Console.WriteLine("Het gemiddelde van de getallen zijn: {0}", gemTotaal);
            Console.WriteLine();

            foreach (int getal in getallen)
            {
                double verschilGem = gemTotaal - getal ;
                Console.WriteLine("Verschil tussen het gemiddelde en element {0} is: {1}", teller, Math.Abs(verschilGem));
                teller++;
            }
        }
    }
}
