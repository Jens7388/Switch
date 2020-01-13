using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast et af følgende dyr:");
                Console.WriteLine("Gris");
                Console.WriteLine("Hund");
                Console.WriteLine("Kat");
                Console.WriteLine("Ko");

                string animal = Console.ReadLine().ToLower();
                switch(animal)
                {
                    case "gris":
                        Console.WriteLine("Dette er en gris");
                        break;
                    case "hund":
                        Console.WriteLine("Dette er en hund");
                        break;
                    case "kat":
                        Console.WriteLine("Dette er en kat");
                        break;
                    case "ko":
                        Console.WriteLine("Dette er en ko");
                        break;
                    default:
                        Console.WriteLine("Ukendt dyr, prøv igen");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
