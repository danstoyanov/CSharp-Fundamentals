using System;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupNumInput = int.Parse(Console.ReadLine());
            string groupTypeInput = Console.ReadLine();
            string vacionDayInput = Console.ReadLine();

            double pricePerOnePerson = 0;

            switch (groupTypeInput)
            {
                case "Students":
                    switch (vacionDayInput)
                    {
                        case "Friday":
                            pricePerOnePerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerOnePerson = 9.80;
                            break;
                        case "Sunday":
                            pricePerOnePerson = 10.46;
                            break;
                    }

                    break;
                case "Business":
                    switch (vacionDayInput)
                    {
                        case "Friday":
                            pricePerOnePerson = 10.90;
                            break;
                        case "Saturday":
                            pricePerOnePerson = 15.60;
                            break;
                        case "Sunday":
                            pricePerOnePerson = 16.00;
                            break;
                    }
                    break;
                case "Regular":
                    switch (vacionDayInput)
                    {
                        case "Friday":
                            pricePerOnePerson = 15.00;
                            break;
                        case "Saturday":
                            pricePerOnePerson = 20.00;
                            break;
                        case "Sunday":
                            pricePerOnePerson = 22.50;
                            break;
                    }
                    break;
            }

            double totalPrice = groupNumInput * pricePerOnePerson;

            if (groupTypeInput == "Students" && groupNumInput >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (groupTypeInput == "Business" && groupNumInput >= 100)
            {
                double priceDiscount = 10 * pricePerOnePerson;
                totalPrice -= priceDiscount;
            }
            else if (groupTypeInput == "Regular" && groupNumInput >= 10 && groupNumInput <= 20)
            {
                totalPrice *= 0.95;
            }

                Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
