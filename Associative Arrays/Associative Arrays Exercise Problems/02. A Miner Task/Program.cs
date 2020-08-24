using System;
using System.Collections.Generic;

namespace _02_A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            string resourse = string.Empty;

            var inventory = new Dictionary<string, int>();

            while ((resourse = Console.ReadLine()) != "stop")
            {
                int value = int.Parse(Console.ReadLine());

                if (!inventory.ContainsKey(resourse))
                {
                    inventory.Add(resourse, value);
                }
                else
                {
                    inventory[resourse] += value;
                }
            }

            foreach (var pair in inventory)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}