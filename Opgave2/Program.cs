using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast et familiemedlem (fx mor, bedstefar eller lignende):");
                string relative = Console.ReadLine().ToLower();

                switch(relative)
                {
                    case "mor":
                    case "far":
                        Console.WriteLine("Du har indtastet et 2. generationsmedlem af familien");
                        break;
                    case "mormor":
                    case "morfar":
                    case "bedstemor":
                    case "bedstefar":
                    case "farfar":
                    case "farmor":
                        Console.WriteLine("Du har indtastet et 3. generationsmedlem af familien");
                        break;
                    default:
                        Console.WriteLine("Du har indtastet et ukendt familiemedlem");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
