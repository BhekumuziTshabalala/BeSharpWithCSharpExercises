using Utility;

namespace Chapter2;

public static class ExerciseOne
{
    public  static string ConvertSeconds()
    {
        int seconds = UserInput.GetIntegerInput("Seconds");
        
        int hours = seconds / 3600;
        seconds %= 3600;
        int minutes = seconds / 60;
        seconds %= 60;
        
        return hours + ":" + minutes + ":" + seconds;
    }
}