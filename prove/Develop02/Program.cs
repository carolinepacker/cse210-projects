using System;

class Program
{
    static Journal journal = new Journal();
    static void Main(string[] args)
    {
        string choice = "0";
        while (choice != "5")
        {
            DisplayMenu();
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveFile(journal._entries);
                    break;
                case "4":
                    journal.LoadFile();
                    break;
                case "5":
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Add Entry");
        Console.WriteLine("2. Display Entries");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Exit");
    }

    
}