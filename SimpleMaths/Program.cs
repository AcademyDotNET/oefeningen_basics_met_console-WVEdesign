using System;
using SimpleMaths;

namespace SimpleMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Pi: {0} \ne: {1}", Math.PI, Math.E); // using Math constants

            //1. SimpleMaths
            Console.WriteLine("1. SimpleMaths:\n");
            int a = -1 + 4 * 6;
            double b = -1.1 + 4 * 6;
            int c = (35 + 5) % 7;
            double d = (35.1 + 5) % 7;
            int e = (14 + -4 * 6 / 11);
            double f = (14.1 + -4 * 6 / 11);
            int g = (2 + 15 / 6 * 1 - 7 % 2);
            double h = (2.1 + 15 / 6 * 1 - 7 % 2);

            Console.WriteLine("Int representatie: \n{0}\n{1}\n{2}\n{3}\n", a, c, e, g);
            Console.WriteLine("Double representatie: \n{0}\n{1}\n{2}\n{3}\n", b, d, f, h);

            //2. Gemiddelde September, Oktober, November
            int september = 241;
            int oktober = 250;
            int november = 260;
            double average = (september + oktober + november) / 3.0;

            Console.WriteLine("2. Gemiddelde van {0}, {1} en {2} is {3}\n", september, oktober, november, average);

            //3. Euro2Dollar conversie
            Console.WriteLine("3. Euro2Dollar conversie\n");

            Console.WriteLine("Geeft aantal Euro's te converteren naar dollars:");
            double euros = Convert.ToInt32(Console.ReadLine());
            double wisselKoers = 1.17;
            double dollars = euros * wisselKoers;

            Console.WriteLine("\n{0} Euro is gelijk aan {1} Amerikaanse dollar\n", euros, dollars);
            Console.ReadKey();

            //4. Tafel en Console.Clear()
            Console.WriteLine("4. Tafel en Console.Clear\n");

            int tafel = 411;
            int n = 1;
            int multiplied;

            Console.Clear();

            while (n <= 10)
            {
                multiplied = n * tafel;
                Console.WriteLine("{0} * {1} = {2}\n", n, tafel, multiplied);
                n++;
                Console.WriteLine("Druk op enter voor de volgende lijn.\n");
                Console.ReadKey();
                Console.Clear();
            }

            //5. Kill/Death-ratio
            Console.WriteLine("5. Kill/Death-ratio\n");

            double kills = 879952;
            double deaths = 5002;

            double ratio = kills / deaths;

            Console.WriteLine("Kill {0} / Death {1} ratio = {2}\n", kills, deaths, ratio);

            //6. Gewicht in space
            Console.WriteLine("6. Gewicht in space\n");

            double massa = 70.5; // == 70,5kg

            double mercurius = 0.38 * massa;
            double venus = 0.91 * massa;
            double aarde = 1.00 * massa;
            double mars = 0.38 * massa;
            double jupiter = 2.34 * massa;
            double saturnus = 1.06 * massa;
            double uranus = 0.92 * massa;
            double neptunus = 1.19 * massa;
            double pluto = 0.06 * massa;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Je weegt op Mercurius {0}kg\n", mercurius);
            Console.WriteLine("Je weegt op Venus {0}kg\n", venus);
            Console.WriteLine("Je weegt op Aarde {0}kg\n", aarde);
            Console.WriteLine("Je weegt op Mars {0}kg\n", mars);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Je weegt op Jupiters {0}kg\n", jupiter);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Je weegt op Saturnus {0}kg\n", saturnus);
            Console.WriteLine("Je weegt op Uranus {0}kg\n", uranus);
            Console.WriteLine("Je weegt op Neptunus {0}kg\n", neptunus);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Je weegt op Pluto {0}kg\n", pluto);
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ReadKey();

        }
    }
}
