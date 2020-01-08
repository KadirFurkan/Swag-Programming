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
            Console.WriteLine("Kies een getal tussen 1 en 4");
            string invoer = Console.ReadLine();
            int invoerGetal = int.Parse(invoer);

            switch (invoerGetal)
            {
                case 1:
                    Console.WriteLine("Het getal is klaveren");
                    break;
                case 2:
                    Console.WriteLine("Het getal is ruiten");
                    break;
                case 3:
                    Console.WriteLine("Het getal is harten");
                    break;
                case 4:
                    Console.WriteLine("Het getal is schoppen");
                    break;
                default:
                    Console.WriteLine("Verkeerde waarde, programma sluit nu af.");
                    break;
            }
        }
    }
}
