using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    public static class UserInput
    {
        public static int GetIntegerInput(string prompt, int maxRange)
        {
            do
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out int value) && value > 0 && value <= maxRange){
                    return value;
                }
                else
                {
                    Console.WriteLine($"Invalid input. Please enter a number between 1 and {maxRange}.");
                }
            } while (true);
        }


    }
}
