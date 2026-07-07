using Utility;

namespace Chapter1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number associated with the program : " +
                "\n 1. Squares." +
                "\n 2. Triangle");

            int programNumber = UserInput.GetIntegerMaxRange("Enter the number associated with the program : ", 2);
            PrintShapes.PrintShape(programNumber);
         
        }
    }
}
