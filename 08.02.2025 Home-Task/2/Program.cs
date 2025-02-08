using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        string s = Console.ReadLine();
        while (s.ToLower() != "end")
        {
            s = Console.ReadLine();
            count++;
        }
        System.Console.WriteLine(count);
    }
}