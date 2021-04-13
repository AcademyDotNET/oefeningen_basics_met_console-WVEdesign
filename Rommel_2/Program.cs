using System;

namespace Rommel_2
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Fav Eten?");
            string eten = Console.ReadLine();

            Console.WriteLine("Fav Auto?");
            string auto = Console.ReadLine();

            Console.WriteLine("Fav Boek?");
            string boek = Console.ReadLine();

            Console.WriteLine("Fav Kleur?");
            string kleur = Console.ReadLine();

            Solution1(eten, auto, boek, kleur);
            Solution2(eten, auto, boek, kleur);

            Console.ReadLine();


        }


        public static void Solution1(string eten, string auto, string boek, string kleur)
        {
            Console.WriteLine($"Je favoriete kleur is {eten}. Je eet graag {auto}. auto {boek}. boek {kleur}");


        }

        public static void Solution2(string eten, string auto, string boek, string kleur)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Je fav kleur is {eten}.");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Je eet graag {auto}.");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Lievelingsfilm {boek}.");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Je fav boek is {kleur}.");

            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}




