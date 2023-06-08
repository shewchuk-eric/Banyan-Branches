public class Reflection : Activity
{
    private string[] _prompts = new string[] {"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
    private string[] _questions = new string[] {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    private List<int> _used = new List<int>(); // holds the question index positions that have been used so there won't be repeats
    private DateTime _start;
    private string _activity = "Reflection";
    private string _message = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    public Reflection()
    {
        base.Begin(_message, _activity);
        Prompt();
        base.Finish();
    }

    private void Prompt()
    {
        _start = base.SetTimer(10); // start the timer and add delay to account for spinners and countdowns
        Console.WriteLine("Consider the following prompt: ");
        int number = base.Generator(_prompts.Length); // call random number generator to select an index position
        Console.WriteLine($"--- {_prompts[number]} ---\n"); // print the chosen prompt
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine(); // waiting for user to press enter key
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.\n");
        base.Countdown();
        Console.Clear();
        bool test = false;
        while (!test) // loop until the user selected time has passed
        {
            int rando = base.Generator(_questions.Length); // call random number generator to select an index position
            if (_used.Contains(rando)) // check if random number has been used already
            {
                continue; // random number already used so get another one           
            }
        else // print the question and add its index to the _used List
            {
                Console.WriteLine($"> {_questions[rando]}");
                base.Spinner(); // show the spinner for 5 seconds
                _used.Add(rando); // add number to used numbers list so it cannot be used again
                test = base.TimeUp(_start); // check to see if time is up yet
            }
        }     
    }
}