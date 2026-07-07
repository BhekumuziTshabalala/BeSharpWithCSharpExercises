using System;
using System.Collections.Generic;
using System.Text;
using Utility;




namespace Chapter1
{
    internal static class PrintShapes
    {
        public static void PrintShape(int shape)
        {
           int size = UserInput.GetIntegerMaxRange("Enter the size of the shape (1-20): ", 20);
            switch (shape)
            {
                case 1:
                    PrintSquare(size);
                    break;
                case 2:
                    PrintTriangle(size);
                    break;
                default:
                    Console.WriteLine("Invalid shape selection.");
                    break;
            }
        }

        private static void PrintTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for(int j = 1; j <= i ; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }




        private static void PrintSquare(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                
            }
        }

    }
}
