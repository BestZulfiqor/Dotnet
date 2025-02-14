using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = ["яблоко", "банан", "морковь", "апельсин", "картофель", "груша", "помидор", "огурец"];
        var fruits = new List<string>() { "яблоко", "банан", "апельсин", "груша", };
        var vegetables = new List<string>() { "морковь", "картофель", "помидор", "огурец" };
        fruits.Sort();
        vegetables.Sort();
        System.Console.WriteLine($"Fruits: {fruits.Count}");
        System.Console.WriteLine($"Vegetables: {vegetables.Count}");
        fruits.Add("виноград");
        vegetables.RemoveAll(n => n[0] == 'п');
        List<string> list2 = new List<string>();
        list2.AddRange(fruits.ConvertAll(n => n + " (фрукт)"));
        list2.AddRange(vegetables.ConvertAll(n => n + " (овощ)"));
        System.Console.WriteLine(string.Join("\n", list2));
    }
}