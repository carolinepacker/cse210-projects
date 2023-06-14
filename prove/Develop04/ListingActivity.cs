using System;

public class ListingActivity : Activity
{
    // Member variables unique to listing activity
    private List<string> _prompts = new List<string> {"Who are the people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?", "What are you grateful for?"};
    private int _responseCount;

    // Constructors
    public ListingActivity(string name, string desc) : base(name, desc)
    {
        _responseCount = 0;
    }

    // Class functions unique to listing activity
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

    public void ListingCycle()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        DisplayCountdown();
        Console.WriteLine();

        string activityDuration = GetActivityDuration();
        int durationInt = Convert.ToInt32(activityDuration);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationInt);

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _responseCount++;
        }

        Console.WriteLine();
        string countString = Convert.ToString(_responseCount);
        Console.WriteLine($"You listed {_responseCount} items!");
    }

}