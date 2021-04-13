using System;

namespace MyFirstProject
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello World!");
            Console.Write("Hello World! ");
            Console.Write("Hello World!");
            string name = UserInput();
            MijnEersteMethode(name);
        }


        public static void MijnEersteMethode(string name)
        {
            Console.WriteLine(name);
        }


        public static string UserInput()
        {
            Console.WriteLine("Geef Uw Naam");
           string name = Console.ReadLine();
            return name;
        }
    }

}
