using System;
using infrastructure;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Zulfiqor", "Assadullo G.");
        student.Courses.Add("Beckend", 8);
        student.Courses.Add("Frontend", 7);
        student.Courses.Add("Full Stack", 6);
        System.Console.WriteLine($"\nAverage grade: {student.Average()}");
        student.ListOfCourses();
        student.AddCourse("SQL", 5);
        student.ListOfCourses();


        Student student1 = new Student("Ahmad", "Qarabolo");
        student1.ListOfCourses();

        Teacher teacher = new Teacher("Bobojon", "Osimi")
        {
            courses = new List<string> { "Algebra", "Geometry", "Math", "Literature" }
        };
        teacher.ListOfCourses();
        teacher.RemoveCourse("Literature");
        teacher.ListOfCourses();
    }
}