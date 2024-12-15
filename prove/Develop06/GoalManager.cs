  public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    // Constructors
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Methods
    public void Start()
    {
        CreateGoal();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalName()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._shortName}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        Console.WriteLine();
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: \n1. Simple \n2. Eternal \n3. Checklist");
        string type = Console.ReadLine();
        Console.WriteLine("Which type of goal would you like to create?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());
        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine("How many times does this goals need to be completed for a bonus?");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus from completing this many times?");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid type. Goal not created.");
                break;
        }
    }
    public void RecordEvent()
    {
        ListGoalDetails();
        Console.WriteLine("Enter the number of the goal to record:");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index]._points;
            Console.WriteLine("Event recorded!");
            
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt")){
        
        writer.WriteLine(_score);  
        foreach (var goal in _goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());  
        }
        Console.WriteLine();
        Console.WriteLine("Goals saved successfully.");
        Console.WriteLine();

        }
    }
    
    public void LoadGoals(){
       //I dont know how to do this part of the activity :() 
    }
}
