public class Running : Activity
{
    private int _laps; // number of laps on a theoretical 1/4 mile running track
    private double _speed;

    public Running(string date, int time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        double distance = _laps * .25;
        return distance;
    }

    public override double Speed()
    {
        _speed = ((_laps * .25) / _time) * 60;
        return _speed;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }

    public override string GetActivityType()
    {
        return "RUNNING";
    }
}