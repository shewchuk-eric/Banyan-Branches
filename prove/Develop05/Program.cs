using System;

class Program
{
    static void Main(string[] args)
    {
        Goal goalManager = new Goal(); // create new Goal object which will automatically load existing goals when instantiated
        bool runIt = true; // keeps program running until user selects 'quit'
        while (runIt)
        {
            Console.WriteLine("Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Record Event\n   5. Quit");
            Console.Write("Select A Choice From The Menu: ");
            string choice = Console.ReadLine();
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
                    Goal simple = new Simple("Simple" ,name, desc, points, "0", "0", "0");
                    goalManager._goalsList.Add(simple);
                    break;

                    case "2":
                    Goal eternal = new Eternal("Eternal", name, desc, points, "0", "0", "0");
                    goalManager._goalsList.Add(eternal);
                    break;

                    case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string iter = Console.ReadLine();
                    Console.Write($"What is the bonus for accomplishing this goal {iter} times? ");
                    string bonus = Console.ReadLine();
                    Goal checklist = new Checklist("Checklist" ,name, desc, points, iter, bonus, "0");
                    goalManager._goalsList.Add(checklist);
                    break;

                    default:
                    Console.WriteLine($"{choice2} is not a valid entry.");
                    continue;   
                    }
                break;

                case "2":
                goalManager.ListGoals();
                break;

                case "3":
                goalManager.WriteGoals();
                break;

                case "4":
                goalManager.RecordEvent();
                break;

                case "5":
                runIt = false;
                break;
                
                default:
                    Console.WriteLine($"{choice} is not a valid entry.");
                    continue;
            }
        }
    }
}