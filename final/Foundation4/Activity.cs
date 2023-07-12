public abstract class Activity
{
    private string _date;
    protected int _time;
    List<Activity> _activities = new List<Activity>();

    public Activity(string date, int time)
    {
        _date = date;
        _time = time;
    }

    public void SetActivity(Activity activity)
    {
        _activities.Add(activity);
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public void GetSummary(double distance, double speed, double pace)
    {
        Console.WriteLine($"{_date} ({_time} min) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min/mile");

    }
}