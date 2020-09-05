using System;

namespace _07_Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayTypeInput = Console.ReadLine().ToLower();
            int ageInput = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            // We finish1 this problem but I don't understand why we need to 
            // to make the exercise to this way ??? It will be good to reapeat this exercise and ask the trainer !

            if (dayTypeInput == "weekday")
            {
                if ((ageInput >= 0 && ageInput <= 18) || (ageInput > 64 && ageInput <= 122))
                {
                    ticketPrice = 12;
                }
                else if (ageInput > 18 && ageInput <= 64)
                {
                    ticketPrice = 18;
                }
            }
            if (dayTypeInput == "weekend")
            {
                if ((ageInput >= 0 && ageInput <= 18) || (ageInput > 64 && ageInput <= 122))
                {
                    ticketPrice = 15;
                }
                else if (ageInput > 18 && ageInput <= 64)
                {
                    ticketPrice = 20;
                }
            }
            if (dayTypeInput == "holiday")
            {
                if (ageInput >= 0 && ageInput <= 18)
                {
                    ticketPrice = 5;
                }
                else if (ageInput > 18 && ageInput <= 64)
                {
                    ticketPrice = 12;
                }
                else if (ageInput > 64 && ageInput <= 122)
                {
                    ticketPrice = 10;
                }
            }

            if (ticketPrice != 0)
            {
                Console.WriteLine($"{ticketPrice}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
