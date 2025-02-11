namespace Domain;

public class Order
{
    public string OrderId { get; set; }
    public Customer Customer { get; set; }
    public Dictionary<Product, int> OrderItems { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime OrderDate { get; set; }
    public void UpdateStatus(OrderStatus status){
        Status = status;
        System.Console.WriteLine("Статус изменён!");
    }
    public Order(Customer customer, Dictionary<Product, int> OrderItem, decimal TotalAmount)
    {
        this.Customer = customer;
        this.OrderItems = OrderItem;
        this.TotalAmount = TotalAmount;
        this.OrderId = Guid.NewGuid().ToString();
        this.Status = OrderStatus.Placed;
        OrderDate = DateTime.Now;
    }
}
