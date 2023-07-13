public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string type, string date, int duration, double speed) :  base(type, date, duration)
    {
        _speed = speed;
    }

    public override string GetDistance()
    {
        double speedPerMinute = _speed / 60;
        double floatDist = speedPerMinute * Duration;
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
