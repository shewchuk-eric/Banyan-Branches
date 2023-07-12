public class Swimming : Activity
{
    private double _laps;
    private double _speed;
    private double _pace;
    private double _distance;

    public Swimming(string date, int time, double laps) : base(date, time)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        _distance = (_laps * 50 / 1000) * 0.62;
        return _distance;
    }

    public override double Speed()
    {
        _speed = (_distance / _time) * 60;
        return _speed;
    }

    public override double Pace()
    {
        _pace = 60 / _speed;
        return _pace;
    }
}