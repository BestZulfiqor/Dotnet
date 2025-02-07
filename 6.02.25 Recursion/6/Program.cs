using System;

class Program
{
    static int CountDigits(int[] n, int i = 0, int max = 0)
    {
        if (n.Length == i)
        {
            return max;
        }
        if (max < n[i])
        {
            max = n[i];
        }
        i++;
        return CountDigits(n, i, max);
    }
    static void Main()
    {
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        System.Console.WriteLine(CountDigits(n));
    }
}