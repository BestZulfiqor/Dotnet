namespace Domain;

public class Shoppingcart
{
    public Dictionary<Product, int> cartItems { get; set; }
    public void AddToCart(Product product, int quantity)
    {
        cartItems.Add(product, quantity);
        System.Console.WriteLine("Продукт добавлен!");
    }
    public Shoppingcart()
    {
        cartItems = new Dictionary<Product, int>();
    }
}
