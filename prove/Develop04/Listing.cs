public class Listing : Activity
{
    private string[] _prompts = new string[] {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    private DateTime _start;
    private int _iterations = 0;

    public Listing(string activity, string mainMessage) : base(activity, mainMessage)
    {
        
    }

    public void StartTimer(int delay)
    {
        _start = base.SetTimer(delay);
    }

    public void MakeListings()
    {
        Console.Write("Get Ready ... ");
        //base.Spinner(5);
        Console.WriteLine("\nList as many responses as you can to the following prompt: ");
        //base.Countdown();
        Random randomGenerator = new Random(); // create a random number generator
        int number = randomGenerator.Next(0, _prompts.Length);
        Console.WriteLine($"--- {_prompts[number]} ---\n");
        bool test = false;
        while (!test)
        {
        Console.Write("> ");
        Console.ReadLine();
        _iterations ++;
        //test = base.TimeUp(_start); // check to see if time is up yet
        }
    }

    public int GetIterations()
    {
        return _iterations;
    }
}