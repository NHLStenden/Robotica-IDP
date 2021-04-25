using System;

namespace Logging_not_portable
{
    class Program
    {
        private static int doe_iets(string wanneer)
        {
            Console.WriteLine("begonnen met iets");
            // Moeilijke berekening..
            Console.WriteLine($"Wanneer? {wanneer}!");
            Console.WriteLine("En klaar met iets!");
        
            return 4; // Random getal, bepaald met dobbelsteen.
        }
    
        private static void doe_nog_iets()
        {
            Console.WriteLine("begonnen met nog iets");
            // Moeilijke berekening..
            Console.WriteLine($"druk bezig!");
            Console.WriteLine("En alweer klaar!");
        }
    
    
        private static void Main(string[] args)
        {
            Console.WriteLine("Tijd om iets te gaan doen..");
            int value = doe_iets("nu");
            Console.WriteLine($"Klaar met iets doen, resultaat was: {value}");

            Console.WriteLine("Tijd om nog iets te gaan doen..");
            doe_nog_iets();
            Console.WriteLine($"Klaar met nog iets doen");
        
            Console.WriteLine("Klaar met alles, shutdown in..3..2..1");
        }
    }
}