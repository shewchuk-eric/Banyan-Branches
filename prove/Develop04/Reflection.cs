public class Reflection : Activity
{
    private string[] _prompts = new string[] {"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
    private string[] _questions = new string[] {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    private List<int> _used = new List<int>(); // holds the word index positions that have been blanked out
    private DateTime _start;

    public Reflection(string activity, string mainMessage) : base(activity, mainMessage)
    {
    }

    public void StartTimer(int delay)
    {
        _start = base.SetTimer(delay);
    }

    public void Prompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Random randomGenerator = new Random(); // create a random number generator
        int number = randomGenerator.Next(0, _prompts.Length);
        Console.WriteLine($"--- {_prompts[number]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void Question()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.\n");
        base.Countdown();
        Console.Clear();
        bool test = false;
        while (!test)
        {
            Random randomGenerator = new Random(); // create a random number generator
            int number = randomGenerator.Next(0, _questions.Length);
            if (_used.Contains(number)) // check if random number has been used already
            {
                continue; // random number already used so get another one           
            }
        else // print the question and add its index to the _used List
            {
                Console.WriteLine($"> {_questions[number]}");
                base.Spinner(8); // show the spinner for 5 seconds
                _used.Add(number); // add number to used numbers list so it cannot be used again
                test = base.TimeUp(_start); // check to see if time is up yet
            }
        }
        
    }
}