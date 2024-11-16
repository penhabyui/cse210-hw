class Entry
{
    public DateTime Date;
    public string Prompt;
    public string Response;

    public Entry()
    {
        Date = DateTime.Now; 
    }

    public void Write(string prompt)
    {
        Prompt = prompt;
        Console.WriteLine(prompt);
        Response = Console.ReadLine();
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date.ToString("dd/MM/yyyy HH:mm:ss")}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}\n");
    }
}