public class Cycling : Activity
{
    private int _speed; // the average speed during the activity timeframe
    private double _pace;

    public Cycling(string date, int time, int speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        double distance = _speed * _time / 60;
        return distance;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        _pace = 60 / _speed;
        return _pace;
    }
}