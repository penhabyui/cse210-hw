class Scripture
{
    private List<Word> Words { get; }

    public Scripture(string text)
    {
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetText()
    {
        return string.Join(' ', Words.Select(word => word.GetDisplayText()));
    }

    public void HideRandomWords()
    {
        var visibleWords = Words.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Any())
        {
            var random = new Random();
            int wordsToHide = Math.Min(3, visibleWords.Count); // Esconde até 3 palavras por vez
            for (int i = 0; i < wordsToHide; i++)
            {
                var word = visibleWords[random.Next(visibleWords.Count)];
                word.Hide();
                visibleWords.Remove(word);
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        return Words.All(word => word.IsHidden());
    }
}
