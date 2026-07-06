using System;
using System.Collections.Generic;
using System.Text;


namespace Chapter1
{
    internal static class printShapes
    {
        public static void printShape(int shape)
        {
           int size = UserInput.GetIntegerInput("Enter the size of the shape (1-20): ", 20);
            switch (shape)
            {
                case 1:
                    printSquare(size);
                    break;
                case 2:
                    printTriangle(size);
                    break;
                default:
                    Console.WriteLine("Invalid shape selection.");
                    break;
            }
        }

        private static void printTriangle(int size)
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




        private static void printSquare(int size)
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
