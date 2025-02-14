using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> cities = new List<string>(){"Moscov", "Sanckt-Peterburg", "Novosibirsk", "Ekaterinburg", "Kazan"};
        System.Console.WriteLine($"Количества городов: {cities.Count}");
        cities.Add("Sochi");
        cities.Remove("Ekaterinburg");
        System.Console.WriteLine(cities.Contains("Moskov"));
        System.Console.WriteLine(string.Join(", ", cities.FindAll(n => n.Count() > 6)));
        cities.Sort();
        System.Console.WriteLine("Сортировака по алфавиту: " + string.Join(", ", cities));
    }
}