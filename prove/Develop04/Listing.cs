public class Listing : Activity
{
    private string _activity = "Listing";
    private string _mainMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string[] _prompts = new string[] {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    private DateTime _start;
    private int _iterations = 0;

    public Listing()
    {
        base.StartMessage(_activity, _mainMessage);
        _start = base.SetTimer(15);
        MakeListings();
        Console.WriteLine($"You listed {_iterations} items!\n\nWell Done!\n");
        base.Spinner(3);
        base.EndMessage(_activity);
        base.Spinner(3);
    }

    private void MakeListings()
    {
        Console.Write("Get Ready ... ");
        base.Spinner(5);
        Console.WriteLine("\nList as many responses as you can to the following prompt: ");
        base.Countdown();
        Random randomGenerator = new Random(); // create a random number generator
        int number = randomGenerator.Next(0, _prompts.Length);
        Console.WriteLine($"--- {_prompts[number]} ---\n");
        bool test = false;
        while (!test)
        {
        Console.Write("> ");
        Console.ReadLine();
        _iterations ++;
        test = base.TimeUp(_start); // check to see if time is up yet
        }
    }
}