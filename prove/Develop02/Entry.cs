using System;
using System.Collections.Generic;

public class Entry
{
    public string _date = DateTime.UtcNow.ToString("d");
    public string _entry;
    public string _prompt;
    public List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?", 
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "How can I make tomorrow better?",
            "What makes me unique?",
            "What is my favorite memory from this month?",
            "What does my dream life look like?",
            "What do I want to be remembered for?"
        };

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_entry}");
        Console.WriteLine();
    }

    public void GeneratePrompt ()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        _prompt = _prompts[index];
    }
}