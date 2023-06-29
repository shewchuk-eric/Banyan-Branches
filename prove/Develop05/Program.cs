using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goalsList = new List<Goal>();
        Goal goalManager = new Goal(); // create new Goal object which will give access to methods found in Goal
        bool runIt = true; // keeps program running until user selects 'quit'
        while (runIt)
        {
            string choice = goalManager.GetSelection();
            switch(choice)
            {
                case "1":
                Console.WriteLine("\nThe Types Of Goals Are:\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal");
                Console.Write("Which Type Of Goal Would You Like To Create? ");
                string choice2 = Console.ReadLine();
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of the goal? ");
                string desc = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                string points = Console.ReadLine();
                    switch(choice2)
                    {
                    case "1":
                    _goalsList.Add(new Simple("Simple",name,desc,points,"0","0","0"));
                    break;

                    case "2":
                    _goalsList.Add(new Eternal("Eternal",name,desc,points,"0","0","0"));
                    break;

                    case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string iter = Console.ReadLine();
                    Console.Write($"What is the bonus for accomplishing this goal {iter} times? ");
                    string bonus = Console.ReadLine();
                    _goalsList.Add(new Checklist("Checklist",name,desc,points,bonus,iter,"0"));
                    break;

                    default:
                    Console.WriteLine($"{choice2} is not a valid entry.");
                    continue;   
                    }
                break;

                case "2":
                ShowGoals();
                break;

                case "3":
                goalManager.WriteGoals(_goalsList);
                break;

                case "4":
                goalManager.LoadFile(_goalsList); // load the saved entries from 'goals.txt'
                break;

                case "5":
                Console.WriteLine("\nPlease choose from the following list:");
                ShowGoals();
                goalManager.RecordEvent(_goalsList);
                break;

                case "6":
                runIt = false;
                break;
                
                default:
                    Console.WriteLine($"{choice} is not a valid entry.");
                    continue;
            }

            void ShowGoals()
            {
                Console.WriteLine("");
                int counter = 1;
                if (_goalsList.Count > 0)
                {
                    foreach (Goal i in _goalsList)
                    {
                    Console.Write($"{counter}. ");
                    goalManager.ListGoals(i);
                    counter ++;
                    }
                } else {Console.WriteLine("There are no loaded goals\n");}
            }
        }
    }
}