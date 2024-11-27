using System.Dynamic;

public class Reference
{
    private string _book { get; set; }
    private int _chapter { get; set; }
    private int _firstVersicle { get; set; }
    private int? _lastVersicle { get; set; }

    public Reference(string book, int chapter, int startVersicle)
    {
        _book = book;
        _chapter = chapter;
        _firstVersicle = startVersicle;
        _lastVersicle = null;
    }

    public Reference(string book, int chapter, int startVersicle, int endVersicle)
        : this(book, chapter, startVersicle)
    {
        _lastVersicle = endVersicle;
    }

    public string DisplayText()
    {
        if (_lastVersicle.HasValue)
        {
            return $"{_book} {_chapter}:{_firstVersicle}-{_lastVersicle.Value}";
        }
        return $"{_book} {_chapter}:{_firstVersicle}";
    }
}
