namespace Domain;

public class Product
{
    public string ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Product(string name, double price)
    {
        ProductId = Guid.NewGuid().ToString();
        this.Name = name;
        this.Price = price;
    }
}
