namespace Infrastructure;
using Damin;
public class Service
{
    public List<Employee> Employees { get; set; }
    public List<Depertament> Depertaments { get; set; }
    public Service()
    {
        Employees = new List<Employee>();
        Depertaments = new List<Depertament>();
    }
    public bool Register(Employee employee)
    {
        int maxId = Employees.Count();
        employee.Id = maxId++;

        if (employee.Password.Length < 6) return false;
        if (string.IsNullOrEmpty(employee.Name)) return false;

        Employees.Add(employee);
        return true;
    }
    public bool Login(string name, string password)
    {
        foreach (var emp in Employees)
        {
            if (emp.Name == name && emp.Password == password)
            {
                return true;
            }
        }
        return false;
    }
    public bool AddDepertament(Depertament depertament)
    {
        int maxId = Depertaments.Count();
        depertament.Id = maxId++;
        if(depertament.Name.Length < 3) return false;
        Depertaments.Add(depertament);
        return true;
    }
    public List<Employee> GetAllEmployees()
    {
        return Employees;
    }
    public List<Depertament> GetAllDepertaments()
    {
        return Depertaments;
    }
    public Employee FindEmployeeById(int id)
    {
        return Employees.FirstOrDefault(e => e.Id == id) ?? null;
    }
    public Depertament FindDepertamentById(int id)
    {
        return Depertaments.FirstOrDefault(d => d.Id == id) ?? null;
    }
    public bool UpdateEmployee(Employee employee)
    {
        foreach (var emp in Employees)
        {
            if (emp.Id == employee.Id)
            {
                emp.DeportamentID = employee.DeportamentID;
                emp.Name = employee.Name;
                emp.Post = employee.Post;
                emp.Salary = employee.Salary;
                return true;
            }
        }
        return false;
    }
    public bool UpdateDepartament(Depertament departament)
    {
        foreach (var dep in Depertaments)
        {
            if (dep.Id == departament.Id)
            {
                dep.Name = departament.Name;
                return true;
            }
        }
        return false;
    }
    public bool RemoveEmployee(int id)
    {
        Employee employee = FindEmployeeById(id);
        if (employee != null)
        {
            Employees.Remove(employee);
            return true;
        }
        return false;
    }
    public bool RemoveDepartament(int id)
    {
        Depertament depertament = FindDepertamentById(id);
        if (depertament != null)
        {
            Depertaments.Remove(depertament);
            return true;
        }
        return false;
    }
    public List<Employee> FiltrByDepartament(int departamentId)
    {
        List<Employee> employees = new List<Employee>();
        foreach (var emp in Employees)
        {
            if (emp.DeportamentID == departamentId)
            {
                employees.Add(emp);
            }
        }
        return employees;
    }
    public List<Employee> FiltrBySalary(decimal minSalary, decimal maxSalary)
    {
        List<Employee> employees = new List<Employee>();
        foreach (var emp in Employees)
        {
            if (emp.Salary >= minSalary && emp.Salary <= maxSalary)
            {
                employees.Add(emp);
            }
        }
        return employees;
    }
}
