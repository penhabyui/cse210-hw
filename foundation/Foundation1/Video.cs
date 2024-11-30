using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments = new List<Comment>();

    public Video(string Title, string Author, int Length){
        _title = Title;
        _author = Author;
        _length = Length;
         _comments = new List<Comment>();
    }

    public void AddNewComment(string name, string text)
    {
        Comment comment = new Comment(name, text); 
        _comments.Add(comment);
    }

    public void Display(){
        Console.WriteLine($"Title: {_title}, Author: {_author},Length: {_length} seconds");;
        Console.Write(CommentNumber());
        foreach (Comment comment in _comments){
            comment.DisplayComments();
        }
        
    }

    private int CommentNumber(){
        int number = _comments.Count();
        return number;
    }

}