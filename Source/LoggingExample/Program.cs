using System;

namespace LoggingExample
{
    class Program
    {
        private static readonly ILogger Logger = new LoggerFacade();

        private static int doe_iets(string wanneer)
        {
            Logger.Log("begonnen met iets");
            // Moeilijke berekening..
            Logger.Log($"Wanneer? {wanneer}!");
            Logger.Log("En klaar met iets!");
            
            return 4; // Random getal, bepaald met dobbelsteen.
        }
        
        private static void doe_nog_iets()
        {
            Logger.Log("begonnen met nog iets");
            // Moeilijke berekening..
            Logger.Log($"druk bezig!");
            Logger.Log("En alweer klaar!");
        }
        
        
        private static void Main(string[] args)
        {
            Logger.Log("Tijd om iets te gaan doen..");
            int value = doe_iets("nu");
            Logger.Log($"Klaar met iets doen, resultaat was: {value}");

            Logger.Log("Tijd om nog iets te gaan doen..");
            doe_nog_iets();
            Logger.Log($"Klaar met nog iets doen");
            
            Logger.Log("Klaar met alles, shutdown in..3..2..1");
        }
    }
}
