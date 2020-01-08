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
            //Hier zijn alle arrays
            int[] kleuters = new int[10];
            int[] kinderen = new int[10];
            int[] volwassenen = new int[10];

            //Alle integers die van pas komen voor de uitkomst van kleuters
            int tellerKleuters = 0;
            int totaalKleuters = 0;

            //Alle integers die van pas komen voor de uitkomst van kinderen
            int tellerKinderen = 0;
            int totaalKinderen = 0;
            int test = 7;

            //Alle integers die van pas komen voor de uitkomst van volwassenen
            int tellerVolwassenen = 0;
            int totaalVolwassenen = 0;

            Console.Write("Geef een leeftijd <0 = stoppen> : ");
            int invoer = int.Parse(Console.ReadLine());

            if (invoer > 0 && invoer < 5)
            {
                kleuters[tellerKleuters] = invoer;
                totaalKleuters = totaalKleuters + invoer;
                tellerKleuters++;
            }
            else if (invoer > 4 && invoer < 18)
            {
                kinderen[tellerKinderen] = invoer;
                totaalKinderen = totaalKinderen + invoer;
                tellerKinderen++;
            }
            else if (invoer > 17 )
            {
                volwassenen[tellerVolwassenen] = invoer;
                totaalVolwassenen = totaalVolwassenen + invoer;
                tellerVolwassenen++;
            }
            while (invoer != 0)
            {
                Console.Write("Geef een leeftijd <0 = stoppen> : ");
                invoer = int.Parse(Console.ReadLine());

                if (invoer > 0 && invoer < 5)
                {
                    kleuters[tellerKleuters] = invoer;
                    totaalKleuters = totaalKleuters + invoer;
                    tellerKleuters++;
                }
                else if (invoer > 4 && invoer < 18)
                {
                    kinderen[tellerKinderen] = invoer;
                    totaalKinderen = totaalKinderen + invoer;
                    tellerKinderen++;
                }
                else if (invoer > 17)
                {
                    volwassenen[tellerVolwassenen] = invoer;
                    totaalVolwassenen = totaalVolwassenen + invoer;
                    tellerVolwassenen++;
                }
            }

            Console.WriteLine();
            
            //Hier is de uitkomst van de kleuters
            Console.WriteLine("KLEUTERS");
            for (int i = 1; i <= tellerKleuters; i++)
            {
                Console.WriteLine("Kleuter {0} is {1} jaar", i, kleuters[i - 1]);
            }

            double gemKleuters = (double)totaalKleuters / tellerKleuters; 
            Console.WriteLine("De gemiddelde kleuter is: {0}", gemKleuters);
            Console.WriteLine("De oudste kleuter is: {0}", kleuters.Max());

            Console.WriteLine();

            //Hier is de uitkomst van de kinderen
            Console.WriteLine("KINDEREN");
            for (int i = 1; i <= tellerKinderen; i++)
            {
                Console.WriteLine("Kind {0} is {1} jaar", i, kinderen[i - 1]);
            }

            double gemKinderen = (double)totaalKinderen / tellerKinderen;
            Console.WriteLine("Het gemiddelde kind is: {0}", gemKinderen);
            Console.WriteLine("Het oudste kind is: {0}", kinderen.Max());

            Console.WriteLine();

            //Hier is de uitkomst van de volwassenen
            Console.WriteLine("VOLWASSENEN");
            for (int i = 1; i <= tellerVolwassenen; i++)
            {
                Console.WriteLine("Volwassene {0} is {1} jaar", i, volwassenen[i - 1]);
            }

            double gemVolwassenen = (double)totaalVolwassenen / tellerVolwassenen;
            Console.WriteLine("De gemiddelde volwassene is: {0}", gemVolwassenen);
            Console.WriteLine("De oudste volwassene is: {0}", volwassenen.Max());
        }
    }
}
