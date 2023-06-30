using System;

public abstract class Goal
{
    private string _type;
    private string _name;
    private string _desc;
    private int _points;

    public Goal (string type, string name, string desc, int points)
    {
        _type = type;
        _name = name;
        _desc = desc;
        _points = points;
    }

    public string Type 
    {
        get {return _type; }
        set { _type = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Desc
    {
        get { return _desc; }
        set { _desc = value; }
    }

    public int Points 
    {
        get { return _points; }
        set { _points = value; }
    }

    public abstract string GetGoalStatus();
    public abstract void RecordEvent();
    public abstract string DisplayFormat();
    public abstract string SaveFormat();
    public abstract int GetTotalPoints();
}