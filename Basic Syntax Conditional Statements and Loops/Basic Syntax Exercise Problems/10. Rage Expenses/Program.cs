using System;

namespace _10_Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.0 Whe have to input: headset, mouse, keyboard and display and their prices ! int and double types ...
            // 2.0 Whe have to make lostGameCounter ! ===> for loop ! 
            // 3.0 You must to know ----> (Every second) lost game, Pesho trashes his  ===== headset.
            // 4.0 And (Every third) lost game, Pesho trashes his   ===== mouse.
            // !!!! !  both his mouse and headset in the same lost game, he also trashes his === keyboard
            // Every second time, when he trashes his keyboard, he also trashes    === his display. 

            // FINAL : Allowed working time / memory: 100ms / 16MB.
            // Output : As output you must print Pesho`s total expenses: "Rage expenses: {expenses} lv."

            int lostGamesInput = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headset = 0;
            int mouse = 0;
            int keyboard = 0;
            int display = 0;

            for (int lostGameCount = 1; lostGameCount <= lostGamesInput; lostGameCount++)
            {
                if (lostGameCount % 2 == 0)
                {
                    headset++;
                }

                if (lostGameCount % 3 == 0)
                {
                    mouse++;
                }

                if (lostGameCount % 3 == 0 && lostGameCount % 2 == 0)
                {
                    keyboard++;

                    if (keyboard % 2 == 0)
                    {
                        display++;
                    }
                }
                // we must add the display !! Every second time, when he trashes his keyboard, he also trashes display
            }

            double totalPrice = (headset * headSetPrice) + (mouse * mousePrice) + (keyboard * keyboardPrice) + (display * displayPrice);

            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
        }
    }
}
