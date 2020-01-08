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
            Console.WriteLine("Voor uw getal in:");
            string invoer1 = Console.ReadLine();
            int getal1 = int.Parse(invoer1);

            Console.WriteLine("Voor uw tweede getal in:");
            string invoer2 = Console.ReadLine();
            int getal2 = int.Parse(invoer2);

            if (getal1 > getal2)
            {
                int grootsteGetal = getal1;
                int kleinsteGetal = getal2;
                Console.WriteLine("Uw grootste getal is: {0}", grootsteGetal);
                Console.WriteLine("Uw kleinste getal is: {0}", kleinsteGetal);
            }
            else
            {
                int grootsteGetal = getal2;
                int kleinsteGetal = getal1;
                Console.WriteLine("Uw grootste getal is: {0}", grootsteGetal);
                Console.WriteLine("Uw kleinste getal is: {0}", kleinsteGetal);
            }
        }
    }
}
