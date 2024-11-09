using System;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int numbersOnList = 0;
        int sum = 0;
        int average = 0;
        int largest = 0;

        do
        {
        Console.WriteLine("Enter number:");
        string number = Console.ReadLine();
        int listNumbers = int.Parse(number);
        numbers.Add(listNumbers);

        numbersOnList+=1;
        sum+=listNumbers;
        average = sum / 10;
        largest = numbers.Max();
        }
        while(numbersOnList < 10);
        {
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
        }
    }
}