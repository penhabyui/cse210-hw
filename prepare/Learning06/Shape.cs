public abstract class Shape
{
    private string _color;

    //Constructor
    public Shape(string color){
        _color = color;
    }


    //Methods
    public string GetColor(){
        return _color;
    }

    public abstract double GetArea(); 
}