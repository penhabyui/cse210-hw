using System;

class Program
{
    static void Main(string[] args)
    {
        while(true){
        Console.Clear();
        Console.WriteLine("Hello Develop05 World!"); 
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Select a choice from Menu:"); 

        int choice = int.Parse(Console.ReadLine());
        
        if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                Console.Clear();
                breathingActivity.Run();
            }
            else if (choice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                Console.Clear();
                reflectingActivity.Run();
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                Console.Clear();
                listingActivity.Run();
            }
            else if (choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}