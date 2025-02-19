using System;
using System.Runtime.ConstrainedExecution;
using Damin;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        Service service = new Service();
        bool isVerified = false;
        while (true)
        {
            try
            {
                if (isVerified)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Показать всех сотрудников");
                    Console.WriteLine("2. Найти сотрудника");
                    Console.WriteLine("3. Изменить данные сотрудника");
                    Console.WriteLine("4. Удалить сотрудника");
                    Console.WriteLine("5. Фильтр по отделу");
                    Console.WriteLine("6. Фильтр по зарплате");
                    Console.WriteLine("7. Управление отделами");
                    Console.WriteLine("8. Выход");
                }
                else
                {
                    Console.WriteLine("10. Register");
                    Console.WriteLine("20. Login");
                }
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        var Employees = service.GetAllEmployees();
                        foreach (var emp in Employees)
                        {
                            System.Console.WriteLine($"Id: {emp.Id}. Name: {emp.Name}, post: {emp.Post}, salary: {emp.Salary}, deportament id: {emp.DeportamentID}");
                        }
                        break;
                    case 2:
                        System.Console.Write("Enter id: ");
                        int id = int.Parse(Console.ReadLine());

                        Employee employee1 = service.FindEmployeeById(id);
                        System.Console.WriteLine($"Name: {employee1.Name}, post: {employee1.Post}, salary: {employee1.Salary}, departament Id; {employee1.DeportamentID}");
                        break;
                    case 3:
                        Employee employee = new Employee();
                        System.Console.WriteLine("Enter name, password, post, salary and deportamentID");

                        System.Console.Write("Name: ");
                        employee.Name = Console.ReadLine();

                        System.Console.Write("Password: ");
                        employee.Password = Console.ReadLine();

                        System.Console.Write("Post: ");
                        employee.Post = Console.ReadLine();

                        System.Console.Write("Salary: ");
                        employee.Salary = decimal.Parse(Console.ReadLine());

                        System.Console.Write("Departament id (only 1, 2, 3): ");
                        employee.DeportamentID = int.Parse(Console.ReadLine());

                        bool result = service.UpdateEmployee(employee);
                        if (result) System.Console.WriteLine("Employee is updated!");
                        else System.Console.WriteLine("Employee is not updated!");
                        break;
                    case 4:
                        System.Console.Write("Enter id: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        if (service.RemoveEmployee(deleteId)) System.Console.WriteLine("Deleted employee!");
                        else System.Console.WriteLine("Employee is not deleted!");
                        break;
                    case 5:
                        System.Console.WriteLine("Enter departament id : ");
                        int departamentId = int.Parse(Console.ReadLine());
                        foreach (var emp in service.FiltrByDepartament(departamentId))
                        {
                            System.Console.WriteLine($"Id: {emp.Id}. Name: {emp.Name}, post: {emp.Post}, salary: {emp.Salary}, deportament id: {emp.DeportamentID}");
                        }
                        break;
                    case 6:
                        System.Console.WriteLine("Enter max salary and min salary: ");
                        System.Console.Write("Max salary: ");
                        int max = int.Parse(Console.ReadLine());
                        System.Console.Write("Min salary: ");
                        int min = int.Parse(Console.ReadLine());
                        foreach (var emp in service.FiltrBySalary(min, max))
                        {
                            System.Console.WriteLine($"Id: {emp.Id}. Name: {emp.Name}, post: {emp.Post}, salary: {emp.Salary}, deportament id: {emp.DeportamentID}");
                        }
                        break;
                    case 7:
                        System.Console.WriteLine("Управление отделами \n1. Добавление отдела \n2. Удаление отдела \n3. Обновление отдела \n4. Показать всех отделов");
                        int m = int.Parse(Console.ReadLine());
                        switch (m)
                        {
                            case 1:
                                Depertament depertament = new Depertament();
                                System.Console.Write("Departament name: ");
                                depertament.Name = Console.ReadLine();
                                if (service.AddDepertament(depertament)) System.Console.WriteLine("Departament is add!");
                                else System.Console.WriteLine("Departament is not add!");
                                break;
                            case 2:
                                System.Console.Write("Enter departament id: ");
                                int deportamentID2 = int.Parse(Console.ReadLine());
                                if (service.RemoveDepartament(deportamentID2)) System.Console.WriteLine("Departament is removed!");
                                else System.Console.WriteLine("Deportament is not removed!");
                                break;
                            case 3:
                                Depertament depertament2 = new Depertament();
                                System.Console.WriteLine("Enter id, name");
                                System.Console.Write("Id: ");
                                depertament2.Id = int.Parse(Console.ReadLine());
                                System.Console.WriteLine("Name: ");
                                depertament2.Name = Console.ReadLine();
                                if (service.UpdateDepartament(depertament2)) System.Console.WriteLine("Departament is updated!");
                                else System.Console.WriteLine("Departament is not Updated!");
                                break;
                            case 4:
                                foreach (var dep in service.GetAllDepertaments())
                                {
                                    System.Console.WriteLine($"id: {dep.Id}. Name: {dep.Name}");
                                }
                                break;
                            default:
                                break;
                        }

                        break;
                    case 8:
                        return;
                    case 10:
                        Employee employee2 = new Employee();
                        System.Console.WriteLine("Enter name, password, post, salary and deportamentID");

                        System.Console.Write("Name: ");
                        employee2.Name = Console.ReadLine();

                        System.Console.Write("Password: ");
                        employee2.Password = Console.ReadLine();

                        System.Console.Write("Post: ");
                        employee2.Post = Console.ReadLine();

                        System.Console.Write("Salary: ");
                        employee2.Salary = decimal.Parse(Console.ReadLine());

                        System.Console.Write("Departament id (only 1, 2, 3): ");
                        employee2.DeportamentID = int.Parse(Console.ReadLine());
                        break;
                    case 20:
                        System.Console.WriteLine("Enter email and password for login");
                        System.Console.Write("Name: ");
                        string name = System.Console.ReadLine();
                        System.Console.Write("Password: ");
                        string password = System.Console.ReadLine();
                        bool loginResult = service.Login(name, password);
                        if (loginResult)
                            isVerified = true;
                        else System.Console.WriteLine("Name or password are false!");
                        break;
                    default:
                        System.Console.WriteLine("I don`t know this command");
                        break;
                }
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}