using System;

class Program
{
    static string Reverse(string s, int i = 0, string rev = "")
    {
        if (s.Length == i)
        {
            return rev;
        }
        i++;
        char ch = s[s.Length - i];
        rev += ch;
        return Reverse(s, i, rev);
    }
    static string Binary(int n, string i = "")
    {
        if (n <= 0)
        {
            return Reverse(i);
        }
        i += (n % 2).ToString();
        n /= 2;
        return Binary(n, i);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine(Binary(n));
    }

}