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
            //Hier wordt de array aangemaakt en aantal waardes geschreven
            int[] getallen = new int[20];

            //Hier maak ik de random waarde aan
            Random rnd = new Random();

            int teller = 0;


            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = rnd.Next(0, 150);
                Console.WriteLine("Getal {0} van de array is: {1} ", i, getallen[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Het kleinste getal is: {0}", getallen.Min());
        }
    }
}
