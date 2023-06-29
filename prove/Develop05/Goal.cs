using System.IO;
public class Goal
{
    public string _type; // _goalsList[0]  type of goal -> i.e. simple, eternal, checklist
    public string _name; // _goalsList[1]  name of goal
    public string _desc; // _goalsList[2]  description of goal
    public string _points; // _goalsList[3]  how many points the goal is worth
    public string _bonus; // _goalsList[4]  how many bonus points the goal will earn
    public string _iter; // _goalsList[5]  how many times the goal NEEDS to be completed
    public string _done; // _goalsList[6]  how many time the goal HAS been completed
    public string _earned; // _goalsList[7]  how many points have been earned by this activity
    public string _complete; // _goalsList[8]  goal completion status
    private int _totalScore; // all completed goal scores added together
    private bool _areLoaded = false; // test if goals have been loaded before writing to file >>> prevents overwriting previously saved goals

    /***************
    * CONSTRUCTORS *
    ****************/

    public Goal() {} 

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
        _earned = "0"; 
        _complete = " ";
    }

    /**********
    * METHODS *
    **********/

    public string GetSelection()
    {
        Console.WriteLine("Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit");
        Console.Write("Select A Choice From The Menu: ");
        string choice = Console.ReadLine();
        return choice;
    }

    public virtual void ListGoals(Goal i) // list all goals including previously saved and newly created goals
    {   
        if (i._iter != "0")
        {
            Console.WriteLine($"[{i._complete}] {i._name} ({i._desc}) -- Currently completed: {i._done}/{i._iter}");
        } else 
        {
            Console.WriteLine($"[{i._complete}] {i._name} ({i._desc})");
        }
    }

    public void LoadFile(List<Goal> _goalsList) // load previously saved files
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
                loadedEntry._earned = parts[7];
                loadedEntry._complete = parts[8];
                _totalScore += int.Parse(parts[7]); // sum the total earned points for retrieval by other functions
                _goalsList.Add(loadedEntry); // add object into entries array
            }
            Spinner();
            _areLoaded = true;
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

    public void WriteGoals(List<Goal> _goalsList)
    {
        string[] savedEntries = System.IO.File.ReadAllLines("goals.txt"); // read existing entries from file and prepare to rewrite them to prevent overwriting
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            if (!_areLoaded)
            {
                foreach (string i in savedEntries)
                {
                    outputFile.WriteLine($"{i}");
                }
            }
            foreach (Goal i in _goalsList) // loop through the '_goalsList' list 
            {
                outputFile.WriteLine($"{i._type},{i._name},{i._desc},{i._points},{i._bonus},{i._iter},{i._done},{i._earned},{i._complete}"); // print entries to the file
            }
        }
        Console.WriteLine("\nYour goals have been saved to the file.\n");
        _goalsList.Clear(); // clear the List to prevent double-writing of entries
    }

    public virtual void RecordEvent(List<Goal> _goalsList)
    {
        Console.Write("Which goal did you accomplish? ");
        string option = Console.ReadLine();
        int position = int.Parse(option) - 1; // remove 1 to get correct index position in List
        int score = int.Parse(_goalsList[position]._points); // get the value of each completion of this goal
        if (_goalsList[position]._type == "Simple")
        {
            _goalsList[position]._complete = "X"; // change the status of completed to done
            _goalsList[position]._earned = _goalsList[position]._points; // change the earned points to the value of the goal
        }        
        else if (_goalsList[position]._type == "Eternal")
        {          
            score += int.Parse(_goalsList[position]._earned); // add the score to any previous completions
            _goalsList[position]._earned = score.ToString(); // put the new score into the List
        }
        else
        {
            int iterations = int.Parse(_goalsList[position]._done) + 1; // get the number of times this goal has been completed
            _goalsList[position]._done = iterations.ToString();
            int isDone = int.Parse(_goalsList[position]._iter); // get the number of times this goal needs to be completed 
            if (iterations == isDone) // the goal has been completed the specified number of times
            {
                _goalsList[position]._complete = "X"; // mark the goal complete
                int bonus = int.Parse(_goalsList[position]._bonus); // get the bonus value
                score += bonus + int.Parse(_earned); // add the bonus to the points for the current completion and to the points previously earned
                _goalsList[position]._earned = score.ToString(); // put the new score into the List 
            } 
        }
        Console.WriteLine($"\nCongratulations! You have earned {score} points!\nYou now have {_totalScore + score} points.\n");
    }
}