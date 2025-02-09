namespace infrastructure;

public class Teacher : Person
{
    public Teacher(string name, string address) : base(name, address){}
    public List<string> courses = new List<string>();
    public void AddCourse(string name)
    {
        if (courses.Count <= 5)
        {
            courses.Add(name);
            System.Console.WriteLine($"\nCourse added. Name: {name}");
            return;
        }
        System.Console.WriteLine("It's anough courses for teacher!");
    }
    public void RemoveCourse(string name)
    {
        foreach (var item in courses)
        {
            if (item == name)
            {
                courses.Remove(name);
                System.Console.WriteLine("Course deleted!");
                return;
            }
        }
        System.Console.WriteLine($"There is no course with name: {name}");
    }
    public void ListOfCourses()
    {
        if (courses == null || courses.Count == 0)
        {
            System.Console.WriteLine("\nNo courses available.");
            return;
        }
        System.Console.WriteLine("\nList of courses");
        foreach (var item in courses)
        {
            System.Console.WriteLine(item);
        }
    }
}
