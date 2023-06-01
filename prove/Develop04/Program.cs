using System;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true; // runs main loop until user types 'quit'

        while(runProgram)
        {
            Console.Write("Menu Options:\n  1. Start Breathing Activity\n  2. Start Reflecting Activity\n  3. Start Listing Activity\n  4. Quit\nSelect a choice from the menu: ");
            string option = Console.ReadLine();
            switch(option)
            {
                case "1":
                Breathing inhale = new Breathing();
                break;
                case "2":
                Reflection deepThoughts = new Reflection();
                break;
                case "3":
                Listing doThis = new Listing();
                break;
                case "4":
                runProgram = false;
                Console.WriteLine("Thanks for using the Mindfulness app.\n");
                break;
                default:
                    Console.WriteLine($"{option} is not a valid entry.");
                    continue;
            }
        }
    }
}


// 

// Welcome to the {Breathing Activity}.\n This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.

// Welcome to the {Reflection Activity}.\n This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.

// Welcome to the {Listing Activity}\n. This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.



