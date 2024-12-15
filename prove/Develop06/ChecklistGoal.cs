public class ChecklistGoal : Goal
{
    public int _amountCompleted; 
    public int _target; 
    public int _bonusPoints; 

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points) 
    {
        _target = targetCount;
        _bonusPoints = bonusPoints;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++; 

            Console.WriteLine($"Goal progress: {_amountCompleted}/{_target} completed.");
            Console.WriteLine($"You've earned {_points} points!");


            if (_amountCompleted == _target)
            {
                _points += _bonusPoints;
            }
        }
        else
        {
            Console.WriteLine("Goal already completed.");
        }
    }

    public override string GetDetailsString()
    {
        if(_amountCompleted == _target){
            return $"[X] {_shortName} ({_description}) - Progress: {_amountCompleted}/{_target} completed.";
        }
        else{
            return $"[ ] {_shortName} ({_description}) - Progress: {_amountCompleted}/{_target} completed.";
        }
    }

    public override string GetStringRepresentation()
    {
         return $"{_shortName},({_description}),{_points},{_target},{_bonusPoints},{_amountCompleted}";
    }

}
