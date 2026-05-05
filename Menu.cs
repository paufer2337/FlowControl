using System;





namespace FlowControl
{
    internal class Menu
    {

        private readonly Cinema _cinema = new Cinema();
        private readonly TextLoop _txtLoop = new TextLoop();

        public void Start()
        {
            
            bool running = true;

            while (running)
            {
                Console.WriteLine("Välkommen till huvudmenyn.");
                Console.WriteLine("Skriv en siffra för att välja funktion.");
                Console.WriteLine("0 = Avsluta");
                Console.WriteLine("1 = Ungdom eller pensionär");
                Console.WriteLine("2 = Pris för sällskap");
                Console.WriteLine("3 = Upprepa tio gånger");
                Console.WriteLine("4 = Det tredje ordet");
                Console.Write("Ditt val: ");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        running = false;
                        Console.WriteLine("Programmet avslutas.");
                        break;

                    case "1":
                        _cinema.UngdomEllerPensionar();
                        break;

                    case "2":
                        _cinema.PrisForSallskap();
                        break;

                    case "3":
                        _txtLoop.UpprepaTioGanger();
                        break;

                    case "4":
                        _txtLoop.DetTredjeOrdet();
                        break;

                    default:
                        Console.WriteLine("Felaktig input, välj 0-4.");
                        break;
                }
            
                Console.WriteLine();
                ConsoleHelper.PressToContinue();
            }
        }

    }    
}