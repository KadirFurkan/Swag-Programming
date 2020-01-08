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
            //Alle variabelen
            int uur;
            int minuten;
            int seconden;
            int uur_Aftrek;
            int min_Aftrek;

            string antwoord_seconden;

            //Hier worden de secondes gevraagd van de gebruiker
            Console.WriteLine("Geef aantal seconden: ");
            antwoord_seconden = Console.ReadLine();

            //Parsen zodat er berekend kan worden
            seconden = int.Parse(antwoord_seconden);

            //Hier wordt alles berekend
            uur = seconden / 3600;
            uur_Aftrek = uur * 3600;
            seconden = seconden - uur_Aftrek;

            minuten = seconden / 60;
            min_Aftrek = minuten * 60;
            seconden = seconden - min_Aftrek;


            Console.WriteLine("{0}:{1}:{2}", uur, minuten, seconden);


        }
    }
}
