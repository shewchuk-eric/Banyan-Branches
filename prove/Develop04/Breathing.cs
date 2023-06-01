public class Breathing : Activity
{    
    private string _activity = "Breathing";
    private string _mainMessage = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.";
    private DateTime _start;
    
    public Breathing()
    {
        base.StartMessage(_activity, _mainMessage);
        _start = base.SetTimer(5);
        Cycle();
        Console.WriteLine("Well Done!\n");
        base.Spinner(3);
        base.EndMessage(_activity);
        base.Spinner(3);
    }

    private void Cycle()
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