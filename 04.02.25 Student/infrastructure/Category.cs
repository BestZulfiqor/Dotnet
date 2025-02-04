namespace infrastructure;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatAt { get; set; }
    public Category(string name, DateTime creatAt, int id)
    {
        this.Name = name;
        this.CreatAt = creatAt;
        this.Id = id;
    }
}
