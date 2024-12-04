using System.Reflection.Metadata.Ecma335;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    //Constructors
    public MathAssignment(){

    }

    public MathAssignment(string Name, string Topic, string Textbook, string Problem) : base (Name, Topic){
        _textbookSection = Textbook;
        _problems = Problem;
    }

    //Methods
    public string GetHomeworkList(){
        return _textbookSection + " " + _problems;
    }
}