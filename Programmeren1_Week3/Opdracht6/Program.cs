using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hier wordt de score gevraagd en geparst zodat ermee berekend kan worden
            Console.WriteLine("Type your score of Programming 1 (0-100):");
            string invoer = Console.ReadLine();
            int getal = int.Parse(invoer);

            if (getal >= 90 && getal < 100)
            {
                Console.WriteLine("Grade: A");
                Console.WriteLine("Course passed!");
            }
            else if (getal >= 80 && getal <90)
            {
                Console.WriteLine("Grade: B");
                Console.WriteLine("Course passed!");
            }
            else if (getal >= 70 && getal < 80)
            {
                Console.WriteLine("Grade: C");
                Console.WriteLine("Course passed!");
            }
            else if (getal >= 60 && getal < 70)
            {
                Console.WriteLine("Grade: D");
                Console.WriteLine("Course not passed");
            }
            else if(getal < 60 && getal > 0)
            {
                Console.WriteLine("Grade: F");
                Console.WriteLine("Course not passed");
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }
    }
}
