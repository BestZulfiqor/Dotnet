using System;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student() { Name = "Zulfqior", Age = 20, Course = 3 };
        Student student2 = new Student() { Name = "Ahmad", Age = 27, Course = 6 };
        Student student3 = new Student() { Name = "Odina", Age = 21, Course = 3 };
        List<Student> students = new List<Student>() { student1, student2, student3 };
        System.Console.WriteLine($"Все студенты 3-го курса: {string.Join(", ", students.FindAll(n => n.Course == 3))}");
        System.Console.WriteLine($"Имена студентов которые больше 20 лет: {string.Join(", ", students.FindAll(n => n.Age > 20))}");
        foreach (var item in students.OrderBy(n => n.Age))
        {
            System.Console.WriteLine(item.Age);
        }
        System.Console.WriteLine($"Самый молодой студент: " + students.Min(n => n.Age));
        System.Console.WriteLine($"Средный возрасть студентов: {students.Average(n => n.Age)}");
        System.Console.WriteLine("\nПолная информация о студентах: ");
        System.Console.WriteLine(string.Join("\n", students.Select(n => $"Имя: {n.Name}, Возрасть: {n.Age}, Курс: {n.Course}")));
    }
}
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Course { get; set; }

}