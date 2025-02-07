using System;
class Program
{

    static bool Prime(int num, int i = 2)
    {
        if (num < 2)
        {
            return false;
        }
        if (i * i > num)
        {
            return true;
        }
        if (num % i == 0)
        {
            return false;
        }
        return Prime(num, i + 1);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine(Prime(n));
    }
}
