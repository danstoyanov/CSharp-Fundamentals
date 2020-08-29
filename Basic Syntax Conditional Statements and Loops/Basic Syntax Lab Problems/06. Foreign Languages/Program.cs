using System;

namespace _06_Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryNameInput = Console.ReadLine();
            string languageType = "";

            if (countryNameInput == "USA" || countryNameInput == "England")
            {
                languageType = "English";
            }
            else if (countryNameInput == "Spain" || countryNameInput == "Argentina" || countryNameInput == "Mexico")
            {
                languageType = "Spanish";
            }
            else
            {
                languageType = "unknown";
            }

            Console.WriteLine(languageType);
        }
    }
}
