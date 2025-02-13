namespace Domain;

public abstract class Person
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract string GetInfo();
}
