using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        
        // Creating a Client
        Customer customer = new Customer("John Doe", "123 Main St", "Anytown", "NY", "USA");

        //Creating Products
        Product product1 = new Product("Laptop", "P001", 1000.00, 2);
        Product product2 = new Product("Mouse", "P002", 25.00, 1);
        
        //Creating Orders
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.CalculateTotalCost());
        Console.WriteLine();
        Console.WriteLine(order.GetShippingLabel());
    }
}