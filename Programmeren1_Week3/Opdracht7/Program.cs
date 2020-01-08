using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hier wordt de invoer van de gebruiker opgeslagen in de strings
            Console.WriteLine("Vul hier uw gewicht in kg's: ");
            string invoerGewicht = Console.ReadLine();
            Console.WriteLine("Vul hier uw lengte in cm's: ");
            string invoerLengte = Console.ReadLine();
            Console.WriteLine("Wat is uw geslacht: ");
            string geslacht = Console.ReadLine();

            //Hier worden alle strings geparst zodat er gerekend mee kan worden
            double gewicht = double.Parse(invoerGewicht);
            double lengte = double.Parse(invoerLengte);

            //Hier komen alle berekeningen
            double nieuwLengte = lengte / 100;
            double formuleLengte = nieuwLengte * nieuwLengte;
            double BMI = gewicht / formuleLengte;
            double minGewicht;
            double maxGewicht;


            //Hier wordt aan de hand van de ingevoerde geslacht uitgeprint wat een 'gezonde' BMI is
            if (geslacht == "man" || geslacht =="Man")
            {
                Console.WriteLine("Dit is uw BMI: {0}", BMI.ToString("0.00"));
                Console.WriteLine("Voor een man is de gezonde BMI waarde tussen de 20 en 25");
                minGewicht = 20 * formuleLengte;
                maxGewicht = 25 * formuleLengte;
                Console.WriteLine("De 'ideale' gewicht voor uw lengte ligt tussen de {0} en {1}", minGewicht.ToString("0.0"), maxGewicht.ToString("0.0"));
            }
            else if (geslacht == "vrouw" || geslacht == "Vrouw")
            {
                Console.WriteLine("Dit is uw BMI: {0}", BMI.ToString("0.00"));
                Console.WriteLine("Voor een vrouw is de gezonde BMI waarde tussen de 19 en 24");
                minGewicht = 19 * formuleLengte;
                maxGewicht = 24 * formuleLengte;
                Console.WriteLine("De 'ideale' gewicht voor uw lengte ligt tussen de {0} en {1}", minGewicht.ToString("0.0"), maxGewicht.ToString("0.0"));
            }
            else
            {
                Console.WriteLine("Er is een fout opgetreden, probeer het later opnieuw");
            }

        }
    }
}
