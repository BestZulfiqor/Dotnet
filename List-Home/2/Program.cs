using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>() { 7, 12, 3, 9, 5, 15, 8, 1, 6, 11 };
        System.Console.WriteLine("Четные числа: " + string.Join(", ", nums.FindAll(n => n % 2 == 0)));
        nums.RemoveAll(n => n < 5);
        nums.Add(20);
        Console.WriteLine($"Max: {nums.Max()}\nMin: {nums.Min()}");
        nums.Sort();
        nums.Reverse();
        Console.WriteLine($"Sum: {nums.Sum()}");
        Console.WriteLine($"All numbers: {string.Join(", ", nums)}");
    }
}