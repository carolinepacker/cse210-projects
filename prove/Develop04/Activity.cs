using System;

public class Activity 
{
    // member variables
    private string _name;
    private string _description;
    protected string _activityDuration;
    protected int _spinnerDuration;

    // Constructors
    public Activity () 
    {

    }
    public Activity (string name, string desc)
    {
        _name = name;
        _description = desc;
        _activityDuration = "0";
        _spinnerDuration = 5;
    }


    // Class Functions
    public void WelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _activityDuration = Console.ReadLine();
        Console.WriteLine("");
    }

    public void DisplaySpinner()
    {
        List<string> animationStrings = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};
        DateTime startTime = DateTime.Now;
        int durationInt = Convert.ToInt32(_spinnerDuration);
        DateTime endTime = startTime.AddSeconds(durationInt);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void DisplayCountdown()
    {

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        DisplaySpinner();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_name}.");
    }


    public void GetReadyMessage()
    {
        Console.WriteLine("Get ready...");
        DisplaySpinner();
        Console.WriteLine("");
    }

    public string GetActivityDuration()
    {
        return _activityDuration;
    }
}