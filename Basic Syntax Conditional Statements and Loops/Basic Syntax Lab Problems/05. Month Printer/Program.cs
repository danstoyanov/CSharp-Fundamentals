using System;

namespace _05_Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthInput = int.Parse(Console.ReadLine());
            string monthABC = "";

            switch (monthInput)
            {
                case 1:
                    monthABC = "January";
                    break;
                case 2:
                    monthABC = "February";
                    break;
                case 3:
                    monthABC = "March";
                    break;
                case 4:
                    monthABC = "April";
                    break;
                case 5:
                    monthABC = "May";
                    break;
                case 6:
                    monthABC = "June";
                    break;
                case 7:
                    monthABC = "July";
                    break;
                case 8:
                    monthABC = "August";
                    break;
                case 9:
                    monthABC = "September";
                    break;
                case 10:
                    monthABC = "October";
                    break;
                case 11:
                    monthABC = "November";
                    break;
                case 12:
                    monthABC = "December";
                    break;
                default:
                    monthABC = "Error!";
                    break;
            }

            Console.WriteLine(monthABC);
        }
    }
}