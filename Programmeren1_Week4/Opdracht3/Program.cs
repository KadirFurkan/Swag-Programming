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
            Console.Write("Voer getal in: ");
            string invoerGetal = Console.ReadLine();
            int getal = int.Parse(invoerGetal);

            int teller = 1;
            int vijfdeGetal = 0;

            while (getal != 0)
            {
                Console.Write("Voer getal in: ");
                getal = int.Parse(Console.ReadLine());
                teller++;

                    if (teller == 5 || teller % 5 == 0)
                    {
                        vijfdeGetal = vijfdeGetal + getal;
                    }
            }
            Console.WriteLine("De som van het 5e, 10e, 15e, etc is: {0}", vijfdeGetal);
        }
    }
}
