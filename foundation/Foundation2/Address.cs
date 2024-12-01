using System.ComponentModel.DataAnnotations;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //Constructor
    public Address(){

    }
    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //Methods
    public int InUSA(){
        if (_country == "USA"){return 1;}
        else{return 0;}
    }
    public string GetCountry()
    {
        return _country;
    }

    public string DisplayAddress(){
        return $"{_street}, {_city}\n{_state}, {_country}";
    }
}