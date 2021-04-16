using System;

namespace LoggingExample
{
    class Program
    {
        private static ILogger logger = new AsyncFileLogger();
        private static int doe_iets(string wanneer)
        {
            logger.Log("begonnen met iets");
            // Moeilijke berekening..
            logger.Log($"Wanneer? {wanneer}!");
            logger.Log("En klaar met iets!");
            
            return 4; // Random getal, bepaald met dobbelsteen.
        }
        
        private static int doe_nog_iets()
        {
            logger.Log("begonnen met nog iets");
            // Moeilijke berekening..
            logger.Log($"druk bezig!");
            logger.Log("En alweer klaar!");
            
            return 4; // Random getal, bepaald met dobbelsteen.
        }
        
        
        private static void Main(string[] args)
        {
            logger.Log("Tijd om iets te gaan doen..");
            int value = doe_iets("nu");
            logger.Log($"Klaar met iets doen, resultaat was: {value}");

            logger.Log("Tijd om nog iets te gaan doen..");
            doe_nog_iets();
            logger.Log($"Klaar met nog iets doen");
            
            logger.Log("Klaar met alles, shutdown in..3..2..1");
        }
    }
}
