using System;

class Program
{
    static void Main(string[] args)
    {   
        string playAgain ="";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int guessNumber = 0;
            int guesses = 0;
            do
            {
                Console.WriteLine("What is your guess?");
                guessNumber = int.Parse(Console.ReadLine()); 
                guesses +=1;
            
                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guesses} guesses!");
                    Console.WriteLine("Do you wanna play again?");
                    playAgain = Console.ReadLine();
                }
            }   
            while (guessNumber != magicNumber);
        }
        while (playAgain == "yes");
    }
}

