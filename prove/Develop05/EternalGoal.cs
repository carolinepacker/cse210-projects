using System;

public class EternalGoal : Goal
{
    private int _totalRecordedCompletions;

    public EternalGoal (string type, string name, string desc, int points) : base(type, name, desc, points)
    {
        _totalRecordedCompletions = 0;
    }

    public int TotalRecordedCompletions 
    {
        get { return _totalRecordedCompletions; }
    }

    public override void RecordEvent()
    {
        _totalRecordedCompletions++;
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
    }

    public override string GetGoalStatus()
    {
        return "[ ]";
    }

    public override string DisplayFormat()
    {
        string checkbox = GetGoalStatus();
        return $"{checkbox} {Name} ({Desc}) -- Times Completed: {TotalRecordedCompletions}";
    }

    public override string SaveFormat()
    {
        return $"{Type}~~{Name}~~{Desc}~~{Points}~~{TotalRecordedCompletions}";
    }

    public override int GetTotalPoints()
    {
        return Points * TotalRecordedCompletions;
    }
}