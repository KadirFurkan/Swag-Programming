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
            Console.Write("Voer jaartal in: ");
            int invoerJaar = int.Parse(Console.ReadLine());

            while (invoerJaar != 0)
            {
                if (invoerJaar % 400 == 0 || invoerJaar % 4 == 0 && invoerJaar % 100 != 0)
                {
                    Console.WriteLine("{0} is een schrikkeljaar.", invoerJaar);
                    Console.Write("Voer jaartal in: ");
                    invoerJaar = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("{0} is geen schrikkeljaar.", invoerJaar);
                    invoerJaar = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
