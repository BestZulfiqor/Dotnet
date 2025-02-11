using System;
using System.Security.Cryptography;
using Domain;

class Program
{
    static void Main(string[] args)
    {
        ECommerceSystem eCommerceSystem = new ECommerceSystem();
        Product product = new Product("Pizza", 20);
        Customer customer = new Customer();
        customer.Name = "Ahmad";
        Dictionary<Product, int> dict = new() { };
        dict.Add(product, 10);
        Order order = new Order(customer, dict, 10);
        order.UpdateStatus(OrderStatus.Shipped);
        Shoppingcart cart = new Shoppingcart();
        cart.AddToCart(product, 10);
        eCommerceSystem.AddCustomer(customer);
        eCommerceSystem.AddProduct(product);
        eCommerceSystem.DisplayAllOrders();
    }
}