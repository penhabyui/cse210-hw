using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        //Console.WriteLine("Enter the top number of a fraction:");
        //int numerator = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the bottom number of a fraction:");
        //int denominator = int.Parse(Console.ReadLine());

        Fraction f = new Fraction(1);
        Console.WriteLine(f.GetFractionString()); 
        Console.WriteLine(f.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString()); 
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString()); 
        Console.WriteLine(f4.GetDecimalValue());
        
    }
}