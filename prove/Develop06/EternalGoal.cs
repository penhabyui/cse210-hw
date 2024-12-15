public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine("Event recorded!");
    }

    public override string GetDetailsString()
    {
        return $"[ ]{_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}
