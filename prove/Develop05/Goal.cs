using System.IO;
public class Goal
{
    public List<Goal> _goalsList = new List<Goal>(); // holds information for unsaved goals 
    public string _type; // _goalsList[0]  type of goal -> i.e. simple, eternal, checklist
    public string _name; // _goalsList[1]  name of goal
    public string _desc; // _goalsList[2]  description of goal
    public string _points = "0"; // _goalsList[3]  how many points the goal is worth
    public string _bonus = "0"; // _goalsList[4]  how many bonus points the goal will earn
    public string _iter = "0"; // _goalsList[5]  how many times the goal NEEDS to be completed
    public string _done = "0"; // _goalsList[6]  how many time the goal HAS been completed
    public string _complete = " "; // _goalsList[7]  goal completion status
    private int _totalScore; // all completed goal scores added together

    /***************
    * CONSTRUCTORS *
    ****************/

    public Goal() // creates object to start program - loads saved goals from file
    {
        LoadFile(); // load the saved entries from 'goals.txt'
    }

    public Goal(string empty) { } // creates object for loading saved goals from file
    public Goal(string type, string name, string desc, string points, string bonus, string iter, string done)
    {
        _type = type;
        _name = name; // name of goal
        _desc = desc; // description of goal
        _points = points; // how many points the goal is worth
        _bonus = bonus; // how many bonus points the goal will earn
        _iter = iter; // how many times the goal NEEDS to be completed
        _done = done; // how many time the goal HAS been completed
        _complete = " ";
    }

    /**********
    * METHODS *
    **********/

    public virtual void ListGoals() // list all goals including previously saved and newly created goals
    {
        Console.WriteLine("");
        int counter = 1;
        foreach (Goal i in _goalsList)
        {
            Console.Write($"{counter}. ");
            Console.WriteLine($"[{i._complete}] {i._name} ({i._desc})");
            counter ++;
        }
        Console.WriteLine("");
    }
    
    public void SetNewGoal(Goal newGoal) // add a newly created goal to the list of stored goals
    {
        _goalsList.Add(newGoal);
        Console.WriteLine($"A new goal of type {newGoal._type} is being recorded.");
    }

    private void LoadFile() // load previously saved files
    {
        string[] loadedEntries = System.IO.File.ReadAllLines("goals.txt"); // read the file into an array
        foreach (string line in loadedEntries) // loop through array to place into current entries for display
            {
                string[] parts = line.Split(","); // split the string into component parts
                Goal loadedEntry = new Goal(" ");
                loadedEntry._type = parts[0];
                loadedEntry._name = parts[1];
                loadedEntry._desc = parts[2];
                loadedEntry._points = parts[3];
                loadedEntry._bonus = parts[4];
                loadedEntry._iter = parts[5];
                loadedEntry._done = parts[6];
                loadedEntry._complete = parts[7];
                _totalScore += int.Parse(parts[6]); // sum the total earned points for retrieval by other functions
                _goalsList.Add(loadedEntry); // add object into entries array
            }
            Spinner();
    }

    private void Spinner() // each loop through is one second long
    {
        Console.Clear();
        Console.Write("\n\nLoading  ");
        for (int i = 3; i > 0; i--) // loop to print a countdown to the terminal - run for 3 seconds
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b"); // backspaces, writes a space over the character that was there, then backspaces again
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
        Console.Clear();
    }

    protected void ShowPoints()
    {
        Console.WriteLine($"\nYou have {_totalScore} points.\n");
    }

    public void WriteGoals()
    {
        string[] savedEntries = System.IO.File.ReadAllLines("goals.txt"); // read existing entries from file and prepare to rewrite them to prevent overwriting
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            foreach (Goal i in _goalsList) // loop through the '_goalsList' list 
            {
                outputFile.WriteLine($"{i._type},{i._name},{i._desc},{i._points},{i._bonus},{i._iter},{i._done},{i._complete}"); // print entries to the file
            }
        }
        _goalsList.Clear(); // clear the List to prevent double-writing of entries
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine("\nPlease choose from the following list:");
        ListGoals();
        Console.Write("Which goal did you accomplish?");
        string option = Console.ReadLine();
        int position = int.Parse(option) - 1; // remove 1 to get correct index position in List
        string score = _goalsList[position]._points; // get the points value of the chosen goal
        int addScore = int.Parse(score); // turn the points string into a number
        _goalsList[position]._done = score; // deliver the completion value into the List for saving to the goals.txt file
        if (_goalsList[position]._type == "Checklist")
        {
            int iterations = int.Parse(_goalsList[position]._iter) + 1;
            int isDone = int.Parse(_goalsList[position]._done);
            if (iterations == isDone)
            {
                _goalsList[position]._complete = "X";
                int bonus = int.Parse(_goalsList[position]._bonus);
            } 
        }
        _goalsList[position]._complete = "X"; // change the status of completed to done
        Console.WriteLine($"Congratulations! You have earned {score} points!\n\nYou now have {_totalScore + addScore} points.");
    }
}