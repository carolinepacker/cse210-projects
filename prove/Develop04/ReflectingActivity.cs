using System;

public class ReflectingActivity : Activity
{
    // Member variables unique to reflecting activities
    private List<string> _prompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time whne you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different from other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    // Constructors
    public ReflectingActivity(string name, string desc) : base(name, desc)
    {

    }

    // Class Functions unique to reflecting activities
    public string GetRandomPrompt()
    {
        Random random1 = new Random();
        int randomIndex = random1.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

    public string GetRandomQuestion()
    {
        Random random1 = new Random();
        int randomIndex = random1.Next(_questions.Count);
        return _questions[randomIndex];
    }

    public void ReflectingMenu()
    {   
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountdown();
        Console.Clear();

    }

    public void ReflectingCycle()
    {
        string activityDuration = GetActivityDuration();
        int durationInt = Convert.ToInt32(activityDuration);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationInt);
        Random random1 = new Random();

        while (DateTime.Now < endTime)
        {
            int randomIndex = random1.Next(_questions.Count);
            Console.Write(_questions[randomIndex]);
            DisplaySpinner();
            Console.WriteLine();
        }
    }

}