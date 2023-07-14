public class Cycling : Activity
{
    private int _speed; // the average speed during the activity timeframe

    public Cycling(string date, int time, int speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return _speed * _time / 60; //distance;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }

    public override string GetActivityType()
    {
        return "CYCLING";
    }
}