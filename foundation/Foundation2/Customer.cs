class Customer
{
    private string _name;
    Address _address = new Address();

    //Constructor
    public Customer(){
        _name = "";
        _address = new Address();
    }

    public Customer(string name, string street, string city, string state, string country){
        _name = name;
         _address = new Address(street, city, state, country);
    }

    //Methods
    public int GetUsaStatus(){
        return _address.GetCountry() == "USA" ? 1 : 0;
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _address = new Address(street, city, state, country);
    }

    public string GetAddress()
    {
        return _address.DisplayAddress();
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }
}
