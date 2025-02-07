using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }
    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine(Factorial(n));
    }

}