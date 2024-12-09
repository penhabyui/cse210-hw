using System.Diagnostics;
class ListingActivity : Activity
{
    private int _count;
    
    List<string> _prompts;

    //Constructor
    public ListingActivity(): base ("Listing Activity", "This activity will help you reflect on the good things in your life\nby having you list as many things as you can in a certain area."){      
        _prompts = new List<string>(){
            "---Who are people that you appreciate?---",
            "---What are personal strengths of yours?---",
            "---Who are people that you have helped this week?---",
            "---When have you felt the Holy Ghost this month?---",
            "---Who are some of your personal heroes?---",
        };
    }
    
    //Methods 
    public void Run(){
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayPrompt();
        Console.WriteLine("You may begin in:");
        ShowCountDown();
        GetListFromUser();
        DisplayEndingMessage();
        ShowCountDown();
        Console.Clear();
    }

    public string GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void GetListFromUser()
    {
    List<string> listingItems = new List<string>();

    DateTime startTime = DateTime.Now;
    DateTime finalTime = startTime.AddSeconds(GetDuration());

    while (DateTime.Now < finalTime)
    {
        string word = Console.ReadLine();
        listingItems.Add(word);
    }
    Console.WriteLine($"You listed {listingItems.Count} items!");
    }
    public void DisplayPrompt(){
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

}
