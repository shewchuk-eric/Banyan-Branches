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
                string activity = "Breathing";
                string mainMessage = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.";
                Activity breath = new Activity();
                Breathing inhale = new Breathing(activity, mainMessage);
                inhale.StartMessage();
                inhale.StartTimer(5);
                inhale.Cycle();
                Console.WriteLine("Well Done!\n");
                inhale.Spinner(3);
                inhale.EndMessage(activity);
                inhale.Spinner(3);
                break;
                case "2":
                string activity2 = "Reflection";
                string mainMessage2 = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Activity think = new Activity();
                Reflection deepThoughts = new Reflection(activity2, mainMessage2);
                deepThoughts.StartMessage();
                deepThoughts.StartTimer(15);
                deepThoughts.Countdown();
                deepThoughts.Prompt();
                deepThoughts.Question();
                Console.WriteLine("Well Done!\n");
                deepThoughts.Spinner(3);
                deepThoughts.EndMessage(activity2);
                deepThoughts.Spinner(3);
                break;
                case "3":
                string activity3 = "Listing";
                string mainMessage3 = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                Activity typeIt = new Activity();
                Listing doThis = new Listing(activity3, mainMessage3);
                doThis.StartMessage();
                doThis.StartTimer(10);
                doThis.MakeListings();
                Console.WriteLine($"You listed {doThis.GetIterations()} items!\n\nWell Done!\n");
                doThis.Spinner(3);
                doThis.EndMessage(activity3);
                doThis.Spinner(3);
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