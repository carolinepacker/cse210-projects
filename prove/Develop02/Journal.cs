using System;
using System.IO;

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

    public void SaveFile(List<Entry> entries)
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile  = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._entry}");
            }
        }

        // Clear entries array (because it is saved to the file)
        _entries.Clear();
    }

    public void LoadFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            //Currently "02/04/2023~~Best part of your day?~~I went to the store."
            string[] parts = line.Split("~~");
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._entry = parts[2];

            _entries.Add(newEntry);
        }
        
    }


}