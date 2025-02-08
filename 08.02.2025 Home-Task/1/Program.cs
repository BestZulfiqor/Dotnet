using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now;
        System.Console.WriteLine($"Year: {dateTime.Year}");
        System.Console.WriteLine($"Month: {dateTime.Month}");
        System.Console.WriteLine($"Day: {dateTime.Day}");
        System.Console.WriteLine($"Hour: {dateTime.Hour}");
        System.Console.WriteLine($"Minute: {dateTime.Minute}");
        System.Console.WriteLine($"Second: {dateTime.Second}");
        System.Console.WriteLine($"Millisecond: {dateTime.Millisecond}");
    }
}