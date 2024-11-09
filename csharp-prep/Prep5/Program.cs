using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();

        int fav = PromptUserNumber();
        string user = PromptUserName();

        int squared = SquareNumber(fav);
        DisplayResult(user, squared);

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName()
        {
            Console.WriteLine("What is the user name?");
            string userName = Console.ReadLine();
            return userName;
        }
    
    static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            string number = Console.ReadLine();
            int favNumber = int.Parse(number);
            return favNumber;
        }

    static int SquareNumber(int favNumber)
        {
            int square = favNumber * favNumber;
            return square;
        }
    static void DisplayResult(string user, int squared)
        {
            Console.WriteLine($"{user}, the square of your number is {squared}");
        }
    }
}