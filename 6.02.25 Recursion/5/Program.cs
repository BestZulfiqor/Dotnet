using System;

class Program
{
    static int CountDigits(int n, int count = 0, int sum = 0)
    {
        if (n <= 0)
        {
            return sum;
        }
        count++;
        sum += n % 10;
        n /= 10;
        return CountDigits(n, count, sum);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine(CountDigits(n));
    }

}