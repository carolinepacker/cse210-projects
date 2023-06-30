using System;

public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string type, string name, string desc, int points, bool completed) : base(type, name, desc, points) 
    {
        _completed = completed;
    }


    public bool Completed 
    {
        get { return _completed; }
    }

    public override void RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            Console.WriteLine($"Congratulations! You have earned {Points} points!");
        } else {
            Console.WriteLine("This goal has already been completed!");
        }
        
    }

    public override string GetGoalStatus()
    {
        return _completed ? "[X]" : "[ ]";
    }

    public override string DisplayFormat()
    {
        string checkbox = GetGoalStatus();
        return $"{checkbox} {Name} ({Desc})";
    }

    public override string SaveFormat()
    {
        // save like : "1~~name~~desc~~points~~completed"
        return $"{Type}~~{Name}~~{Desc}~~{Points}~~{Completed}";
    }

    public override int GetTotalPoints()
    {
        return Points;
    }
}