public abstract class Activity
{
    private string _date;
    private int _duration; 

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance(); 
    public abstract double GetSpeed();   
    public abstract double GetPace();     

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_duration} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
