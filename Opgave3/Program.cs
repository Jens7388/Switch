using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while(run)
            {
                //Bed brugeren om at trykke på en tast, og læs dette tastetryk
                Console.WriteLine("Tryk på en tast:");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch(keyInfo.Key)
                {
                    case ConsoleKey.A:
                    case ConsoleKey.E:
                    case ConsoleKey.I:
                    case ConsoleKey.O:
                    case ConsoleKey.U:
                    case ConsoleKey.Y:
                        Console.WriteLine("\nDu har indtastet en vokal");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.B:
                    case ConsoleKey.C:
                    case ConsoleKey.D:
                    case ConsoleKey.F:
                    case ConsoleKey.G:
                    case ConsoleKey.H:
                    case ConsoleKey.J:
                    case ConsoleKey.K:
                    case ConsoleKey.L:
                    case ConsoleKey.M:
                    case ConsoleKey.N:
                    case ConsoleKey.P:
                    case ConsoleKey.Q:
                    case ConsoleKey.R:
                    case ConsoleKey.S:
                    case ConsoleKey.T:
                    case ConsoleKey.V:
                    case ConsoleKey.W:
                    case ConsoleKey.X:
                    case ConsoleKey.Z:
                        Console.WriteLine("\nDu har indtastet en konsonant");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.Escape:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("\nUkendt tastetryk");
                        Console.ReadLine();
                        break;
                }           
                Console.Clear();
            }
        }
    }
}
