using System;

class Program
{
    static int CalcSum(int n, int i = 0, int sum = 0)
    {
        if (n < i)
        {
            return sum;
        }
        sum+= i;
        i++;
        return CalcSum(n, i, sum);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine(CalcSum(n));
    }

}