using System;

class Program
{
    static int CountDigits(int n, int count = 0)
    {
        if (n <= 0)
        {
            return count;
        }
        count++;
        n /= 10;
        return CountDigits(n, count);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine(CountDigits(n));
    }

}