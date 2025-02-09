namespace infrastructure;

public class Person
{
    public string Name  { get; set; }
    public string Adress { get; set; }
    public Person(string name, string address)
    {
        this.Name = name;
        this.Adress = address;
    }
}
