using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorize!");

        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, " +
                      "that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(text);

        string userInput;

        do
        {
            Console.Clear();
            Console.WriteLine(reference.DisplayText());
            Console.WriteLine(scripture.GetText());

            if (scripture. IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPlease press Enter to hide words or type 'quit' to exit:");
            userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                scripture.HideRandomWords();
            }
            else if (!userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Please enter a valid key!");
            }
        } while (!userInput.Equals("quit", StringComparison.OrdinalIgnoreCase));
    }
}





