public abstract class Activity
{
    private string _type;
    private string _date;
    private int _duration;

    public Activity (string type, string date, int duration)
    {
        _type = type;
        _date = date;
        _duration = duration;
    }

    public string Type 
    {
        get { return _type; }
        set { _type = value; }
    }

    public string Date 
    {
        get { return _date; }
        set { _date = value; }
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public abstract string GetDistance();
    public abstract string GetSpeed();
    public abstract string GetPace();
    public void GetSummary()
    {
        Console.WriteLine($"{Date} {Type} ({Duration.ToString()} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile");
    }
}