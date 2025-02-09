namespace infrastructure;

public class Student : Person
{
    public Dictionary<string, int> Courses { get; set; } = new Dictionary<string, int>();
    private const int MaxCourses = 30;
    public Student(string name, string address) : base(name, address) { }
    public void ListOfCourses()
    {
        if (Courses == null || Courses.Count == 0)
        {
            System.Console.WriteLine("\nNo courses available.");
            return;
        }
        System.Console.WriteLine("\nList of courses");
        foreach (var item in Courses)
        {
            System.Console.WriteLine(item);
        }
    }
    public double Average()
    {
        double average = 0;
        foreach (var item in Courses)
        {
            average += item.Value;
        }
        average /= Courses.Count();
        return average;
    }
    public void AddCourse(string name, int grade)
    {
        if (Courses.Count <= MaxCourses)
        {
            Courses.Add(name, grade);
            System.Console.WriteLine($"Course ({name}, grade: {grade}) added!");
            return;
        }
        System.Console.WriteLine("Student can't study more 30 courses int one time!");
    }
}
