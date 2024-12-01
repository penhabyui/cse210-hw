using System.Diagnostics;
using System.Numerics;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();

    //Constructors
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>(); 
    }
    
    //Methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
    public string CalculateTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.CalculatePrice();
        }
        
        double shippingCost = (_customer.GetUsaStatus() == 1) ? 5 : 35;
        Console.WriteLine($"Total Shipping Cost: ${shippingCost}");

        total += shippingCost;
        return "Total Cost: " + total.ToString("C2");
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        label += "Customer: " + _customer.GetName() + "\n";
        label += "Products:\n";
        
        foreach (var product in _products)
        {
            label += $"{product.GetName()} - Quantity: {product.GetQuantity()}\n";
        }
        
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += "Customer: " + _customer.GetName() + "\n";
        label += "Address: " + _customer.GetAddress() + "\n"; 
        return label;
    }
}