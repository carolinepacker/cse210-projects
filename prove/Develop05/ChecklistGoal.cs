using System;

public class ChecklistGoal : Goal
{
    private int _completedCount;
    private int _bonusCount;
    private int _repeatCount;
    private int _bonusPoints;

    public ChecklistGoal(string type, string name, string desc, int points, int repeatCount, int bonusPoints) : base(type, name, desc, points)
    {   
        _completedCount = 0;
        _bonusCount = 0;
        _repeatCount = repeatCount;
        _bonusPoints = bonusPoints;
    }

    public ChecklistGoal(string type, string name, string desc, int points, int completedCount, int bonusCount, int repeatCount, int bonusPoints) : base(type, name, desc, points)
    {
        _completedCount = completedCount;
        _bonusCount = bonusCount;
        _repeatCount = repeatCount;
        _bonusPoints = bonusPoints;
    }

    public int RepeatCount 
    {
        get { return _repeatCount; }
        set { _repeatCount = value; }
    }

    public int BonusCount 
    {
        get { return _bonusCount; }
    }

    public int BonusPoints 
    {
        get { return _bonusPoints; }
        set { _bonusPoints = value; }
    }

    public int CompletedCount
    {
        get { return _completedCount; }
    }

    public override void RecordEvent()
    {
        _completedCount++;
        if (_completedCount % _repeatCount == 0) 
        {
            _bonusCount++;
        }
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
    }

    public override string GetGoalStatus()
    {
        return $"{_completedCount}/{_repeatCount}";
    }

    public override string DisplayFormat()
    {
        string goalStatus = GetGoalStatus();
        return $"[ ] {Name} ({Desc}) -- Currently Completed: {goalStatus}";
    }

    public override string SaveFormat()
    {
        return $"{Type}~~{Name}~~{Desc}~~{Points}~~{CompletedCount}~~{BonusCount}~~{RepeatCount}~~{BonusPoints}";
    }

    public override int GetTotalPoints()
    {
        int bonusTotal = _bonusCount * _bonusPoints;
        int regTotal = _completedCount * Points;
        return bonusTotal + regTotal;
    }

}