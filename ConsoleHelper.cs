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

        public static int ValidAge(string message)
        {
            Console.Write(message);

            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 125)
            {
                Console.WriteLine();
                Console.Write("Ogiltig ålder. Ange en siffra mellan 0 och 125: ");
            }

            return age;
            }

            public static int Gruppstorlek(string message)
            {
            Console.Write(message);

            int antal;
            while (!int.TryParse(Console.ReadLine(), out antal) || antal <= 0 || antal > 150)
            {
                Console.WriteLine();

                if (antal > 150)
                {
                    Console.WriteLine("Ni verkar vara ett större sällskap!");
                    Console.WriteLine("För grupper över 150 personer, kontakta biografen för specialbokning.");
                    Console.WriteLine();
                }

                Console.Write("Ogiltigt antal. Ange ett tal mellan 1 och 150: ");
            }

            return antal;
        }

    }  
}