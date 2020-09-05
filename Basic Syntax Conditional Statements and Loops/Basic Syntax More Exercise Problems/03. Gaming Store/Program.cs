using System;

namespace _03_Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {           
            double moneyBalance = double.Parse(Console.ReadLine());

            string gameCommand = Console.ReadLine();
            double moneySpend = 0;
            double gamePrice = 0;

            while (gameCommand != "Game Time")
            {
                switch (gameCommand)
                {
                    case "OutFall 4": gamePrice = 39.99;
                        break;
                    case "CS: OG": gamePrice = 15.99;
                        break;
                    case "Zplinter Zell": gamePrice = 19.99;
                        break;
                    case "Honored 2": gamePrice = 59.99;
                        break;
                    case "RoverWatch": gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99;
                        break;
                    default: Console.WriteLine("Not Found");
                        gameCommand = Console.ReadLine();
                        continue;
                }

                if (moneyBalance < gamePrice)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (moneyBalance >= gamePrice)
                {
                    moneySpend += gamePrice;
                    moneyBalance -= gamePrice;
                    Console.WriteLine($"Bought {gameCommand}");
                }

                if (moneyBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                gameCommand = Console.ReadLine();
            }

            if (gameCommand == "Game Time")
            {
                Console.WriteLine($"Total spent: ${moneySpend:F2}. Remaining: ${moneyBalance:F2}");
            }
        }
    }
}
