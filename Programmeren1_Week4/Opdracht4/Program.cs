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
            Console.Write("1, ");

            int getal1 = 0;
            int getal2 = 1;

            for (int i = 2; i <= 20; i++)
            {
                int getal3 = (getal1 + getal2);

                Console.Write(getal3 + ", ");

                getal1 = getal2;
                getal2 = getal3;
            }
        }
    }
}
