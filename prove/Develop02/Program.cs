using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Entry> entries = new List<Entry>(); 
    static Prompt promptGenerator = new Prompt(); 

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program!");

        int choice = 0;

        while (choice != 5)
        {
            DisplayMenu();
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry newEntry = new Entry();
                newEntry.Write(promptGenerator.GetRandomPrompt()); 
                entries.Add(newEntry); 
            }
            else if (choice == 2)
            {
                DisplayEntries();
            }
            else if (choice == 3)
            {
                LoadJournalFromFile(); 
            }
            else if (choice == 4)
            {
                SaveJournalToFile();
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. New entry");
        Console.WriteLine("2. Display entries");
        Console.WriteLine("3. Load journal from file");
        Console.WriteLine("4. Save journal to file");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    static void DisplayEntries()
    {
        Console.WriteLine("\nEntries:");
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    static void LoadJournalFromFile()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            entries.Clear();
            foreach (var line in File.ReadLines(filename))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        Date = DateTime.Parse(parts[0]),
                        Prompt = parts[1],
                        Response = parts[2]
                    };
                    entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    static void SaveJournalToFile()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}\n");
    }
}

