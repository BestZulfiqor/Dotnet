using System;

class Program
{
    static void NaturalNums(int a = 0)
    {
        if (a == 50)
        {я
            return;
        }
        else{
            a++;
            System.Console.WriteLine(a);
            NaturalNums(a);
        }
    }
    static void Main()
    {
        NaturalNums();
    }
}