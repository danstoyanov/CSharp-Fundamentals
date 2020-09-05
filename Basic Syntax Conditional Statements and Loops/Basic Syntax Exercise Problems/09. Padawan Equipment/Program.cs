using System;

namespace _09_Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyInput = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double belstPrice = double.Parse(Console.ReadLine());

            // 1. must find the lighsaber Price => lightsaberPrice * students Count
            // 1.2 must find 10 % more lightSaber => studentsCount --- 10 %  !!! Must be rounded by biggest integer !
            //      rounded up to the next integer !

            // 2 must find the robes Price => robes * students Count

            // 3.must find the belst Price => belstPrice * students Count.
            // 3.2 And if students % 6 == 0, every sixth belt is for free !

            // First output result : 3 + 4 + 6 = 13.00, check it !
            // Second output reslut : 564 + 168 + 105 = 837.00, check it ! 

            double lightSabersMoney = lightsaberPrice * Math.Ceiling(studentsCount + (studentsCount * 1.0 * 0.10)); // 3
            double robesMoney = robesPrice * (studentsCount * 1.0); // 4
            double beltsMoney = 0;
            double freeBelstCount = 0;

            for (int currentCount = 1; currentCount <= studentsCount; currentCount++)
            {
                if (currentCount % 6 == 0)
                {
                    freeBelstCount++;
                }

                beltsMoney = belstPrice * (studentsCount - freeBelstCount);
            }

            double totalMoney = lightSabersMoney + robesMoney + beltsMoney;

            if (totalMoney <= moneyInput)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalMoney - moneyInput:F2}lv more.");
            }
        }
    }
}
