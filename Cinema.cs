using System;

namespace FlowControl
{
    internal class Cinema
    {

        public void UngdomEllerPensionar()
        {
            
            int alder = ConsoleHelper.ValidAge("Ange ålder: ");
            
            if (alder < 5 || alder > 100)
            {
                Console.WriteLine("Gratis inträde!");
            }
            else if (alder < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
            }
            else if (alder > 64)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr");
            }
        }

        public void PrisForSallskap()
        {
            
            int antal = ConsoleHelper.Gruppstorlek("Hur många personer är ni? ");

            int total = 0;

            for (int i = 1; i <= antal; i++)
            {
                Console.Write($"Ange ålder för person {i}: ");
                string? alderInput = Console.ReadLine();

                if (!int.TryParse(alderInput, out int alder) || alder < 0)
                {
                    Console.WriteLine("Ogiltig ålder.");
                    return;
                }

                if (alder < 5 || alder > 100)
                {
                    Console.WriteLine($"Person {i}: Gratis");
                }
                else if (alder < 20)
                {
                    total += 80;
                }
                else if (alder > 64)
                {
                    total += 90;
                }
                else
                {
                    total += 120;
                }
            }

            Console.WriteLine($"Antal personer: {antal}");
            Console.WriteLine($"Totalkostnad: {total} kr");
        }
    }
}   