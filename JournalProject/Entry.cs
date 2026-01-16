using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public Entry(string prompt, string text)
    {
        _date = DateTime.Now.ToShortDateString();
        _prompt = prompt;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine(_text);
        Console.WriteLine();
    }

    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_text}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("|");
        Entry entry = new Entry(parts[1], parts[2]);
        entry._date = parts[0];
        return entry;
    }
}
