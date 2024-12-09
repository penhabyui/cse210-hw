using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class BreathingActivity : Activity
{
    Program program = new Program();
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
    DisplayStartingMessage();
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(GetDuration());

    while (DateTime.Now <= futureTime) 
    {
        Console.WriteLine("Breathe in...");
        ShowCountDown(); 
        if (DateTime.Now >= futureTime) break; 
        Console.WriteLine("Breathe out...");
        ShowCountDown();
    }
        DisplayEndingMessage();
        Thread.Sleep(2000);
        Console.Clear();
    }
}
