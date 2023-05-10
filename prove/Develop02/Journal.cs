using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry.GeneratePrompt();
        Console.WriteLine(newEntry._prompt);
        newEntry._entry = Console.ReadLine();
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveFile()
    {

    }

    public void LoadFile()
    {

    }


}