class Activity 
{
    private string _name;
    private string _description;
    private int _duration;

    //Constructors
    public Activity(){
        _name = "";
        _description = "";
    }

    public Activity(string name, string description){
        _name = name;
        _description = description;
    }

    //Methods
    public void DisplayStartingMessage(){
        Console.WriteLine($"\n{_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds,would you like for your session?");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        Console.WriteLine();
        Console.WriteLine("Get Ready...");
        ShowCountDown();
        Console.Clear();

    }
    public void DisplayEndingMessage(){
        Console.WriteLine($"Well done!\nYou have completed another {_duration} seconds of the {_name}");
    }

    public void ShowCountDown(){
        if (_duration >= 30){
            for (int i = 5; i > 0; i --)
            {
            Console.Write(i);
            Thread.Sleep(1500);
            Console.Write("\b \b");
            }
        }
        else{
            for (int i = 5; i > 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    public int SetDuration(int duration){
        return _duration = duration;
    }
    public int GetDuration(){
        return _duration;
    }

}