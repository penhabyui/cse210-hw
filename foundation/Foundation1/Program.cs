using System;
using System.Reflection.Metadata;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video("C# Basics", "John Doe", 300);
        Video video2 = new Video("Understanding OOP", "Jane Smith", 420);
        Video video3 = new Video("Advanced C#", "Mark Brown", 600);

        video1.AddNewComment("Alice", "Great explanation!");
        video1.AddNewComment("Bob", "Loved the examples.");
        video1.AddNewComment("Charlie", "Clear and concise.");

        video2.AddNewComment("Emily", "OOP concepts are so much clearer now.");
        video2.AddNewComment("Frank", "Could you explain polymorphism in more detail?");
        video2.AddNewComment("Grace", "I finally understand inheritance!");

        video3.AddNewComment("Jack", "Amazing!");
        video3.AddNewComment("Isabel", "Advanced concepts, but explained well.");
        video3.AddNewComment("Liam", "This video is a lifesaver!");

        video1.Display();
        Console.WriteLine();
        video2.Display();
        Console.WriteLine();
        video3.Display();
    }
}


    