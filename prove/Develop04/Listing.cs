public class Listing : Activity
{
    private string[] _prompts = new string[] {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    private DateTime _start;
    private int _iterations = 0;
    private string _activity = "Listing";
    private string _message = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    public Listing()
    {
        base.Begin(_message, _activity);
        MakeListings();
        base.Finish();
    }

    private void MakeListings()
    {
        _start = base.SetTimer(10);
        Console.Write("Get Ready ... ");
        base.Spinner();
        Console.WriteLine("\nList as many responses as you can to the following prompt: ");
        base.Countdown();
        int number = base.Generator(_prompts.Length); // call random number generator to select an index position
        Console.WriteLine($"--- {_prompts[number]} ---\n"); // print the prompt
        bool test = false;
        while (!test) // loop until time runs out
        {
        Console.Write("> ");
        Console.ReadLine(); // get user input
        _iterations ++; // count the input
        test = base.TimeUp(_start); // check to see if time is up yet
        }
        Console.WriteLine($"You listed {_iterations} items!\n\n");
    }
}