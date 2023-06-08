public class Breathing : Activity
{    
  
    private DateTime _start;
    private string _message = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.";
    private string _activity = "Breathing";
    
    public Breathing()
    {
        base.Begin(_message, _activity);
        Cycle();
        base.Finish();
    }


    public void Cycle()
    {
        _start = base.SetTimer(5); // start the timer and add delay to account for spinners and countdowns
        base.Countdown(); // initiate the starting countdown
        bool test = false;
        while (!test) // loop until the time set by user has elapsed
        {
            for (int i = 5; i > 0; i--) // loop to print a countdown to the terminal - 5 seconds
            {
                Console.Write($"Breathe In... {i}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); // backspaces to clear the line then reprints in the same space
            }
            Console.WriteLine("");
            for (int i = 6; i > 0; i--) // loop to print a countdown to the terminal - 6 seconds
            {
                Console.Write($"Now Breathe Out... {i}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); // backspaces to clear the line then reprints in the same space
            }
            Console.WriteLine("\n");
            test = base.TimeUp(_start); // check to see if allotted time has elapsed - kills loop if so
        }
    }
}