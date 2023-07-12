using System;

class Program
{
    static void Main(string[] args)
    {
        double distance;
        double speed;
        double pace;

        List<Activity> _activities = new List<Activity>();

        Activity running = new Running("12 July 2023",45,24); // each lap is .25 mile
        _activities.Add(running);

        Activity cycling = new Cycling("14 July 2023",60,15); // speed is in MPH
        _activities.Add(cycling);

        Activity swimming = new Swimming("16 July 2023",90,34); // each lap is 50 yards
        _activities.Add(swimming);

        
        foreach (Activity a in _activities)
        {
            distance = a.Distance();
            speed = a.Speed();
            pace = a.Pace();
            Console.WriteLine($"\nRECENT {a.GetActivityType()} ACTIVIY");
            swimming.GetSummary(distance, speed, pace);
        }
        Console.WriteLine("");
    }
}