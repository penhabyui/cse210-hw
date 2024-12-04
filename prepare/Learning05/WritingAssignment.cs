class WritingAssignment : Assignment
{
    private string _title;
    private string _name;

    //Constructor
    public WritingAssignment(){
        _title = "";
    }

    public WritingAssignment(string Name, string Topic, string Title): base (Name, Topic){
        _title = Title;
    }

    //Methods
    public string GetWritingInformation(){
        return _title;
    }
}