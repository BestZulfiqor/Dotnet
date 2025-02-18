using System;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string s = "hi everyone!";
        Three(s);
        int count = CountVowels(s);
        System.Console.WriteLine(count + " гласных");

        RemoveSpaces(s);

        StringBuilder sb = new StringBuilder();
        sb.Append('a', 100);
        sb = sb.Replace("aaaaa", "aaaab");
        System.Console.WriteLine(sb);

        List<string> txt = new List<string>() { "Salom", "Aleyk", "Voaleykum", "Assalom" };
        string newString = Join(txt);
        System.Console.WriteLine(newString);

        string textWithNums = "У меня 2 яблока и 3 груши";
        int sum = FoundSum(textWithNums);
        System.Console.WriteLine("Text: " + textWithNums + "\nSum: " + sum);

        string polindrom = "sussw";
        System.Console.WriteLine($"Text: {polindrom} \nPolindrom: " + Polindrom(polindrom));
        Dates();

        string date1 = "15.01.2024";
        DateTime dateTime1 = DateTime.Parse(date1);
        string date2 = "01.01.2024";
        DateTime dateTime2 = DateTime.Parse(date2);
        System.Console.WriteLine(Substract(dateTime1, dateTime2) + " дней");
    }
    static string Password(string pass)
    {
        if (pass.Length < 8)
        {
            return "Change password, this is too small!";
        }
        else if (!pass.Any(x => x >= '0' && x <= '9')) // Если нет цифр
        {
            return "Change password, it must have one digit!";
        }
        else
        {
            return "Password is correct!";
        }
    }
    static int Substract(DateTime dateTime, DateTime dateTime1)
    {
        return Math.Abs((int)(dateTime - dateTime1).TotalDays);
    }
    static void Dates()
    {
        System.Console.WriteLine($"Текущая дата: {DateTime.Now:d}");
        System.Console.WriteLine($"День неденли: {DateTime.Today.ToString("dddd")}");
        System.Console.WriteLine($"Номер недели в году: {CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Today, CalendarWeekRule.FirstDay, DayOfWeek.Monday)}");
    }
    static bool Polindrom(string s)
    {
        return s.OrderBy(x => x) == s.OrderByDescending(x => x);
    }
    static int FoundSum(string s)
    {
        int sum = s.Where(x => x == '1' || x == '2' || x == '3' || x == 4 || x == 5 || x == 6 || x == 7 || x == 8 || x == 9).Sum(x => x - '0');
        return sum;
    }
    static string Join(List<string> s)
    {
        string sb = string.Join(" ", s);
        return sb + '.';
    }
    static void RemoveSpaces(string s)
    {
        System.Console.WriteLine(s.Replace(" ", ""));
    }
    static void Three(string s)
    {
        System.Console.WriteLine(s.ToUpper());
        System.Console.WriteLine(s.ToLower());
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string capitalizedText = textInfo.ToTitleCase(s);
        Console.WriteLine(capitalizedText);
    }
    static int CountVowels(string s)
    {
        return s.Where(x => x == 'a' || x == 'e' || x == 'y' || x == 'i' || x == 'o' || x == 'u').Count();
    }
}