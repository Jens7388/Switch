using System;

namespace Opgave4
{
    class Program
    {
        enum Importance
        {
            None,
            Trivial,
            Regular,
            Important,
            Critical
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Beskriv vigtigheden af den opståede fejl:");
                Console.WriteLine("None");
                Console.WriteLine("Trivial");
                Console.WriteLine("Regular");
                Console.WriteLine("Important");
                Console.WriteLine("Critical");

                string input = Console.ReadLine();
                Enum.TryParse(input, true, out Importance importance);

                switch(importance)
                {
                    case Importance.None:
                    default:
                        Console.WriteLine("Det lyder ligegyldigt");
                        break;
                    case Importance.Trivial:
                        Console.WriteLine("Det sætter jeg praktikanten til at ordne");
                        break;
                    case Importance.Regular:
                        Console.WriteLine("Mon ikke det går....");
                        break;
                    case Importance.Important:
                        Console.WriteLine("Jeg drikker lige en kop kaffe, så er jeg der");
                        break;
                    case Importance.Critical:
                        Console.WriteLine("Oh shit....");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
