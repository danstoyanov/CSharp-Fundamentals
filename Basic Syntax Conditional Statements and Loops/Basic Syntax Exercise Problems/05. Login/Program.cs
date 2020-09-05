using System;

namespace _05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputUsername = Console.ReadLine();
            string correctPassword = string.Empty;

            for (int i = inputUsername.Length - 1; i >= 0; i--)
            {
                correctPassword += inputUsername[i];
            }

            string password = Console.ReadLine();
            int passwordLimit = 0;

            while (password != correctPassword) 
            {
                passwordLimit++;

                if (passwordLimit == 4)
                {
                    Console.WriteLine($"User {inputUsername} blocked! ");
                    break;
                }

                Console.WriteLine($"Incorrect password. Try again.");

                password = Console.ReadLine();
            } 
            
            if (password == correctPassword)
            {
                Console.WriteLine($"User {inputUsername} logged in. ");
            }
        }
    }
}
