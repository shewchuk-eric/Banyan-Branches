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
                Activity activity = new Breathing();
                break;

                case "2":
                Activity activity2 = new Reflection();
                break;

                case "3":
                Activity activity3 = new Listing();
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