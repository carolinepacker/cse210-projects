using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        RunningActivity running1 = new RunningActivity("Running", "July 4, 2023", 30, 3);
        CyclingActivity cycling1 = new CyclingActivity("Cycling", "August 28, 2020", 20, 2);
        SwimmingActivity swim1 = new SwimmingActivity("Swimming", "April 2, 2022", 20, 40);

        activities.Add(running1);
        activities.Add(cycling1);
        activities.Add(swim1);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}