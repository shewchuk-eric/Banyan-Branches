public class Breathing : Activity
{    
  
    private DateTime _start;
    
    public Breathing(string activity, string mainMessage) : base(activity, mainMessage)
    {

    }

    public void StartTimer(int delay)
    {
        _start = base.SetTimer(delay);
    }

    public void Cycle()
    {
        base.Countdown(); // initiate the starting countdown
        bool test = false;
        while (!test)
        {
            for (int i = 5; i > 0; i--) // loop to print a countdown to the terminal
            {
                Console.Write($"Breathe In... {i}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); // backspaces, writes a space over the + that was there, then backspaces again
            }
            Console.WriteLine("");
            for (int i = 6; i > 0; i--) // loop to print a countdown to the terminal
            {
                Console.Write($"Now Breathe Out... {i}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); // backspaces, writes a space over the + that was there, then backspaces again
            }
            Console.WriteLine("\n");
            test = base.TimeUp(_start);
        }
    }
}