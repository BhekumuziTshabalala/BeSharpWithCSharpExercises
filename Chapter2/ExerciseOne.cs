using Utility;

namespace Chapter2;

public static class ExerciseOne
{
    public  static void ConvertSeconds()
    {
        int seconds = UserInput.GetIntegerInput("Seconds ");
        
        int hours = seconds / 3600;
        seconds %= 3600;
        int minutes = seconds / 60;
        seconds %= 60;
        
        Console.WriteLine("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
    }

    public static void ConvertBytes()
    {
        double bytes = UserInput.GetDoubleInput("Bytes ");
        double gigabytes = bytes / (1024 * 1024 * 1024) ;
        bytes %= bytes / (1024 * 1024 * 1024) ;
        double kilobytes = bytes / (1024 * 1024);
        bytes %= (1024 * 1024);
        
        Console.WriteLine("{0:00}:{1:00}:{2:00}", gigabytes, kilobytes, bytes);
        
    }

    public static void ConvertCurrency()
    {
        decimal amount = UserInput.GetDecimalInput("Amount R");
        decimal conversionRate = UserInput.GetDecimalInput("Conversion Rate R");
        
        Console.WriteLine("{0}$ = {1:C}", amount, amount * conversionRate);
    }

    public static void GetAverageOfFive()
    {
        Console.WriteLine("======= Start get Average of Five =======");
        double sumOfNumbers = 0;
        for (int i = 1; i <= 5; i++)
        {
            sumOfNumbers += UserInput.GetDoubleInput($"Number : {i}");
        }
        Console.WriteLine("Average of Five = {0:F2}",sumOfNumbers/5);
    }

    public static void GetOuterSurfaceAreaOfPipe()
    {
        Console.WriteLine("======= Get Outer Surface Area Of Pipe =======");
        double radius = UserInput.GetDoubleInput("Radius ");
        double height = UserInput.GetDoubleInput("Height ");
        
        Console.WriteLine("Total Surface Area = {0:F2}",( 2*Math.PI*radius) * (radius + height));
        
    }

    public static void JohnnyCashShop()
    {
        Console.WriteLine("======= Johnny Cash Shop =======");
        decimal amount = 0;
        for (int i = 1; i <= 3; i++)
        {
            amount += UserInput.GetDecimalInput($"Enter amount of item {i} R");
        }
        decimal cashProvided =  UserInput.GetDecimalInput("Cash Provided by user R");
        Console.WriteLine("Change : {0:C}",cashProvided - amount);
    }

    public static void GrossPayCalculator()
    {
        Console.WriteLine("======= Gross Pay Calculator =======");
        decimal sales = UserInput.GetDecimalInput("Total sales : R");
        Console.WriteLine("Net Pay : {0:C}",((2000 + (sales * 0.15M))) - (500 + (sales * 0.02M)));
    }

    public static void NumberSquare()
    {
        Console.WriteLine("======= Number Square =======");
        
        int square = UserInput.GetIntegerInput("Enter a Number  ");
        
        Console.WriteLine("Square : {0}, Square Root : {1}", square*square, Math.Sqrt(square));
    }

    public static void Trigonometry()
    {
        Console.WriteLine("======= Trigonometry =======");
        double angle = UserInput.GetIntegerInput("Enter a Angle  ") * (Math.PI/180);
        
        Console.WriteLine("Sine : {0}, Cosine : {1}, Tangent : {2} ",Math.Sin( angle), Math.Cos(angle),Math.Tan(angle));
    }
}