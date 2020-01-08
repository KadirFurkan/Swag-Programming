using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hier wordt de invoer van de gebruiker opgeslagen in de strings
            Console.WriteLine("Vul aantal werkuren in: ");
            string invoerWerkuren = Console.ReadLine();
            Console.WriteLine("Hoe oud is de metaaldraaibank? ");
            string invoerOud = Console.ReadLine();
            Console.WriteLine("Hoeveel storingen heeft het tot nu toe gehad? ");
            string invoerStoringen = Console.ReadLine();

            //Hier worden de strings geparst in integers
            int werkUren = int.Parse(invoerWerkuren);
            int jaarOud = int.Parse(invoerOud);
            int aantalStoringen = int.Parse(invoerStoringen);

            //Hier komt de if-else code
            if (werkUren > 10000 || jaarOud > 7 || aantalStoringen > 25)
            {
                Console.WriteLine("De metaaldraaibank moet vervangen worden. Vraag naar de teamleider voor Error:FAIL");
            }
            else
            {
                Console.WriteLine("De metaaldraaibank hoeft niet vervangen te worden.");
            }
        }
    }
}
