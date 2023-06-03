public class Activity
{
    private bool _timesUp = false; // tells cycle if it's time to end
    private int _howLong = 0; // user input for cycle run time
    private int _delay = 0;
    private string _activity;
    private string _mainMessage;

    
    public Activity()
    {

    }
    public Activity(string activity, string mainMessage)
    {
        _activity = activity;
        _mainMessage = mainMessage;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activity} Activity.\n");
        Console.WriteLine(_mainMessage + "\n");
    }

    public void EndMessage(string cycle)
    {
        Console.WriteLine($"You have completed another {_howLong - _delay} seconds of the {cycle} Activity.");
    }

    protected DateTime SetTimer(int delay)
    {
        _delay = delay;
        Console.WriteLine("How long, in seconds, would you like for your session?"); 
        _howLong = int.Parse(Console.ReadLine()); // get user input and convert to an integer
        _howLong += _delay; // add time for the delay at beginning of cycle
        DateTime startTime = DateTime.Now; // get current time
        return startTime;
    }

    protected bool TimeUp(DateTime start)
    {
        DateTime endTime = start.AddSeconds(_howLong);
        DateTime testTime = DateTime.Now;
        if (testTime > endTime)
        {
            _timesUp = true; // the allotted time has been exceeded
        }
        return _timesUp;
    }

    public void Countdown()
    {
        for (int i = 5; i > 0; i--) // loop to print a countdown to the terminal
        {
            Console.Write($"Get Ready: {i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b"); // backspaces, writes a space over the + that was there, then backspaces again
        }
    }

    public void Spinner(int seconds)
    {
        for (int i = seconds; i > 0; i--) // loop to print a countdown to the terminal
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b"); // backspaces, writes a space over the + that was there, then backspaces again
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

}