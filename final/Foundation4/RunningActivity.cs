public class RunningActivity : Activity
{

    private double _distance;

    public RunningActivity(string type, string date, int duration, double distance) :  base(type, date, duration)
    {
        _distance = distance;
    }

    public override string GetDistance()
    {
        return _distance.ToString();
    }

    public override string GetPace()
    {
        double dblPace = Duration / _distance;
        return dblPace.ToString();
    }

    public override string GetSpeed()
    {
        double speed = (_distance / Duration) * 60;
        return speed.ToString();
    }

}