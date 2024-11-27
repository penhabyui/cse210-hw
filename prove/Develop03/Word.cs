class Word
{
    private string _original { get; set; }
    private bool _isHidden { get; set; }

    public Word(string original)
    {
        _original = original;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _original.Length) : _original;
    }
}
