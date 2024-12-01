class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    //Constructors
    public Product(){
        _name = "";
        _id = "";
        _price = 0;
        _quantity = 0;
    }

    public Product(string name, string id, double price, int quantity){
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    //Methods
    public double CalculatePrice(){
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}