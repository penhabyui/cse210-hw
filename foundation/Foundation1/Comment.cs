class Comment
{
    private string _name;
    private string _comment;

    public Comment(){
        _name = "";
        _comment = "";
    }

    public Comment(string Name, string Comment){
        _name = Name;
        _comment = Comment;
    }

    public void DisplayComments(){
        Console.WriteLine($"{_name} - {_comment}");
    }

}