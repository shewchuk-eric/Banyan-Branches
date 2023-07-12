using System;

class Program
{
    static void Main(string[] args)
    {
        double distance;
        double speed;
        double pace;


        Activity running = new Running("12 July 2023",45,24); // each lap is .25 mile
        running.SetActivity(running);
        distance = running.Distance();
        speed = running.Speed();
        pace = running.Pace();
        Console.WriteLine("\nRECENT RUNNING ACTIVIY");
        running.GetSummary(distance, speed, pace);

        Activity cycling = new Cycling("14 July 2023",60,15); // speed is in MPH
        cycling.SetActivity(cycling);
        distance = cycling.Distance();
        speed = cycling.Speed();
        pace = cycling.Pace();
        Console.WriteLine("\nRECENT CYCLING ACTIVIY");
        cycling.GetSummary(distance, speed, pace);

        Activity swimming = new Swimming("16 July 2023",90,34); // each lap is 50 yards
        swimming.SetActivity(swimming);
        distance = swimming.Distance();
        speed = swimming.Speed();
        pace = swimming.Pace();
        Console.WriteLine("\nRECENT SWIMMING ACTIVIY");
        swimming.GetSummary(distance, speed, pace);
        Console.WriteLine("");
    }
}