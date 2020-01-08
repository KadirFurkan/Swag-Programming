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
            //Hier maak ik een array aan
            int[] getallen = new int[20];

            int teller = 0;
            int aantalKeer = 0;

            Console.Write("Geef een getal <0 = stoppen> : ");
            int invoer = int.Parse(Console.ReadLine());
            getallen[teller] = invoer;
            teller++;

            while (invoer != 0)
            {
                Console.Write("Geef een getal <0 = stoppen> : ");
                invoer = int.Parse(Console.ReadLine());
                getallen[teller] = invoer;
                teller++;
            }

            Console.WriteLine();
            Console.Write("Geef de zoekwaarde: ");
            int zoekWaarde = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("De zoekwaarde is: {0}", zoekWaarde.ToString());

            foreach (int getal in getallen)
            {
                if (getal == zoekWaarde)
                {
                    aantalKeer ++;
                }
            }
            Console.WriteLine($"De zoekwaarde komt {aantalKeer} voor");
        }
    }
}
