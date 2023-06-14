using System;

public class BreathingActivity : Activity
{
    // Member variables unique to breathing
    // NONE
    
    //  Constructors (base included)
    public BreathingActivity (string name, string desc) : base(name, desc)
    {

    }

    // Class functions unique to breathing
    public void BreathingCycle()
    {
        string activityDuration = GetActivityDuration();
        int durationInt = Convert.ToInt32(activityDuration);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationInt);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            DisplayCountdown();
            Console.WriteLine();
            Console.Write("Breathe out..");
            DisplayCountdown();
            Console.WriteLine();

        }

    }
}