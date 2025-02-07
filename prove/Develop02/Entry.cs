using System;

public class Entry
{
    List<string> entry = new List<string>();

   
    
    public string _date;
    public string _writingPrompt;
    public string _entry;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_writingPrompt}");
        Console.WriteLine($"{_entry}");
    }
}