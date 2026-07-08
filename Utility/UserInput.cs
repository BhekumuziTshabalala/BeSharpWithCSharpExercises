using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    public static class UserInput
    {
        public static int GetIntegerMaxRange(string prompt, int maxRange)
        {
            do
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value) && value > 0 && value <= maxRange){
                    return value;
                }
                else
                {
                    Console.WriteLine($"\nInvalid input. Please enter a number between 1 and {maxRange}.");
                }
            } while (true);
        }
        
        public static int GetIntegerInput(string prompt)
        {
            do
            {
                Console.Write(prompt + ":");
                if (int.TryParse(Console.ReadLine(), out int value)){
                    return value;
                }
                Console.Write($"\nInvalid input. Please enter a number");
                
            } while (true);
        }
        
        public static double GetDoubleInput(string prompt)
        {
            do
            {
                Console.Write(prompt + ":");
                if (double.TryParse(Console.ReadLine(), out double value)){
                    return value;
                }
                Console.Write($"\nInvalid input. Please enter a number");
                
            } while (true);
        }
        
        public static decimal GetDecimalInput(string prompt)
        {
            do
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out decimal value)){
                    return value;
                }
                Console.Write($"\nInvalid input. Please enter a number");
                
            } while (true);
        }


    }
}
