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
                                  "\n Select Program: ", 4
            );

        switch (programNumber)
        {
            case 1:
                ExerciseOne.ConvertSeconds();
                break;
            case 2:
                ExerciseOne.ConvertBytes();
                break;
            case 3:
                ExerciseOne.ConvertCurrency();
                break;
            case 4:
                ExerciseOne.GetAverageOfFive();
                break;
            default:
                break;
        }
    }
}