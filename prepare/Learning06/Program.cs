using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");

        Square square = new Square("black", 2);
        Console.WriteLine(square.GetArea());

        Circle circle = new Circle("Blue", 4);
        Console.WriteLine(circle.GetArea());

        Rectangle rectangle = new Rectangle("Yellow", 4, 8);
        Console.WriteLine(rectangle.GetArea());

    }
}