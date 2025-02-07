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
    static void Main()
    {
        string s = Console.ReadLine();
        System.Console.WriteLine(Reverse(s));
    }

}