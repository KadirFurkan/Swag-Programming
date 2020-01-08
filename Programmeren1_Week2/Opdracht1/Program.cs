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
            //Alle variabelen
            string vraagPrijs;
            string vraagBTW;
            double prijs;
            double btw;
            double tot_Prijs;
            double berekening_btw;

            //Hier wordt de prijs gevraagd van de gebruiker
            Console.WriteLine("Wat is de prijs?");
            vraagPrijs = Console.ReadLine();

            //Hier wordt percentage BTW gevraagd
            Console.WriteLine("Wat is de percentage BTW?");
            vraagBTW = Console.ReadLine();

            //Hier worden de inputs omgezet in een double om ermee te rekenen
            prijs = double.Parse(vraagPrijs);
            btw = double.Parse(vraagBTW);
            berekening_btw = btw / 100;
            tot_Prijs = (prijs * berekening_btw) + prijs;
            tot_Prijs.ToString("0.00");

            //Hier komt het resultaat van de som
            Console.WriteLine("prijs: {0} , btw: {1} , totaal: {2}", prijs, btw, tot_Prijs);

            //Hier een readkey
            Console.ReadKey();




        }
    }
}
