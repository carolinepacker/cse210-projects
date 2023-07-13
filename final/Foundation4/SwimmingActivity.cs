public class SwimmingActivity : Activity 
{
    private double _laps;

    public SwimmingActivity(string type, string date, int duration, double laps) :  base(type, date, duration)
    {
        _laps = laps;
    }

    public override string GetDistance()
    {
        double floatDist = _laps * 50 / 1000 * 0.62;
        return floatDist.ToString();
    }

    public override string GetPace()
    {
        double distance = double.Parse(GetDistance());
        double pace = Duration / distance;
        return pace.ToString();
    }

    public override string GetSpeed()
    {
        double pace = double.Parse(GetPace());
        double speed = 60 / pace;
        return speed.ToString();
    }
}