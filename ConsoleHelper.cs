using System;





namespace FlowControl
{
    internal class ConsoleHelper
    {
        public static void PressToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}