using System;

namespace _07_Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coinInput = Console.ReadLine();
            double currenCoin = 0;
            double totalCoinsValue = 0;

            while (coinInput != "Start")
            {
                currenCoin = double.Parse(coinInput);

                if (currenCoin != 0.1 && currenCoin != 0.2 && currenCoin != 0.5
                    && currenCoin != 1 && currenCoin != 2)
                {
                    Console.WriteLine($"Cannot accept {currenCoin}");
                }
                else
                {
                    totalCoinsValue += currenCoin;
                }

                coinInput = Console.ReadLine();
            }

            string productInput = Console.ReadLine();

            while (productInput != "End")
            {
                double currentPrice = 0;

                switch (productInput)
                {
                    case "Nuts": currentPrice = 2.0;
                        break;
                    case "Water": currentPrice = 0.7;
                        break;
                    case "Crisps": currentPrice = 1.5;
                        break;
                    case "Soda": currentPrice = 0.8;
                        break;
                    case "Coke": currentPrice = 1.0;
                        break;
                    default: Console.WriteLine("Invalid product");
                        productInput = Console.ReadLine();
                        continue;
                }

                if (totalCoinsValue >= currentPrice)
                {
                    totalCoinsValue -= currentPrice;
                    Console.WriteLine($"Purchased {productInput.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                productInput = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalCoinsValue:F2}");
        }
    }
}
