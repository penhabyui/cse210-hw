using System.Diagnostics.Contracts;

public class SimpleGoal : Goal
{
    public bool _IsCompleted;

    //Constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { 
        _IsCompleted = false;
    }
    //Methods
    public override void RecordEvent()
        {
        if (!_IsCompleted)
        {
            _IsCompleted = true;
        }
    }

    public override string GetDetailsString()
    {
        if (_IsCompleted == true)
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }
}
