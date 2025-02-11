namespace Domain;

public class ECommerceSystem
{
    public List<Product> Products { get; set; }
    public List<Customer> Customers { get; set; }
    public List<Order> Orders { get; set; }
    public ECommerceSystem()
    {
        Products = new List<Product>();
        Customers = new List<Customer>();
        Orders = new List<Order>();
    }
    public void AddProduct(Product product)
    {
        Products.Add(product);
        System.Console.WriteLine("Продукт добавлен!");
    }
    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
        System.Console.WriteLine("Доставшик добавлен!");
    }
    public void PlaceOrder(Customer customer, Shoppingcart cart)
    {
        decimal TotalAmount = 0;
        foreach (var item in cart.cartItems)
        {
            TotalAmount += (decimal)item.Key.Price * item.Value;
        }
        Order order = new Order(customer, cart.cartItems, TotalAmount);
        System.Console.WriteLine("Заказ принят!");
    }
    public void UpdateOrderStatus(string orderId, OrderStatus status)
    {
        foreach (var item in Orders)
        {
            if (item.OrderId == orderId)
            {
                item.Status = status;
            }
        }
        System.Console.WriteLine("Статус изменён");
    }
    public void DisplayAllOrders()
    {
        foreach (var item in Orders)
        {
            System.Console.WriteLine($"OrderID: {item.OrderId}. ");
        }
    }
}
