public class Goal 
{
    public string _shortName;
    public string _description;
    public int _points;

    // Constructors
    public Goal(string name, string description, int points){
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Methods
    public virtual void RecordEvent(){

    }
    
    public virtual bool IsComplete(){
        return false; 
    }

    public virtual string GetDetailsString(){
        return $"{_shortName}: {_description}";
    }

    public virtual string GetStringRepresentation(){
        return $"{_shortName}|{_description}|{_points}";
    }
}
