using Utility;

namespace Chapter2;
class Program
{
    static void Main(string[] args)
    {
       StartProgram();
    }
    
    private static void StartProgram()
    {
        int programNumber = UserInput.GetIntegerMaxRange("Enter the number associated with the program : " +
                                  "\n 1. Seconds Converter." +
                                  "\n 2. Bytes Converter" +
                                  "\n 3. Currency Convert" +
                                  "\n 4. Get Average of 5" +
                                  "\n 5. TSA of Pipe" +
                                  "\n 6. JohnnyCashShop" +
                                  "\n 7. GrossPayCalculator" +
                                  "\n 8. NumberSquare" +
                                  "\n 9.  Trigonometry" +
                                  "\n Select Program: ", 7
            );

        switch (programNumber)
        {
            case 1:
                Exercises.ConvertSeconds();
                break;
            case 2:
                Exercises.ConvertBytes();
                break;
            case 3:
                Exercises.ConvertCurrency();
                break;
            case 4:
                Exercises.GetAverageOfFive();
                break;
            case 5:
                Exercises.GetOuterSurfaceAreaOfPipe();
                break;
            case 6:
                Exercises.JohnnyCashShop();
                break;
            case 7:
                Exercises.GrossPayCalculator();
                break;
            case 8:
                Exercises.NumberSquare();
                break;
            case 9:
                Exercises.Trigonometry();
                break;
        }
    }
}