class Assignment
{
    private string _studentName;
    private string _topic;

    //Constructor
    public Assignment(){
        _studentName = "";
        _topic = "";
    }

    public Assignment(string Name){
        _studentName = Name;
        _topic = "";
    }

    public Assignment(string Name, string Topic){
        _studentName = Name;
        _topic = Topic;
    }

    //Methods
    public string GetSummary(){
        return _studentName + "-" + _topic;

    }

    public string GetStudentName(){
        return _studentName;
    }
}
