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
                                  "\n 2. Bytes Converter", 2);

        switch (programNumber)
        {
            case 1:
                ExerciseOne.ConvertSeconds();
                break;
            default:
                break;
        }
    }
}